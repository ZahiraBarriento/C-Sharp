using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1";
            int numero;
            int acumulador = 0;
            float promedio = 0;
            int mayor = 0;
            int menor = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write(" Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                acumulador += numero;

                if (i == 0)
                {
                    menor = numero;
                    mayor = numero;
                }

                else
                {
                    if (numero < menor)
                    {
                        menor = numero;
                    }

                    if (numero > mayor)
                    {
                        mayor = numero;
                    }
                }

            }

            promedio = (float)(acumulador / 5d);

            Console.Write(" El promedio es: {0}", promedio);
            Console.Write(" El numero mayor es: {0}", mayor);
            Console.ReadKey();
        }
    }
}
