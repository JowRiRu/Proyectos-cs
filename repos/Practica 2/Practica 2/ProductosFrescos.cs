using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    internal class ProductosFrescos : Productos
    {
        private string aFechaEnvasado;
        private string aPaisOrigen;

        public ProductosFrescos(string aNombre, int aNumeroLote, string aFechaEnvasado, string aPaisOrigen) : base (aNombre, aNumeroLote)
        {
            this.aFechaEnvasado = aFechaEnvasado;
            this.aPaisOrigen = aPaisOrigen;
        }

        public string nombre {
            get { return this.aNombre;  }
            set { this.aNombre = value; }
        }

        public int numeroLote
        {
            get { return this.aNumeroLote; }
            set { this.aNumeroLote = value; }
        }
        public string fechaEnvasado
        {
            get { return this.aFechaEnvasado; }
            set { this.aFechaEnvasado = value; }
        }

        public string paisOrigen {
            get { return this.aPaisOrigen; }
            set { this.aPaisOrigen = value; }
        }


        public void fMostrar() {
            Console.WriteLine("Nombre del producto Fresco: " + aNombre);
            Console.WriteLine("Numero de lote del producto Fresco: " + aNumeroLote);
            Console.WriteLine("Fecha de envasado del producto Fresco: " + aFechaEnvasado);
            Console.WriteLine("El pais de origen del producto Fresco: " + aPaisOrigen);
        }

        
    }
}
