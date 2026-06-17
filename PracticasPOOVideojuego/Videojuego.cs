using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPOOVideojuego
{
    internal class Videojuego
    {
        private string nombre;
        private string genero;
        private double precio;
        private string plataforma;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                if (value >= 0)
                    precio = value;
            }
        }

        public string Plataforma
        {
            get { return plataforma; }
            set { plataforma = value; }
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Género: " + genero);
            Console.WriteLine("Precio: $" + precio);
            Console.WriteLine("Plataforma: " + plataforma);
        }

        public void Iniciar()
        {
            Console.WriteLine("Iniciando videojuego...");
        }

        public void GuardarPartida()
        {
            Console.WriteLine("Partida guardada.");
        }

        public void Cerrar()
        {
            Console.WriteLine("Cerrando videojuego...");
        }
    }
}