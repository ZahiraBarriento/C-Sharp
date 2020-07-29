using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true; //tiene la capacidad de contener otros formularios
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPaleta nuevaPaleta = new FrmPaleta();
            
            //nuevaPaleta.ShowDialog(); no me va a dejar hacer otra cosa
            nuevaPaleta.MdiParent = this;
            nuevaPaleta.StartPosition = FormStartPosition.CenterScreen;
            nuevaPaleta.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FrmPrincipal_FormClosing(sender, new FormClosingEventArgs(CloseReason.UserClosing, true));
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
