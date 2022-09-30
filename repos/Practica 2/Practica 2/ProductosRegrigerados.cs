using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    internal class ProductosRegrigerados : Productos
    {
        private string aCodigoOrganismo;

        public ProductosRegrigerados(string aNombre, int aNumeroLote, string aCodigoOrganismo) : base(aNombre, aNumeroLote) { 
            this.aCodigoOrganismo = aCodigoOrganismo;
        }

        public string nombre
        {
            get { return this.aNombre; }
            set { this.aNombre = value; }
        }

        public int numeroLote
        {
            get { return this.aNumeroLote; }
            set { this.aNumeroLote = value; }
        }

        public string codigoOrganismo
        {
            get { return this.aCodigoOrganismo; }
            set { this.aCodigoOrganismo = value; }
        }

        public void mostrar() {
            Console.WriteLine("Nombre del producto Refrigerado: " + aNombre);
            Console.WriteLine("Numero de lote del producto Refrigerado: " + aNumeroLote);
            Console.WriteLine("Codigo del organismo: " + aCodigoOrganismo);
        }
    }
}
