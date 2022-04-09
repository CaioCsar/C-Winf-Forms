
namespace Q5
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
            this.button1 = new System.Windows.Forms.Button();
            this.mostrarVetor = new System.Windows.Forms.Label();
            this.texto = new System.Windows.Forms.Label();
            this.procurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mostrarpar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.par = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar Vetor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mostrarVetor
            // 
            this.mostrarVetor.AutoSize = true;
            this.mostrarVetor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mostrarVetor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mostrarVetor.Location = new System.Drawing.Point(12, 36);
            this.mostrarVetor.Name = "mostrarVetor";
            this.mostrarVetor.Size = new System.Drawing.Size(597, 17);
            this.mostrarVetor.TabIndex = 1;
            this.mostrarVetor.Text = "                                                                                 " +
    "                                                                                " +
    "                                   ";
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Location = new System.Drawing.Point(274, 141);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(53, 15);
            this.texto.TabIndex = 3;
            this.texto.Text = "Valor Par";
            // 
            // procurar
            // 
            this.procurar.Location = new System.Drawing.Point(240, 241);
            this.procurar.Name = "procurar";
            this.procurar.Size = new System.Drawing.Size(121, 23);
            this.procurar.TabIndex = 4;
            this.procurar.Text = "Procurar Par";
            this.procurar.UseVisualStyleBackColor = true;
            this.procurar.Click += new System.EventHandler(this.procurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vetor Gerado";
            // 
            // mostrarpar
            // 
            this.mostrarpar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mostrarpar.AutoSize = true;
            this.mostrarpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mostrarpar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mostrarpar.Location = new System.Drawing.Point(129, 156);
            this.mostrarpar.Name = "mostrarpar";
            this.mostrarpar.Size = new System.Drawing.Size(327, 17);
            this.mostrarpar.TabIndex = 6;
            this.mostrarpar.Text = "                                                                                 " +
    "                         ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantidade Par:";
            // 
            // par
            // 
            this.par.BackColor = System.Drawing.SystemColors.HighlightText;
            this.par.Enabled = false;
            this.par.Location = new System.Drawing.Point(104, 191);
            this.par.Name = "par";
            this.par.Size = new System.Drawing.Size(61, 23);
            this.par.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 337);
            this.Controls.Add(this.par);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mostrarpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.procurar);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.mostrarVetor);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Vetor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label mostrarVetor;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Button procurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mostrarpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox par;
    }
}

