using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_22___FrmTest
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();

            Manejadora manejadora = new Manejadora();

            //El manejador de eventos nunca va a saber cual es su emisor
            //El emisor no puede saber si su evento fue captado, y si lo fue por quien

            //public static void
            this.txtCuadradoTexto.Click += new EventHandler(Manejadora.Manejador);
            this.lblEtiqueta.Click += new EventHandler(Manejadora.Manejador);
            this.btnBoton.Click += new EventHandler(Manejadora.Manejador);

            //public void
            this.txtCuadradoTexto.Click += new EventHandler(manejadora.Manejador2);
            this.lblEtiqueta.Click += new EventHandler(manejadora.Manejador2);
            this.btnBoton.Click += new EventHandler(manejadora.Manejador2);
        }

        private void MostrarMensaje(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del boton.");
            //Mostrara el mensaje del label despues de haer click en el boton, se agrega una nueva direccion de memoria
            //El delegado se encarga de llamar a los eventos
            //this.lblEtiqueta.Click += new EventHandler(this.lblEtiqueta_Click); //Agrega de manera dinamica, de forma estatica es borrar el codigo
            //this.txtCuadradoTexto.Click += new EventHandler(this.txtCuadradoTexto_Click); 
        }

        private void lblEtiqueta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del label.");
            //this.lblEtiqueta.Click -= new EventHandler(this.lblEtiqueta_Click); //Elimina de manera dinamica , de forma estatica es borrar el codigo
        }

        private void txtCuadradoTexto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del textbox.");
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {

        }
    }
}
