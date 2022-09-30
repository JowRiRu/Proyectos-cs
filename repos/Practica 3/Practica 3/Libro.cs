using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class Libro
    {
        //Clase y atributos de la Clase Libro
        private string aTitulo;
        private string aAutor;
        private int aNumeroEjemplares;
        private int aNumeroEjemplaresPrestados;
        private bool comprobacionPrestamo;

        public Libro(string aTitulo, string aAutor, int aNumeroEjemplares, int aNumeroEjemplaresPrestados)
        {
            this.aTitulo = aTitulo;
            this.aAutor = aAutor;
            this.aNumeroEjemplares = aNumeroEjemplares;
            this.aNumeroEjemplaresPrestados = aNumeroEjemplaresPrestados;
        }

        //Getters y Setters de la clase Libro
        public string titulo
        {
            get { return this.aTitulo; }
            set { this.aTitulo = value; }
        }

        public string aautor
        {
            get { return this.aAutor; }
            set { this.aAutor = value; }
        }

        public int numeroEjemplares
        {
            get { return this.aNumeroEjemplares; }
            set { this.aNumeroEjemplares = value; }
        }

        public int numeroEjemplaresPrestados
        {
            get { return this.aNumeroEjemplaresPrestados; }
            set { this.aNumeroEjemplaresPrestados = value; }
        }

        public void prestamo(int prestado) {
            if (prestado > aNumeroEjemplares)
            {
                Console.WriteLine("Lo siento pero no tenemos esa cantidad de libros, si quieres prueba una cantidad mas pequeña");
                comprobacionPrestamo = false;
            }
            else
            {
                aNumeroEjemplaresPrestados += prestado;
                aNumeroEjemplares -= prestado;
                Console.WriteLine("De acuerdo, en esta ocasion se le ha podido prestar el libro solicitado.");
                comprobacionPrestamo = true;
            }
        }

        public void devolver(int devolucion)
        {

            if (comprobacionPrestamo == false)
            {
                Console.WriteLine("No puede devolver nada, no tiene prestado ningun libro.");
            }
            else if (comprobacionPrestamo == true)
            {
                Console.WriteLine("De acuerdo se le van a devolver los prestamos pertinentes.");
                if (devolucion <= aNumeroEjemplaresPrestados && devolucion <= aNumeroEjemplaresPrestados)
                {
                    numeroEjemplares += devolucion;
                    aNumeroEjemplaresPrestados -= devolucion;
                }
                else {
                    Console.WriteLine("No me regales libro bro, no puedes devolver libros que no tienes prestados.");
                }

            }
        }
        public void mostrar()
            {
                Console.WriteLine("El titulo del libro " + aTitulo);
                Console.WriteLine("El autor del Libro " + aAutor);
                Console.WriteLine("Ejemplares restantes: " + aNumeroEjemplares);
                Console.WriteLine("Ejemplares prestados: " + aNumeroEjemplaresPrestados);
            }
        }

    }

