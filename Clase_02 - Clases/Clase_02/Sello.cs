using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Sello
    {
        //Métodos 
        /*
         * Imprimir() : string
         * Borrar() : void
         * Mensaje() : string
         * ImprimirEnColor() : void
         * ArmarFormatoMensaje() : string
         * A los metodos siempre agregar el static o sino no se puede acceder
         */

        public static string Mensaje;
        public static ConsoleColor Color;

        public static string Imprimir()
        {
            return Sello.Mensaje;
        }

        public static void Borrar()
        {
            Sello.Mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.Color;
            Console.WriteLine(Sello.Mensaje);
        }

        public static string ArmarFormatoMensaje()
        {
            int len = Sello.Mensaje.Length; ;
            string techo = "";
            string mensajeFormato;

            for (int i = 0; i < len + 2; i++)
            {
                techo += "*";
            }

            mensajeFormato = "\n*" + Mensaje + "*\n";
            mensajeFormato = techo + mensajeFormato + techo;

            return mensajeFormato;
        }
    }
}

