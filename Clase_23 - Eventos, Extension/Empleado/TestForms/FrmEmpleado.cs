using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace TestForms
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();


        }

        public static void LimiteSueldoEmpleado(EmpleadoMejorado e, EmpleadoSueldoArgs s)
        {
            Console.WriteLine("El empleado " + e.Nombre + " con legajo " + e.Legajo.ToString() + " se le asigno el sueldo " + s.ToString());
        }

        public void GuardarLog(EmpleadoMejorado e, EmpleadoSueldoArgs s)
        {
            StreamWriter streamWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"incidentes.log", true);

            try
            {
                streamWriter.WriteLine(DateTime.Now);
                streamWriter.WriteLine("Nombre: {0}", e.Nombre);
                streamWriter.WriteLine("Legajo: {0}", e.Legajo);
                streamWriter.WriteLine("Sueldo: {0}", e.Sueldo);
                streamWriter.Close();
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            EmpleadoMejorado empleado = new EmpleadoMejorado();

            empleado.Nombre = this.textBoxNombre.Text.ToString();
            empleado.Legajo = int.Parse(this.textBoxLegajo.ToString());
            empleado.Sueldo = float.Parse(this.textBoxSueldo.ToString());

            if((TipoManejador)comboBox.SelectedItem == TipoManejador.Ambos)
            {
                empleado.delSueldo += new DelSueldo(LimiteSueldoEmpleado);
                empleado.delSueldo += new DelSueldo(GuardarLog);
            }

            else if((TipoManejador)comboBox.SelectedItem == TipoManejador.LimiteSueldo)
            {
                empleado.delSueldo += new DelSueldo(LimiteSueldoEmpleado);
            }

            else if((TipoManejador)comboBox.SelectedItem == TipoManejador.Log)
            {
                empleado.delSueldo += new DelSueldo(GuardarLog);
            }
        }
    }
}
