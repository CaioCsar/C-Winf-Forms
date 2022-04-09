
namespace Q9
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
            this.gerar = new System.Windows.Forms.Button();
            this.tela = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gerar
            // 
            this.gerar.Location = new System.Drawing.Point(102, 145);
            this.gerar.Name = "gerar";
            this.gerar.Size = new System.Drawing.Size(75, 23);
            this.gerar.TabIndex = 0;
            this.gerar.Text = "Gerar Array";
            this.gerar.UseVisualStyleBackColor = true;
            this.gerar.Click += new System.EventHandler(this.gerar_Click);
            // 
            // tela
            // 
            this.tela.AutoSize = true;
            this.tela.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tela.Location = new System.Drawing.Point(86, 28);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(108, 17);
            this.tela.TabIndex = 1;
            this.tela.Text = "                                 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vetor Gerado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.gerar);
            this.Name = "Form1";
            this.Text = "Gerar Matriz > 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gerar;
        private System.Windows.Forms.Label tela;
        private System.Windows.Forms.Label label1;
    }
}

