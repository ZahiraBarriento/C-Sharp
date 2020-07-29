using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *CAMION
 * patente: string
 * marca: Emarca
 * cantidadRuedas: int
 * tara: double
 * MostrarCamion(): string
 */

namespace Clase_09
{
    public class Camion : Vehiculo
    {
        /*HERENCIA
        *Por la herencia tenemos 3 atributos que se utiliza en las 3 clases, para eso se crea una clase base para no repetir codigo
        public string patente;
        public EMarca marca;
        public int cantidadRuedas;
        public double tara;

        public string MostrarCamion()
        {
            return " Patente: " + patente + " Marca: " + marca.ToString() + " Cantidad de ruedas: " + cantidadRuedas.ToString() + " Tara: " + tara.ToString();
        }*/

        //Las clases tienen atrivutos generales como patente, marca, cantidad de rueda y atrivutos espeficifos como tara, cilindrada y cantidad de asientos

        protected double _tara;

        //CONSTRUCTOR
        public Camion(string patente, EMarca marca, int cantidadRuedas, double tara) : base(patente, marca, cantidadRuedas)
        {
            this._tara = tara;
        }

        public string MostrarCamion()
        {
            return base.Mostrar() + " - Tara: " + _tara.ToString();
        }
    }
}
