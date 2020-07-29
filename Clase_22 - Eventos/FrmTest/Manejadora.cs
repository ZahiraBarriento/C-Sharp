using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_22___FrmTest
{
    public class Manejadora
    {
        //Se usa la misma firma que requiere un delegado
        //void,object,EventArgs
        public static void Manejador(object sender, EventArgs e)
        {
            MessageBox.Show("Metodo public static de la clase Manejadora.");
        }

        public void Manejador2(object sender, EventArgs e)
        {
            MessageBox.Show("Metodo public de la clase Manejadora");

            //Como no se sabe desde donde fue capturada el evento se hacen los if y se "compara" con el sender
            if (sender is Button)
            {
                MessageBox.Show("El evento fue capturado del boton.");
            }
            
            else if(sender is Label)
            {
                MessageBox.Show("El evento fue capturado del label.");
            }

            else
            {
                MessageBox.Show("El evento fue capturado del textbox.");
            }
        }
    }
}
