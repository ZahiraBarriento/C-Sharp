using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir mensaje
            Sello.Mensaje = " Hola";
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();

            //Cambiar de color
            Sello.Color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Console.ReadKey();

            //Hacer recuadro
            Console.WriteLine(Sello.ArmarFormatoMensaje());
            Console.ReadKey();

            //Borrar mensaje
            Sello.Borrar();
            Console.WriteLine("\n"Sello.Imprimir());
            Console.ReadKey();
        }
    }
}
