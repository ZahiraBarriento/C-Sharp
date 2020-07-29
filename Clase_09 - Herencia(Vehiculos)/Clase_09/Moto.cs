using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * MOTO
 * patente: string
 * marca: Emarca
 * cantidadRueda: int
 * cilindradra: double
 * MostrarMoto():string
 */

namespace Clase_09
{
    public class Moto : Vehiculo
    {
        /*HERENCIA
        *Por la herencia tenemos 3 atributos que se utiliza en las 3 clases, para eso se crea una clase base para no repetir codigo
        public string patente;
        public string patente;
        public EMarca marca;
        public int cantidadRuedas;
        public double cilindrada;


        public string MostrarMoto()
        {
            return " Patente: " + patente + " Marca: " + marca.ToString() + " Cantidad de ruedas: " + cantidadRuedas.ToString() + " Cilindra: " + cilindrada.ToString();
        }*/

        //Las clases tienen atrivutos generales como patente, marca, cantidad de rueda y atrivutos espeficifos como tara, cilindrada y cantidad de asientos

        protected double _cilindrada;

        //CONSTRUCTOR
        public Moto(string patente, EMarca marca, int cantidadRuedas, double cilindrada) : base(patente, marca, cantidadRuedas)
        {
            this._cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            return base.Mostrar() + " - Cilindrada: " + _cilindrada.ToString();
        }
    }
}
