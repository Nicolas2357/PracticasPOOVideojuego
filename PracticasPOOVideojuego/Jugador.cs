using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPOOVideojuego
{
    internal class Jugador
    {
        private string nombre;
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value > 0)
                    edad = value;
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Jugador: " + nombre);
            Console.WriteLine("Edad: " + edad);
        }
    }
}
