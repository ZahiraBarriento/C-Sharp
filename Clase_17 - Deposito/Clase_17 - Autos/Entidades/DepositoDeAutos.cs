using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        #region "Constructor"

        public DepositoDeAutos(int capacidad)
        {
            this._lista = new List<Auto>();
            this._capacidadMaxima = capacidad;
        }

        #endregion

        #region "Sobrecarga"

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;

            foreach(Auto auto in d._lista)
            {
                if(auto == a)
                {
                    retorno = false;
                }
            }

            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;

            if (d.GetIndice(a) != -1)
            {
                d._lista.Remove(a);
                retorno = true;
            }

            return retorno;
        }

        #endregion

        #region "Metodos"

        private int GetIndice(Auto a)
        {
            int indice = -1;
            int i = -1;

            foreach(Auto auto in this._lista)
            {
                i++;

                if(object.Equals(auto, a))
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }

        public bool Agregar(Auto a)
        {
            bool retorno = false;

            if(this + a)
            {
                retorno = true;
            }

            return retorno;
        }

        public bool Remover(Auto a)
        {
            bool retorno = false;
            
            if(this - a)
            {
                retorno = true;
            }

            return retorno;
        }

        #endregion

        #region "Polimorfismo"

        public override string ToString()
        {
            string s = "";

            s += "Capacidad maxima: " + this._capacidadMaxima + "\nListado de autos: \n";

            foreach (Auto auto in this._lista)
            {
                s += auto;
            }

            return s;
        }

        #endregion

    }
}
