using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductosFrescos pf = new ProductosFrescos("Yogurt", 3, "13/07/2021", "Alemania");

            pf.fMostrar();

            ProductosRegrigerados pr = new ProductosRegrigerados("Croquetas de jamon", 71, "12345-CE");

            pr.mostrar();

            ProductosCongelados pc = new ProductosCongelados("Helado Vainilla", 203, -8);

            pc.fmostrar();
        }
    }
}
