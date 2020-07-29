using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Paleta
 * _Temperas: tempera[]
 * _CantidadMaxima: int
 * 
 * Constructor
 * ()-> Maximo 5
 * (int)-> Cantidad de temperas
 * _
 * _Temperas-> new
 * _CantidadMaxima-> 5 o x cantidad
 * implicit (int):paleta
 * Mostrar(): string
 * explicit(Paleta):string
 * == (paleta, tempera): bool
 * + (paleta, tempera):paleta
 * */

namespace Clase_06
{
    public class Paleta
    {
        //ATRIBUTOS -> VARIABLES
        private Tempera[] _Temperas;
        private int _CantidadMaxima;

        //GET
        public Tempera[] _MisTemperas
        {
            get
            {
                return _Temperas;
            }
            set
            {
                _Temperas = value;
            }
        }

        //CONSTRUCTORES
        public Paleta() : this(5)
        {
        }

        public Paleta(int cantidad)
        {
            this._CantidadMaxima = cantidad;
            this._Temperas = new Tempera[cantidad];
        }

        //METODOS
        public static implicit operator Paleta(int cantM)
        {
            Paleta paleta = new Paleta(cantM);
            return paleta;
        }

        private string Mostrar()
        {
            string aux = "";

            foreach (Tempera auxiliar in this._Temperas) //Con el foreach, en el auxilar se le almacena las this.temperas
            {
                aux = aux + "" + Tempera.Mostrar(auxiliar); //Se van cargando todas y se van mostrando
            }

            return "Cantidad " + this._CantidadMaxima.ToString() + "-" + aux; //Retornamos la cantidad maxima y las temperas cargadas
        }

        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();
        }

        private int ObtenerIndice() //Obtiene el indice vacio
        {
            int indice = -1; //Declaramos una variable indice que devuelve -1 si no funciona
            int i = -1;

            foreach (Tempera t in _Temperas) //Recorremos todas las temperas y tomamos el valor en t
            {
                i++;  //Se va incrementando
                if (object.Equals(t, null)) //Comprobamos que parte del vector es null 
                {
                    indice = i;//Si es true, nos devolvera el indice que se encontro
                    break; //Si no le pongo el break seguira iterando
                }
            }

            return indice;
        }

        //OPERATOR
        public static bool operator ==(Paleta pal, Tempera temp)
        {
            bool retorno = false;
            for (int i = 0; i < pal._CantidadMaxima; i++) //Recorro la cantidad maxima de paletas
            {
                if (pal._Temperas[i] == temp) //Si coincide la tempera que esta en la paleta con la tempera pasada devuelve true
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Paleta pal, Tempera temp)
        {
            return !(pal == temp);
        }

        public static Paleta operator +(Paleta pal, Tempera temp)
        {
            int indice = pal.ObtenerIndice();

            //if(indice != -1)
            //{
                if (!(pal == temp))
                {
                    pal._Temperas[indice] = temp;
                }
            //}

            return pal;
        }

        /*vec = new tipo[cantidad];
        int[] a = new int[3];*/
    }
}
