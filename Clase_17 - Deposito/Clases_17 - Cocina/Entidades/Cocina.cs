using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        #region "Constructor"

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }

        #endregion

        #region "Get"

        public int Codigo
        {
            get
            {
                return this._codigo;
            }
        }

        public bool EsIndustrial
        {
            get
            {
                return this._esIndustrial;
            }
        }

        public double Precio
        {
            get
            {
                return this._precio;
            }
        }
        #endregion

        #region "Sobrecarga"

        public static bool operator ==(Cocina a, Cocina b)
        {
            bool retorno = false;

            if(a.Codigo == b.Codigo)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        #endregion

        #region "Polimorfismo"

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is Cocina)
            {
                if ((Cocina)obj == this)
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
            return "Código: " + this.Codigo + " - Precio: " + this.Precio + " - Es industrial? " + this.EsIndustrial +"\n";
        }

        #endregion

    }
}
