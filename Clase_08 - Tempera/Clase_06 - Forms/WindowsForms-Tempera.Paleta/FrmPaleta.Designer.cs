namespace WindowsForms
{ 
    partial class FrmPaleta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listLista = new System.Windows.Forms.ListBox();
            this.BtnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listLista
            // 
            this.listLista.FormattingEnabled = true;
            this.listLista.Location = new System.Drawing.Point(12, 12);
            this.listLista.Name = "listLista";
            this.listLista.Size = new System.Drawing.Size(264, 160);
            this.listLista.TabIndex = 0;
            this.listLista.SelectedIndexChanged += new System.EventHandler(this.listLista_SelectedIndexChanged);
            // 
            // BtnMas
            // 
            this.BtnMas.Location = new System.Drawing.Point(36, 188);
            this.BtnMas.Name = "BtnMas";
            this.BtnMas.Size = new System.Drawing.Size(75, 23);
            this.BtnMas.TabIndex = 1;
            this.BtnMas.Text = "+";
            this.BtnMas.UseVisualStyleBackColor = true;
            this.BtnMas.Click += new System.EventHandler(this.BtnMas_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(160, 188);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(75, 23);
            this.btnMenos.TabIndex = 2;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPaleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 223);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.BtnMas);
            this.Controls.Add(this.listLista);
            this.Name = "FrmPaleta";
            this.Text = "FrmPaleta";
            this.Load += new System.EventHandler(this.FrmPaleta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listLista;
        private System.Windows.Forms.Button BtnMas;
        private System.Windows.Forms.Button btnMenos;
    }
}