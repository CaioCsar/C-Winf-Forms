
namespace Q8
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
            this.m1 = new System.Windows.Forms.Label();
            this.m3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gerar
            // 
            this.gerar.Location = new System.Drawing.Point(140, 348);
            this.gerar.Name = "gerar";
            this.gerar.Size = new System.Drawing.Size(101, 23);
            this.gerar.TabIndex = 0;
            this.gerar.Text = "Gerar Matriz";
            this.gerar.UseVisualStyleBackColor = true;
            this.gerar.Click += new System.EventHandler(this.gerar_Click);
            // 
            // m1
            // 
            this.m1.AutoSize = true;
            this.m1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m1.Location = new System.Drawing.Point(12, 24);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(54, 17);
            this.m1.TabIndex = 1;
            this.m1.Text = "               ";
            // 
            // m3
            // 
            this.m3.AutoSize = true;
            this.m3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m3.Location = new System.Drawing.Point(293, 24);
            this.m3.Name = "m3";
            this.m3.Size = new System.Drawing.Size(54, 17);
            this.m3.TabIndex = 3;
            this.m3.Text = "               ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matriz 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matriz 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Matriz Resultante";
            // 
            // m2
            // 
            this.m2.AutoSize = true;
            this.m2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m2.Location = new System.Drawing.Point(150, 24);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(54, 17);
            this.m2.TabIndex = 7;
            this.m2.Text = "               ";
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 392);
            this.Controls.Add(this.m2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m3);
            this.Controls.Add(this.m1);
            this.Controls.Add(this.gerar);
            this.Name = "app";
            this.Text = "Gerador de Matriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gerar;
        private System.Windows.Forms.Label m1;
        private System.Windows.Forms.Label m3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label m2;
    }
}

