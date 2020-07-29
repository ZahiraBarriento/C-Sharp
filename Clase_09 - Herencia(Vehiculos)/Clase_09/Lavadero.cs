using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos = new List<Vehiculo>(); //Creo lista generica de vehiculos

        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        //Se le agrega un constructor a vehiculo
        private Lavadero()
        {//Se encarga de inicializar la lista generica
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
        }

        //Retornara la informacion completa de lavadero, precio y cantidad
        public string MiLavadero
        {
            get
            {
                string retorno = "";

                foreach (Vehiculo vehiculo in this._vehiculos)
                {
                    if (vehiculo is Auto)
                    {
                        retorno += ((Auto)vehiculo).MostrarAuto();
                    }

                    if (vehiculo is Moto)
                    {
                        retorno += ((Moto)vehiculo).MostrarMoto();
                    }

                    if (vehiculo is Camion)
                    {
                        retorno += ((Camion)vehiculo).MostrarCamion();
                    }
                }

                return retorno;
            }
        }


        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this.Vehiculos;
            }
        }

        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            bool retorno = false;

            for (int i = 0; i < lavadero._vehiculos.Count; i++)
            {
                if (lavadero._vehiculos[i] == vehiculo)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }

        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {

            foreach (Vehiculo vec in lavadero._vehiculos)
            {
                if (vec != vehiculo)
                {
                    lavadero._vehiculos.Add(vehiculo); //El add agrega un vehiculo al final de la lista
                    break;
                }
            }

            return lavadero;

        }

        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            foreach (Vehiculo vec in lavadero._vehiculos)
            {
                if (vec == vehiculo)
                {
                    lavadero._vehiculos.Remove(vehiculo);//El remove elimina un vehiculo
                    break;
                }
            }

            return lavadero;
        }

        //SOBRECARGA MOSTRAR TOTAL FACTURADO
        public double MostarTotalFacturado(Lavadero lavadero)
        {
            double precioTotal = 0;

            foreach (Vehiculo vehiculo in lavadero._vehiculos)
            {
                precioTotal += lavadero._precioAuto + lavadero._precioCamion + lavadero._precioMoto;
            }

            return precioTotal;
        }
        
        //METODO MOSTRAR TOTAL FACTURADO
        public double MostrarTotalFacturado(EVehiculos tipo)
        {
            double precio = 0;

            foreach (Vehiculo vehiculo in this._vehiculos) 
            {
                if (tipo == EVehiculos.Auto && vehiculo is Auto)
                {
                    precio += this._precioAuto;
                }

                if (tipo == EVehiculos.Camion && vehiculo is Camion)
                {
                    precio += this._precioCamion;
                }

                if (tipo == EVehiculos.Moto && vehiculo is Moto)
                {
                    precio += this._precioMoto;
                }
            }
            return precio;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return string.Compare(vehiculo1.GetPatente, vehiculo2.GetPatente);
        }

        public static int OrdenarVehiculosPorMarca(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return string.Compare(vehiculo1.GetMarca.ToString(), vehiculo2.GetMarca.ToString());
        }
    }
}
