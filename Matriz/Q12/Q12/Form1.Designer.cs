
namespace Q12
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
            this.transf = new System.Windows.Forms.Button();
            this.tela = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gerar
            // 
            this.gerar.Location = new System.Drawing.Point(58, 255);
            this.gerar.Name = "gerar";
            this.gerar.Size = new System.Drawing.Size(93, 23);
            this.gerar.TabIndex = 0;
            this.gerar.Text = "Gerar Matriz";
            this.gerar.UseVisualStyleBackColor = true;
            this.gerar.Click += new System.EventHandler(this.gerar_Click);
            // 
            // transf
            // 
            this.transf.Location = new System.Drawing.Point(272, 255);
            this.transf.Name = "transf";
            this.transf.Size = new System.Drawing.Size(93, 23);
            this.transf.TabIndex = 1;
            this.transf.Text = "Transformar";
            this.transf.UseVisualStyleBackColor = true;
            this.transf.Click += new System.EventHandler(this.transf_Click);
            // 
            // tela
            // 
            this.tela.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tela.Location = new System.Drawing.Point(13, 13);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(212, 196);
            this.tela.TabIndex = 2;
            this.tela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valor
            // 
            this.valor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.valor.Location = new System.Drawing.Point(231, 13);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(212, 196);
            this.valor.TabIndex = 3;
            this.valor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 300);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.transf);
            this.Controls.Add(this.gerar);
            this.Name = "Form1";
            this.Text = "Matriz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gerar;
        private System.Windows.Forms.Button transf;
        private System.Windows.Forms.Label tela;
        private System.Windows.Forms.Label valor;
    }
}

