using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    internal class ProductosCongelados : Productos
    {
        private int aTemperaturaCongeladaRecomendada;

        public ProductosCongelados(string aNombre, int aNumeroLote, int aTemperaturaCongeladaRecomendada) : base(aNombre, aNumeroLote)
        {
            this.aTemperaturaCongeladaRecomendada = aTemperaturaCongeladaRecomendada;
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

        public int temperaturaRecomendadaCongelada
        {
            get { return this.aTemperaturaCongeladaRecomendada; }
            set { this.aTemperaturaCongeladaRecomendada = value; }
        }

        public void fmostrar() {
            Console.WriteLine("Nombre del producto Congelado: " + aNombre);
            Console.WriteLine("Fecha de lote del producto Congelado " + aNumeroLote);
            Console.WriteLine("Temperatura recomendada del producto Congelado: " + aTemperaturaCongeladaRecomendada);
        }
    }
}
