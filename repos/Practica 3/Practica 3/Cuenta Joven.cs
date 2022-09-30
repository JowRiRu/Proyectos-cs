using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class Cuenta_Joven
    {
        //Clase Cuenta-Joven
        private string aTitular;
        private int aCantidad;
        private int aEdad;
        private bool comprobacionEdad;

        public Cuenta_Joven(string aTitular, int aCantidad, int aEdad)
        {
            this.aTitular = aTitular;
            this.aCantidad = aCantidad;
            this.aEdad = aEdad;
        }
        //Getter and Setter
        public string titular
        {
            get { return this.aTitular; }
            set { this.aTitular = value; }
        }

        public int cantidad
        {
            get { return this.aCantidad; }
            set { this.aCantidad = value; }
        }

        public int edad
        {
            get { return this.aEdad; }
            set { this.aEdad = value; }
        }

        //Metodos y Funciones

        public void fEsMayorDeEdad()
        {
            
            if (aEdad >= 18)
            {
                if (aEdad <= 25)
                {
                  
                    comprobacionEdad = true;
                }
                else
                {
                    comprobacionEdad = false;
                }
            }

            if (comprobacionEdad == false) {
                Console.WriteLine("No es valido para la cuenta joven, lo siento");

            } 
            else if (comprobacionEdad == true)
            {
                Console.WriteLine("Eres valido para la cuenta joven");
            }



        }

        public void retirada(int aRetirada) {
            if (comprobacionEdad == true) {
                Console.WriteLine("De acuerdo se le restara: " + aRetirada + " a " + aCantidad);
                aCantidad -= aRetirada;
            } 
            else
            { 
                Console.WriteLine(" Que quieres retirar tu bobo ? Tira pa la escuela o pa levantar el pais, me da igual lo que hagas pero este no es tu sitio vete, CABEZON!!");
            }
        }

        public void mostrar() {
            Console.WriteLine("El titular: " + aTitular);
            Console.WriteLine("Cantidad: " + aCantidad);
            Console.WriteLine("Edad: " + aEdad);
        }


    }
}
