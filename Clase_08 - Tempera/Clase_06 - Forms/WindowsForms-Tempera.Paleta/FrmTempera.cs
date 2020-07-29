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
    public partial class FrmTempera : Form
    {
        private Tempera _MiTempera;

        public Tempera myTempera
        {
            get
            {
                return _MiTempera;
            }
            set
            {
                _MiTempera = value;
            }
        }

        public FrmTempera()
        {
            InitializeComponent();

            //Inicializa el combo box, para que muestre todos los colores
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                CboColor.Items.Add(color);
            }
        }

        public FrmTempera(Tempera indice) : this()//Mostrara la tempera si poder modificarla
        {
            sbyte feo = indice;
            ConsoleColor miColor = indice;
            
            //Tengo que hacer un txtCantidad que me muestre lo que seleccione
            txtCantidad.Text = feo.ToString();
            txtMarca.Text = indice;
            CboColor.Text = miColor.ToString();

            //Anulo las opciones para que no pueda modificar
            txtCantidad.Enabled = false;
            txtMarca.Enabled = false;
            CboColor.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tempera nuevaTempera = new Tempera((ConsoleColor)this.CboColor.SelectedItem, txtMarca.Text, Convert.ToSByte(txtCantidad.Text));//Crea una nueva tempera
            //MessageBox.Show(Tempera.Mostrar(nuevaTempera));
            this._MiTempera = nuevaTempera;
            this.DialogResult = DialogResult.OK;
        }

        private void FrmTempera_Load(object sender, EventArgs e)
        {

        }

        private void CboColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
