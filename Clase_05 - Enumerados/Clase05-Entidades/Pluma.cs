using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Pluma
 * _Marca: string;
 * _Tinta : Tinta
 * _Cantidad: int
 * 
    Contructor
    * 0, 1, 2 y 3 parametros
    * "sin marca, NULL, 0
    * 
    Instancia
    *Mostrar(): string
    * 
    Operadores
    *==(pluma,tinta): bool
    * si_tinta == tinta
*/

namespace Entidades
{
    public class Pluma
    {
        private string _Marca;
        private Tinta _Tinta;
        private int _Cantidad;

        #region Constructores
        public Pluma() : this("Sin marca", null, 0)
        {
        }

        public Pluma(string marca) : this(marca, null, 0)
        {
        }

        public Pluma(string marca, Tinta tinta) : this(marca, tinta, 0)
        {
        }

        public Pluma(string marca, Tinta tinta, int cantidad)
        {
            //Rellena por defecto
            this._Marca = marca;
            this._Tinta = tinta;
            this._Cantidad = cantidad;
        }
        #endregion

        private string Mostrar()
        {
            return "Marca: " + this._Marca + ", " + Tinta.Mostrar(this._Tinta);
        }

        public static bool operator ==(Pluma tintaPluma, Tinta tipito)
        {
            return (tintaPluma._Tinta == tipito);
        }

        public static bool operator !=(Pluma tintaPluma, Tinta tipito)
        {
            return !(tintaPluma == tipito);
        }

        public static implicit operator string(Pluma plumita)
        {
            return plumita.Mostrar();
        }

        

    }
}
