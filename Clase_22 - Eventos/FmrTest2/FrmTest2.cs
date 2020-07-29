using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FmrTest2
{
    public partial class FrmTest2 : Form
    {
        public FrmTest2()
        {
            InitializeComponent();

            this.Load += new EventHandler(this.Inicializar);
        }

        public void MiManejador(object sender, EventArgs e)
        {
            string control = ((Control)sender).Name;

            if(control == "btnBoton1")//Si apreto el 1 andara solo el 2
            {
                this.btnBoton1.Click -= new EventHandler(this.MiManejador);
                this.btnBoton2.Click += new EventHandler(this.MiManejador);
            }

            else if(control == "btnBoton2")//Si apreto el 2 andara solo el 3
            {
                this.btnBoton2.Click -= new EventHandler(this.MiManejador);
                this.btnBoton3.Click += new EventHandler(this.MiManejador);
            }

            else if(control == "btnBoton3")//Si apreto el 3 andara solo el 1
            {
                this.btnBoton3.Click -= new EventHandler(this.MiManejador);
                this.btnBoton1.Click += new EventHandler(this.MiManejador);
            }

            MessageBox.Show(control);
        }

        public void Inicializar(object sender, EventArgs e)
        {
            this.btnBoton1.Click += new EventHandler(MiManejador);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Manejadora manejadora = new Manejadora();
            //El delegado se encarga de invocar y pasar los datos recibidos a la direccion de memoria
            MiDelegado del = new MiDelegado(manejadora.Sumar);

            del.Invoke(3, 2);//Son los enteros que me requiere el metodo Sumar
            //del(5, 2); Se puede poner de ambas maneras

            MiDelegado del2 = new MiDelegado(manejadora.Restar);

            del2.Invoke(3, 2);
            //del2(5, 2);

            MiDelegado del3 = (MiDelegado)MiDelegado.Combine(del, del2); //Combinar lista de invocacion, se combina el primero y el segundo para que el tercero tengo dos metodos
            del3.Invoke(83, 102); //Hace el metodo sumar y restar en un solo delegado, ya que esta combinado

            //MessageBox.Show(del3.Method.ToString()); Me muestra la ultima firma que tiene ese delegado

            MessageBox.Show(del3.Target.ToString()); //Me muestra la instancia de donde esta el metodo 

            foreach(Delegate aux in del3.GetInvocationList()) //Muestra todas las firmas que tienen el delegado
            {
                MessageBox.Show(aux.Method.ToString());
            }

            MiDelegado del4 = (MiDelegado)MiDelegado.Combine(del3, new MiDelegado(manejadora.Multiplicar)); //Combina con el delegado 3 que tiene sumar y restar y tambien multiplica
            del4(3, 2);

            MiDelegado2 del5 = new MiDelegado2(manejadora.OtraSuma);

            del5.Invoke(del, 5, 2); //Invocas al delegado y este hace el metodo que tiene cargado, ejemplo del tiene suma
        }
    }
}
