using System;

namespace Entidades
{
    public class Tinta
    {
        private ConsoleColor _Color;
        private eTipoTinta _TipoTinta;

        #region constructores

        //Si el usuario no expecifica color o la tinta por defoult rellenara los datos con negro y comun
        public Tinta() : this(ConsoleColor.Black, eTipoTinta.Comun)
        {
        }

        public Tinta(ConsoleColor color) : this(color, eTipoTinta.Comun)
        {
        }

        public Tinta(ConsoleColor color, eTipoTinta tipoTinta) //: this(color)
        {
            this._TipoTinta = tipoTinta;//Rellenaria con comun
            this._Color = color;//Rellenaria con negro
        }
        #endregion

        //Funcion para que muestre
        private string Mostrar()
        {
            //ToString se parsea a string
            return "Color: " + this._Color.ToString() + ", Tipo de Tinta: " + this._TipoTinta.ToString();
        }

        //Se hace un funcion publica porque desde el main no se puede llamar
        //Asi que se llama a la privada desde la publica
        public static string Mostrar(Tinta objeto)
        {
            return objeto.Mostrar(); 
        }

        public static bool operator == (Tinta tinta1, Tinta tinta2)
        {
            bool retorno = false;

            if (tinta1._Color == tinta2._Color && tinta1._TipoTinta == tinta2._TipoTinta)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator != (Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }


        public static bool operator == (Tinta tinta, ConsoleColor color)
        {
            bool retorno = false;

            if (tinta._Color == color){
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Tinta tinta, ConsoleColor color)
        {
            return !(tinta == color);
        }
    }
}
