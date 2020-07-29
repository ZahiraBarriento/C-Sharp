using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Alumnos
{
    public class Persona
    {
        //Como ver los atributos si son provados, se utiliza una propiedad para mirarlos si es que tengo el codigo fuente
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected ESexo _sexo;

        public Persona(string nombre, string apellido, int edad, ESexo sexo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._sexo = sexo;
        }

    }
}
