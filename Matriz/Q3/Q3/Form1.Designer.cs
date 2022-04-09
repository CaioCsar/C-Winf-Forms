
namespace Q3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mostrar = new System.Windows.Forms.Label();
            this.gerarVetor = new System.Windows.Forms.Button();
            this.trocar = new System.Windows.Forms.Button();
            this.trocar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mostrar
            // 
            this.mostrar.AutoSize = true;
            this.mostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mostrar.Location = new System.Drawing.Point(72, 48);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(271, 17);
            this.mostrar.TabIndex = 0;
            this.mostrar.Text = "                                      VETOR                                      " +
    "";
            // 
            // gerarVetor
            // 
            this.gerarVetor.Location = new System.Drawing.Point(168, 155);
            this.gerarVetor.Name = "gerarVetor";
            this.gerarVetor.Size = new System.Drawing.Size(75, 23);
            this.gerarVetor.TabIndex = 1;
            this.gerarVetor.Text = "Gerar Vetor";
            this.gerarVetor.UseVisualStyleBackColor = true;
            this.gerarVetor.Click += new System.EventHandler(this.gerarVetor_Click);
            // 
            // trocar
            // 
            this.trocar.Location = new System.Drawing.Point(151, 192);
            this.trocar.Name = "trocar";
            this.trocar.Size = new System.Drawing.Size(109, 23);
            this.trocar.TabIndex = 2;
            this.trocar.Text = "Trocar Posição";
            this.trocar.UseVisualStyleBackColor = true;
            this.trocar.Click += new System.EventHandler(this.trocar_Click);
            // 
            // trocar2
            // 
            this.trocar2.Location = new System.Drawing.Point(151, 192);
            this.trocar2.Name = "trocar2";
            this.trocar2.Size = new System.Drawing.Size(109, 23);
            this.trocar2.TabIndex = 3;
            this.trocar2.Text = "Trocar Posição";
            this.trocar2.UseVisualStyleBackColor = true;
            this.trocar2.Click += new System.EventHandler(this.trocar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 227);
            this.Controls.Add(this.trocar2);
            this.Controls.Add(this.trocar);
            this.Controls.Add(this.gerarVetor);
            this.Controls.Add(this.mostrar);
            this.Name = "Form1";
            this.Text = "Vetor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mostrar;
        private System.Windows.Forms.Button gerarVetor;
        private System.Windows.Forms.Button trocar;
        private System.Windows.Forms.Button trocar2;
    }
}

