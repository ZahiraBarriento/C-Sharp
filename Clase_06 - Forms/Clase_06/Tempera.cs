using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Tempera
 * _Color: ConsoleColor
 * _Marca: string
 * _Cantidad: sbyte
 *
 * Costuctor 3 param
 * Mostrar(): sting//instac. priv
 * Mostrar(tempera): string//clase public
 * ==(tempera, tempera): bool //Marca y color
 * +(tempera, sbyte): Tempra//Acumula cantidad
 * +(tempera, tempera):Tempera //Si temperas == acumula la cantidad
 * implicit(tempera):sbyte//retorna cantidad
 * obtener indice(): int //this._temperas[indice]=t;
 */

namespace Clase_06
{
    public class Tempera
    {
        //ATRIVUTOS -> VARIABLES
        private ConsoleColor _Color;
        private string _Marca;
        private sbyte _Cantidad;

        //CONSTRUCTOR
        public Tempera(ConsoleColor color, string marca, sbyte cantidad)
        {
            this._Color = color;
            this._Marca = marca;
            this._Cantidad = cantidad;
        }


        //METODOS
        private string Mostrar()
        {
            return "Marca: " + this._Marca + " Cantidad: " + this._Cantidad.ToString() + " Color: " + this._Color.ToString();
        }

        public static string Mostrar(Tempera tempera)
        {
            string retorno = ""; //Tengo que inicializar los string o me dara error

            if (tempera != null)//Verificar que no sea null
            {
                retorno = tempera.Mostrar();
            }

            return retorno;
        }


        //OPERATOR
        public static bool operator ==(Tempera temp1, Tempera temp2)
        {
            if ((object.Equals(null, temp1) && object.Equals(null, temp2)))//si las dos dan null
            {
                return true;
            }

            else
            {
                if ((object.Equals(null, temp1) || object.Equals(null, temp2)))// solo son iguales cuando los dos son distintos de null
                {
                    return false;
                }

                else if (temp1._Color == temp2._Color && temp1._Marca == temp2._Marca)//las dos ok
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Tempera temp1, Tempera temp2)
        {
            return !(temp1 == temp2);
        }

        public static Tempera operator +(Tempera temp1, sbyte sumar)
        {
            temp1._Cantidad += sumar;
            return temp1;
        }

        public static Tempera operator +(Tempera temp1, Tempera temp2)
        {
            if (temp1 == temp2)
            {
                temp1 += temp2._Cantidad;
            }
            return temp1;
        }

        //CARGAR VALORES
        public static implicit operator sbyte(Tempera tempera)//devuelve la cantidad de tempera
        {
            return tempera._Cantidad;
        }

        public static implicit operator ConsoleColor(Tempera tempera)//Devuelve el color
        {
            return tempera._Color;
        }

        public static implicit operator string(Tempera tempera)//Devuelve la marca
        {
            return tempera._Marca;
        }
    }
}
