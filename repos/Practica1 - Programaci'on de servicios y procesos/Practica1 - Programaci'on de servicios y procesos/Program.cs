using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1___Programaci_on_de_servicios_y_procesos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Juan", 52, "12345678A");
            persona.mostrar();
            persona.esMayorDeEdad();

            Cuenta cuenta = new Cuenta("Manel", 15.000);
            cuenta.mostrar();

            cuenta.ingresar(50);
            cuenta.mostrar();

            cuenta.retirar(66);
        }

    }

    internal class Persona {
        private string aNombre;
        private int aEdad;
        private string aDNI;

        public Persona() {
        }

        public Persona(string aNombre, int aEdad, string aDNI)
        {
            this.aNombre = aNombre;
            this.aEdad = aEdad;
            this.aDNI = aDNI;
        }


        public void mostrar() {
            Console.WriteLine("La persona se llama: " + aNombre);
            Console.WriteLine("La persona tiene: " + aEdad);
            Console.WriteLine("La persona tiene el DNI: " + aDNI);
        }

        public void esMayorDeEdad() {


            if (aEdad < 18)
            {
                Console.WriteLine("No es mayor de edad");
            }
            else {
                Console.WriteLine("Es mayor de edad");
            }
        }
    }
    internal class Cuenta {
        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad) {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public void mostrar() {
            Console.WriteLine(titular + " TIENE UN TOTAL DE: ");
            Console.WriteLine(cantidad);
        }

        public void ingresar(double cant) {
            Console.WriteLine("Cuanto quieres ingresar: ");
            if (cant > 0)
            {
                cantidad = cantidad + cant;
                Console.WriteLine("Ahora la cantidad es un total de: " + cantidad);
            }
            else {
                Console.WriteLine("Debes ingresar como mínimo 0,01$");
            }
        }

        public void retirar(double retirada) {
            if (retirada <= 0 || retirada > cantidad)
            {
                Console.WriteLine("Yo creo que eres tonto. No puedes retirar tanto...");
            }
            else {
                cantidad = cantidad - retirada;
                Console.WriteLine("Ahora la cantidad es: " + cantidad);
            }
        }

}
}
