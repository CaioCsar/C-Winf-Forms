
namespace Q11
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
            this.trocar = new System.Windows.Forms.Button();
            this.tela = new System.Windows.Forms.Label();
            this.telaTroca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gerar
            // 
            this.gerar.Location = new System.Drawing.Point(125, 279);
            this.gerar.Name = "gerar";
            this.gerar.Size = new System.Drawing.Size(97, 23);
            this.gerar.TabIndex = 1;
            this.gerar.Text = "Gerar Matriz";
            this.gerar.UseVisualStyleBackColor = true;
            this.gerar.Click += new System.EventHandler(this.gerar_Click);
            // 
            // trocar
            // 
            this.trocar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trocar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trocar.Location = new System.Drawing.Point(125, 241);
            this.trocar.Name = "trocar";
            this.trocar.Size = new System.Drawing.Size(97, 23);
            this.trocar.TabIndex = 2;
            this.trocar.Text = "Trocar Valor";
            this.trocar.UseVisualStyleBackColor = false;
            this.trocar.Click += new System.EventHandler(this.trocar_Click);
            // 
            // tela
            // 
            this.tela.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tela.Location = new System.Drawing.Point(12, 9);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(163, 160);
            this.tela.TabIndex = 4;
            this.tela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telaTroca
            // 
            this.telaTroca.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.telaTroca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.telaTroca.Location = new System.Drawing.Point(186, 9);
            this.telaTroca.Name = "telaTroca";
            this.telaTroca.Size = new System.Drawing.Size(163, 160);
            this.telaTroca.TabIndex = 5;
            this.telaTroca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 325);
            this.Controls.Add(this.telaTroca);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.trocar);
            this.Controls.Add(this.gerar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matriz 4x4 trocada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gerar;
        private System.Windows.Forms.Button trocar;
        private System.Windows.Forms.Label tela;
        private System.Windows.Forms.Label telaTroca;
    }
}

