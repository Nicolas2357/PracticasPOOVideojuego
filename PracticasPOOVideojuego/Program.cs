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

            juego.MostrarInfo();

            Console.WriteLine();

            juego.Iniciar();
            juego.GuardarPartida();
            juego.Cerrar();
        }
    }
}
