using System;

namespace Clase_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Console.ReadKey(); //Espera
            //Console.ReadLine(); Tambien espera pero agrega un\n*/

            Console.Write(" Ingrese su nombre: ");
            string nombre = Console.ReadLine(); //Va parentecis porque llama a una funcion
            Console.Write(" Su nombre es: {0}", nombre); //Le paso el parametro donde guardo el nombre para mostrar
            /*
             Tambien lo puedo hacer de esta menera
              Console.Write(" Ingrese su nombre: "); 
              Console.Write(Console.ReadLine());
              Console.ReadLine();
             */
            Console.ReadKey();
        }
    }
}
