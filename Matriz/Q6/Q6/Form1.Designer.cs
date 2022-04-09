
namespace Q6
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
            this.matriz = new System.Windows.Forms.ListBox();
            this.gerar = new System.Windows.Forms.Button();
            this.maiorn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // matriz
            // 
            this.matriz.FormattingEnabled = true;
            this.matriz.ItemHeight = 15;
            this.matriz.Location = new System.Drawing.Point(13, 13);
            this.matriz.MultiColumn = true;
            this.matriz.Name = "matriz";
            this.matriz.Size = new System.Drawing.Size(312, 94);
            this.matriz.TabIndex = 0;
            // 
            // gerar
            // 
            this.gerar.Location = new System.Drawing.Point(117, 224);
            this.gerar.Name = "gerar";
            this.gerar.Size = new System.Drawing.Size(87, 23);
            this.gerar.TabIndex = 1;
            this.gerar.Text = "Gerar Matriz";
            this.gerar.UseVisualStyleBackColor = true;
            this.gerar.Click += new System.EventHandler(this.gerar_Click);
            // 
            // maiorn
            // 
            this.maiorn.AutoSize = true;
            this.maiorn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maiorn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.maiorn.Location = new System.Drawing.Point(117, 172);
            this.maiorn.Name = "maiorn";
            this.maiorn.Size = new System.Drawing.Size(87, 17);
            this.maiorn.TabIndex = 2;
            this.maiorn.Text = "                          ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 259);
            this.Controls.Add(this.maiorn);
            this.Controls.Add(this.gerar);
            this.Controls.Add(this.matriz);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vetor 10x10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox matriz;
        private System.Windows.Forms.Button gerar;
        private System.Windows.Forms.Label maiorn;
    }
}

