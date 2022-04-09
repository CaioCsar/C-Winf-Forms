
namespace Q1
{
    partial class app
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
            this.telaVetor = new System.Windows.Forms.Label();
            this.iniciar = new System.Windows.Forms.Button();
            this.caixaVetor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // telaVetor
            // 
            this.telaVetor.AutoSize = true;
            this.telaVetor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.telaVetor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.telaVetor.Location = new System.Drawing.Point(182, 268);
            this.telaVetor.Name = "telaVetor";
            this.telaVetor.Size = new System.Drawing.Size(75, 17);
            this.telaVetor.TabIndex = 0;
            this.telaVetor.Text = "                      ";
            // 
            // iniciar
            // 
            this.iniciar.Location = new System.Drawing.Point(182, 363);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(75, 23);
            this.iniciar.TabIndex = 2;
            this.iniciar.Text = "Gerar Vetor";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // caixaVetor
            // 
            this.caixaVetor.AutoSize = true;
            this.caixaVetor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.caixaVetor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.caixaVetor.Location = new System.Drawing.Point(150, 47);
            this.caixaVetor.Name = "caixaVetor";
            this.caixaVetor.Size = new System.Drawing.Size(135, 17);
            this.caixaVetor.TabIndex = 3;
            this.caixaVetor.Text = "                                          ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "SOMA:";
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caixaVetor);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.telaVetor);
            this.Name = "app";
            this.Text = "Gerador de Vetor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label telaVetor;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Label caixaVetor;
        private System.Windows.Forms.Label label1;
    }
}

