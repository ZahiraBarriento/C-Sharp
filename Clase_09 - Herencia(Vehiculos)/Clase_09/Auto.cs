using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * AUTO
 * patente: string
 * marca: Emarca
 * cantidadRuedas: int
 * cantidadAsientos: int
 * MostrarAuto(): string
 */

namespace Clase_09
{
    public class Auto : Vehiculo
    {
        /*HERENCIA
        *Por la herencia tenemos 3 atributos que se utiliza en las 3 clases, para eso se crea una clase base para no repetir codigo
        public string patente;
        public string patente;
        public EMarca marca;
        public int cantidadRuedas;
        public int cantidadAsientos;


        public string MostrarAuto()
        {
            return " Patente: " + patente + " Marca: " + marca.ToString() + " Cantidad de ruedas: " + cantidadRuedas.ToString() + " Cantidad de asientos: " + cantidadAsientos.ToString();
        }*/

        //Las clases tienen atrivutos generales como patente, marca, cantidad de rueda y atrivutos espeficifos como tara, cilindrada y cantidad de asientos

        protected int _cantidadAsientos;

        //CONSTRUCTOR
        public Auto(string patente, EMarca marca, int cantidadRuedas, int cantidadAsientos) : base(patente, marca, cantidadRuedas)
        {
            this._cantidadAsientos = cantidadAsientos;
        }

        public string MostrarAuto()
        {
            return base.Mostrar() + " - Cantidad de asientos: " + _cantidadAsientos.ToString();
        }
    }
}
