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

            juego.Nombre = "Minecraft";
            juego.Genero = "Sandbox";
            juego.Precio = 599;
            juego.Plataforma = "PC";

            Jugador jugador = new Jugador();

            jugador.Nombre = "Juan";
            jugador.Edad = 18;

            Console.WriteLine("=== Información del Jugador ===");
            jugador.MostrarInfo();

            Console.WriteLine();

            Console.WriteLine("=== Información del Videojuego ===");
            juego.MostrarInfo();
        }
    }
}
