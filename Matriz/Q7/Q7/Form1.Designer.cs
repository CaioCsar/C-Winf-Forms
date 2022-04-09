
namespace Q7
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
            this.matriz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gerar
            // 
            this.gerar.Location = new System.Drawing.Point(47, 180);
            this.gerar.Name = "gerar";
            this.gerar.Size = new System.Drawing.Size(85, 23);
            this.gerar.TabIndex = 1;
            this.gerar.Text = "Gerar matriz";
            this.gerar.UseVisualStyleBackColor = true;
            this.gerar.Click += new System.EventHandler(this.gerar_Click);
            // 
            // matriz
            // 
            this.matriz.AutoSize = true;
            this.matriz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.matriz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matriz.Location = new System.Drawing.Point(50, 48);
            this.matriz.Name = "matriz";
            this.matriz.Size = new System.Drawing.Size(82, 17);
            this.matriz.TabIndex = 2;
            this.matriz.Text = "Matriz Gerada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 243);
            this.Controls.Add(this.matriz);
            this.Controls.Add(this.gerar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matriz 0 e 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button gerar;
        private System.Windows.Forms.Label matriz;
    }
}

