using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Alumnos
{
  public class PersonaExterna : Persona
  {
    //Si no se tiene el codigo fuente se acceden a traves de herencia, y se hacen propiedades

    public PersonaExterna(string nombre, string apellido, int edad, ESexo sexo) : base (nombre, apellido, edad, sexo)
    {

    }

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

    public string Apellido
    {
      get
      {
        return this._apellido;
      }
      set
      {
        this._apellido = value;
      }
    }

    public int Edad
    {
      get
      {
        return this._edad;
      }
      set
      {
        this._edad = value;
      }
    }

    public ESexo Sexo
    {
      get
      {
        return this._sexo;
      }
      set
      {
        this._sexo = value;
      }
    }
    #endregion
  }
}
