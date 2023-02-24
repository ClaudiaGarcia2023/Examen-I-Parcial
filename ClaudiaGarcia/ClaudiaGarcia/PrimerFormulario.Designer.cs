namespace ClaudiaGarcia
{
    partial class PrimerFormulario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtTasaIntereses = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstmes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tasa de interes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mes";
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(239, 53);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(191, 26);
            this.txtCapital.TabIndex = 3;
            // 
            // txtTasaIntereses
            // 
            this.txtTasaIntereses.Location = new System.Drawing.Point(239, 88);
            this.txtTasaIntereses.Name = "txtTasaIntereses";
            this.txtTasaIntereses.Size = new System.Drawing.Size(191, 26);
            this.txtTasaIntereses.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculo_Interes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstmes
            // 
            this.lstmes.FormattingEnabled = true;
            this.lstmes.ItemHeight = 20;
            this.lstmes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.lstmes.Location = new System.Drawing.Point(239, 133);
            this.lstmes.Name = "lstmes";
            this.lstmes.Size = new System.Drawing.Size(191, 244);
            this.lstmes.TabIndex = 7;
            this.lstmes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PrimerFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstmes);
            this.Controls.Add(this.txtTasaIntereses);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrimerFormulario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PrimerFormulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtTasaIntereses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstmes;
    }
}

