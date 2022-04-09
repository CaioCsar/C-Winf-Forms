
namespace Q15
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
            this.tela = new System.Windows.Forms.Label();
            this.gerar = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tela
            // 
            this.tela.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tela.Location = new System.Drawing.Point(13, 13);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(435, 163);
            this.tela.TabIndex = 0;
            this.tela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gerar
            // 
            this.gerar.Location = new System.Drawing.Point(187, 293);
            this.gerar.Name = "gerar";
            this.gerar.Size = new System.Drawing.Size(75, 29);
            this.gerar.TabIndex = 1;
            this.gerar.Text = "Gerar";
            this.gerar.UseVisualStyleBackColor = true;
            this.gerar.Click += new System.EventHandler(this.gerar_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.Location = new System.Drawing.Point(153, 192);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(150, 71);
            this.result.TabIndex = 2;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 330);
            this.Controls.Add(this.result);
            this.Controls.Add(this.gerar);
            this.Controls.Add(this.tela);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tela;
        private System.Windows.Forms.Button gerar;
        private System.Windows.Forms.Label result;
    }
}

