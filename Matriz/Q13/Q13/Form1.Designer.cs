
namespace Q13
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
            this.mostrar = new System.Windows.Forms.Label();
            this.gerar = new System.Windows.Forms.Button();
            this.telaTransf = new System.Windows.Forms.Label();
            this.transf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mostrar
            // 
            this.mostrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mostrar.Location = new System.Drawing.Point(12, 9);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(135, 106);
            this.mostrar.TabIndex = 0;
            this.mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gerar
            // 
            this.gerar.Location = new System.Drawing.Point(35, 136);
            this.gerar.Name = "gerar";
            this.gerar.Size = new System.Drawing.Size(84, 23);
            this.gerar.TabIndex = 1;
            this.gerar.Text = "Gerar Matriz";
            this.gerar.UseVisualStyleBackColor = true;
            this.gerar.Click += new System.EventHandler(this.gerar_Click);
            // 
            // telaTransf
            // 
            this.telaTransf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.telaTransf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.telaTransf.Location = new System.Drawing.Point(153, 9);
            this.telaTransf.Name = "telaTransf";
            this.telaTransf.Size = new System.Drawing.Size(135, 106);
            this.telaTransf.TabIndex = 2;
            this.telaTransf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transf
            // 
            this.transf.Location = new System.Drawing.Point(180, 136);
            this.transf.Name = "transf";
            this.transf.Size = new System.Drawing.Size(84, 23);
            this.transf.TabIndex = 3;
            this.transf.Text = "Transformar";
            this.transf.UseVisualStyleBackColor = true;
            this.transf.Click += new System.EventHandler(this.transf_Click);
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 187);
            this.Controls.Add(this.transf);
            this.Controls.Add(this.telaTransf);
            this.Controls.Add(this.gerar);
            this.Controls.Add(this.mostrar);
            this.Name = "app";
            this.Text = "Matriz 5x5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mostrar;
        private System.Windows.Forms.Button gerar;
        private System.Windows.Forms.Label telaTransf;
        private System.Windows.Forms.Button transf;
    }
}

