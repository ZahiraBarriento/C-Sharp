using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06;

namespace WindowsForms
{
    public partial class FrmPaleta : Form
    {
        Paleta nuevaPaleta;

        public FrmPaleta()
        {
            InitializeComponent();

            this.nuevaPaleta = 5;
        }

        private void listLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnMas_Click(object sender, EventArgs e)
        {
            FrmTempera nuevaTempera = new FrmTempera();
            nuevaTempera.ShowDialog();
            
            nuevaPaleta += nuevaTempera.myTempera;
            listLista.Items.Clear();

            foreach (Tempera tempera in nuevaPaleta._MisTemperas)
            {
                if (nuevaTempera.DialogResult == DialogResult.OK && tempera != null)//cuando quiero agregar me da null
                {
                    listLista.Items.Add(Tempera.Mostrar(tempera));
                    
                }
            }
        }

        private void FrmPaleta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MENOS

            int indice = this.listLista.SelectedIndex; //Obtiene el index

            if(indice > -1)
            {
                
                
            }
        }
    }
}
