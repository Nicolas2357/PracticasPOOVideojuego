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

            Console.WriteLine("Primer método:");
            juego.MostrarInfo();

            Console.WriteLine();

            Console.WriteLine("Segundo método:");
            juego.MostrarInfo("Información del videojuego:");

            Console.WriteLine();

            Console.WriteLine("Tercer método:");
            juego.MostrarInfo(true);
        }
    }
}
