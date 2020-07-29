using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_09;

namespace Clase_09_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaro atrivutos para cada una de las clases
            Auto auto = new Auto("ATR", EMarca.Ferrari, 4, 4);
            Camion camion = new Camion("DFR", EMarca.Scania, 4, 48);
            Moto moto = new Moto("ASD", EMarca.Zanella, 2, 8);

            Console.WriteLine(auto.MostrarAuto());
            Console.WriteLine(camion.MostrarCamion());
            Console.WriteLine(moto.MostrarMoto());

            //TIENE LOS CONSTRUCTORES HECHOS
            /*auto.patente = "ATR";
            auto.marca = EMarca.Ferrari;
            auto.cantidadRuedas = 4;
            auto.cantidadAsientos = 4;
            Console.Write(auto.MostrarAuto());

            
            camion.patente = "DFR";
            camion.marca = EMarca.Scania;
            camion.cantidadRuedas = 4;
            camion.tara = 48;
            Console.WriteLine(camion.MostrarCamion());

            moto.patente = "ASD";
            moto.marca = EMarca.Zanella;
            moto.cantidadRuedas = 2;
            moto.cilindrada = 8;
            Console.WriteLine(moto.MostrarMoto());*/

            Console.ReadKey();
        }
    }
}
