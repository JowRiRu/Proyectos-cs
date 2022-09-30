using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta_Joven cj = new Cuenta_Joven("Juancho", 3000, 17);
            /*cj.mostrar();
            cj.fEsMayorDeEdad();
            cj.retirada(200);
            cj.mostrar*/

            Libro libro1 = new Libro("Rapunzel", "yo", 3, 0);
            /*libro1.mostrar();
            libro1.prestamo(1);
            libro1.mostrar();
            libro1.devolver(1);
            libro1.mostrar();
            */

        }
    }
}
