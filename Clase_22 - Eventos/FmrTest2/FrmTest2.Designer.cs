namespace FmrTest2
{
    partial class FrmTest2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBoton1 = new System.Windows.Forms.Button();
            this.btnBoton2 = new System.Windows.Forms.Button();
            this.btnBoton3 = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoton1
            // 
            this.btnBoton1.Location = new System.Drawing.Point(12, 12);
            this.btnBoton1.Name = "btnBoton1";
            this.btnBoton1.Size = new System.Drawing.Size(176, 37);
            this.btnBoton1.TabIndex = 0;
            this.btnBoton1.Text = "Boton 1";
            this.btnBoton1.UseVisualStyleBackColor = true;
            // 
            // btnBoton2
            // 
            this.btnBoton2.Location = new System.Drawing.Point(12, 55);
            this.btnBoton2.Name = "btnBoton2";
            this.btnBoton2.Size = new System.Drawing.Size(176, 37);
            this.btnBoton2.TabIndex = 1;
            this.btnBoton2.Text = "Boton 2";
            this.btnBoton2.UseVisualStyleBackColor = true;
            // 
            // btnBoton3
            // 
            this.btnBoton3.Location = new System.Drawing.Point(12, 98);
            this.btnBoton3.Name = "btnBoton3";
            this.btnBoton3.Size = new System.Drawing.Size(176, 37);
            this.btnBoton3.TabIndex = 2;
            this.btnBoton3.Text = "Boton 3";
            this.btnBoton3.UseVisualStyleBackColor = true;
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 141);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(176, 37);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "&Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // FrmTest2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 186);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnBoton3);
            this.Controls.Add(this.btnBoton2);
            this.Controls.Add(this.btnBoton1);
            this.Name = "FrmTest2";
            this.Text = "FrmTest2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoton1;
        private System.Windows.Forms.Button btnBoton2;
        private System.Windows.Forms.Button btnBoton3;
        private System.Windows.Forms.Button btnOperar;
    }
}

