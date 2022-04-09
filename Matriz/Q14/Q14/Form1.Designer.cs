
namespace Q14
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
            this.tela2 = new System.Windows.Forms.Label();
            this.trocar = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gerar
            // 
            this.gerar.Location = new System.Drawing.Point(156, 188);
            this.gerar.Name = "gerar";
            this.gerar.Size = new System.Drawing.Size(75, 23);
            this.gerar.TabIndex = 0;
            this.gerar.Text = "Gerar";
            this.gerar.UseVisualStyleBackColor = true;
            this.gerar.Click += new System.EventHandler(this.gerar_Click);
            // 
            // tela
            // 
            this.tela.BackColor = System.Drawing.Color.LightGray;
            this.tela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tela.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tela.Location = new System.Drawing.Point(13, 13);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(180, 172);
            this.tela.TabIndex = 1;
            this.tela.Text = " ";
            this.tela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tela2
            // 
            this.tela2.BackColor = System.Drawing.Color.LightGray;
            this.tela2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tela2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tela2.Location = new System.Drawing.Point(199, 13);
            this.tela2.Name = "tela2";
            this.tela2.Size = new System.Drawing.Size(180, 172);
            this.tela2.TabIndex = 2;
            this.tela2.Text = " ";
            this.tela2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trocar
            // 
            this.trocar.Location = new System.Drawing.Point(156, 407);
            this.trocar.Name = "trocar";
            this.trocar.Size = new System.Drawing.Size(75, 23);
            this.trocar.TabIndex = 3;
            this.trocar.Text = "Trocar";
            this.trocar.UseVisualStyleBackColor = true;
            this.trocar.Click += new System.EventHandler(this.trocar_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.LightGray;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.result.Location = new System.Drawing.Point(109, 232);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(180, 172);
            this.result.TabIndex = 4;
            this.result.Text = " ";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.trocar);
            this.Controls.Add(this.tela2);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.gerar);
            this.Name = "Form1";
            this.Text = "Gerar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gerar;
        private System.Windows.Forms.Label tela;
        private System.Windows.Forms.Label tela2;
        private System.Windows.Forms.Button trocar;
        private System.Windows.Forms.Label result;
    }
}

