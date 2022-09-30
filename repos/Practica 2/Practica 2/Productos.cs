using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    internal class Productos
    {
        public string aNombre;
        public int aNumeroLote;

        public Productos(string aNombre, int aNumeroLote) { 
            this.aNombre = aNombre;
            this.aNumeroLote = aNumeroLote;
        }

        public string nombre {
            get { return this.aNombre; }
            set { aNombre = value; }
        }

        

        public int numeroLote {
            get { return this.aNumeroLote; }
            set { aNumeroLote = value; }
        }


    }
}
