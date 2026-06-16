using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPOOVideojuego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Videojuego juego = new Videojuego();

            juego.Nombre = "The Legend of Zelda";
            juego.Genero = "Aventura";
            juego.Precio = 1299;
            juego.Plataforma = "Nintendo Switch";

            juego.MostrarInfo();

            Console.WriteLine("\nIntentando asignar un precio negativo...");

            juego.Precio = -500;

            juego.MostrarInfo();
        }
    }
}
