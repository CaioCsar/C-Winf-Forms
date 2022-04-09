
namespace Q10
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
            this.gerar = new System.Windows.Forms.Button();
            this.procurar = new System.Windows.Forms.Button();
            this.tela = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gerar
            // 
            this.gerar.Location = new System.Drawing.Point(125, 437);
            this.gerar.Name = "gerar";
            this.gerar.Size = new System.Drawing.Size(97, 23);
            this.gerar.TabIndex = 1;
            this.gerar.Text = "Gerar Matriz";
            this.gerar.UseVisualStyleBackColor = true;
            this.gerar.Click += new System.EventHandler(this.gerar_Click);
            // 
            // procurar
            // 
            this.procurar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.procurar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.procurar.Location = new System.Drawing.Point(125, 408);
            this.procurar.Name = "procurar";
            this.procurar.Size = new System.Drawing.Size(97, 23);
            this.procurar.TabIndex = 2;
            this.procurar.Text = "Procurar Valor";
            this.procurar.UseVisualStyleBackColor = false;
            this.procurar.Click += new System.EventHandler(this.procurar_Click);
            // 
            // tela
            // 
            this.tela.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tela.Location = new System.Drawing.Point(12, 9);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(334, 319);
            this.tela.TabIndex = 4;
            this.tela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(12, 347);
            this.valor.Multiline = true;
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(334, 41);
            this.valor.TabIndex = 5;
            this.valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 477);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.procurar);
            this.Controls.Add(this.gerar);
            this.Name = "app";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matriz 20x20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gerar;
        private System.Windows.Forms.Button procurar;
        private System.Windows.Forms.Label tela;
        private System.Windows.Forms.TextBox valor;
    }
}

