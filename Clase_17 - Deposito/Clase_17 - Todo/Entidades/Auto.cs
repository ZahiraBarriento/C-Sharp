using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        #region "Get"

        public string Color
        {
            get
            {
                return this._color;
            }
        }

        public string Marca
        {
            get
            {
                return this._marca;
            }
        }

        #endregion

        #region "Constructor"

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        #endregion

        #region "Sobrecarga"

        public static bool operator ==(Auto a, Auto b)
        {
            bool retorno = false;

            if (a.Marca == b.Marca && a.Color == b.Color)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        #endregion

        #region "Polimorfismo"

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Auto)
            {
                if ((Auto)obj == this)
                {
                    retorno = true;
                }

                else
                {
                    retorno = false;
                }
            }

            return retorno;
        }

        public override string ToString()
        {
            return "Marca: " + this.Marca + " - Color: " + this.Color + "\n";
        }

        #endregion
    }
}
