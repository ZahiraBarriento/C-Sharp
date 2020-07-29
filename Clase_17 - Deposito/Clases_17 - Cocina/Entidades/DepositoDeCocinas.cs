using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        #region "Constructor"

        public DepositoDeCocinas(int capacidad)
        {
            this._lista = new List<Cocina>();
            this._capacidadMaxima = capacidad;
        }

        #endregion

        #region "Sobrecarga"

        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;

            foreach (Cocina cocina in d._lista)
            {
                if (cocina == c)
                {
                    retorno = false;
                }
            }

            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;

            if (d.GetIndice(c) != -1)
            {
                d._lista.Remove(c);
                retorno = true;
            }

            return retorno;
        }

        #endregion

        #region "Metodos"

        private int GetIndice(Cocina c)
        {
            int indice = -1;
            int i = -1;

            foreach (Cocina cocina in this._lista)
            {
                i++;

                if (object.Equals(cocina, c))
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }

        public bool Agregar(Cocina c)
        {
            bool retorno = false;

            if (this + c)
            {
                retorno = true;
            }

            return retorno;
        }

        public bool Remover(Cocina c)
        {
            bool retorno = false;

            if (this - c)
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

            s += "Capacidad maxima: " + this._capacidadMaxima + "\nListado de cocinas: \n";

            foreach (Cocina cocina in this._lista)
            {
                s += cocina;
            }

            return s;
        }

        #endregion
    }
}
