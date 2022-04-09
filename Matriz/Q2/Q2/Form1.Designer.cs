
namespace Q2
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
            this.SuspendLayout();
            // 
            // mostrar
            // 
            this.mostrar.AutoSize = true;
            this.mostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mostrar.Location = new System.Drawing.Point(130, 45);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(151, 17);
            this.mostrar.TabIndex = 0;
            this.mostrar.Text = "VETOR DE NÚMERO ÍMPAR";
            // 
            // gerarVetor
            // 
            this.gerarVetor.Location = new System.Drawing.Point(173, 181);
            this.gerarVetor.Name = "gerarVetor";
            this.gerarVetor.Size = new System.Drawing.Size(75, 23);
            this.gerarVetor.TabIndex = 1;
            this.gerarVetor.Text = "Gerar Vetor";
            this.gerarVetor.UseVisualStyleBackColor = true;
            this.gerarVetor.Click += new System.EventHandler(this.gerarVetor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 227);
            this.Controls.Add(this.gerarVetor);
            this.Controls.Add(this.mostrar);
            this.Name = "Form1";
            this.Text = "Vetor ímpar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mostrar;
        private System.Windows.Forms.Button gerarVetor;
    }
}

