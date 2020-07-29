using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        #region "Constructor"

        public Deposito(int capacidad)
        {
            this._lista = new List<T>();
            this._capacidadMaxima = capacidad;
        }

        #endregion

        #region "Sobrecarga"

        public static bool operator +(Deposito<T> d, T a)
        {
            bool retorno = false;

            foreach (T obj in d._lista)
            {
                if (obj.Equals(a))
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

        public static bool operator -(Deposito<T> d, T a)
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

        private int GetIndice(T a)
        {
            int indice = -1;
            int i = -1;

            foreach (T obj in this._lista)
            {
                i++;

                if (object.Equals(obj, a))
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }

        public bool Agregar(T a)
        {
            bool retorno = false;

            if (this + a)
            {
                retorno = true;
            }

            return retorno;
        }

        public bool Remover(T a)
        {
            bool retorno = false;

            if (this - a)
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

            s += "Capacidad maxima: " + this._capacidadMaxima + "\nListado de " + typeof(T).Name + " : ";

            foreach (T obj in this._lista)
            {
                s += obj;
            }

            return s;
        }

        #endregion
    }
}
