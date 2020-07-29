using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        #region "Atributos"
        private string _nombre;
        private int _legajo;
        private float _sueldo;
        public event DelegadoSueldo limiteSueldo;
        #endregion

        #region "Propiedades"
        public string Nombre
        {
            get
            {
                return this._nombre;
            }

            set
            {
                this._nombre = value;
            }
        }

        public int Legajo
        {
            get
            {
                return this._legajo;
            }

            set
            {
                this._legajo = value;
            }
        }

        public float Sueldo
        {
            get
            {
                return this._sueldo;
            }

            set
            {
                if (value >= 12000)
                {
                    this.limiteSueldo(this, this._sueldo);
                }

                else
                {
                    this._sueldo = value;
                }
            }
        }
        #endregion

        #region "Polimorfismo"
        public override string ToString()
        {
            return "Nombre: " + this.Nombre + " - Legajo: " + this.Legajo + " - Sueldo: " + this.Sueldo;
        }
        #endregion
    }
}
