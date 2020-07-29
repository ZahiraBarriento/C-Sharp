using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpleadoMejorado
    {
        #region "Atributos"
        private string _nombre;
        private int _legajo;
        private float _sueldo;
        public event DelSueldo delSueldo;
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
                    EmpleadoSueldoArgs sueldoArgs = new EmpleadoSueldoArgs();
                    sueldoArgs.Sueldo = value;
                    this.delSueldo(this, sueldoArgs); 
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
