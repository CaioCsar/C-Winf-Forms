
namespace Q4
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
            this.button1 = new System.Windows.Forms.Button();
            this.mostrarVetor = new System.Windows.Forms.Label();
            this.txtprocura = new System.Windows.Forms.TextBox();
            this.texto = new System.Windows.Forms.Label();
            this.procurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 271);
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
            this.mostrarVetor.Location = new System.Drawing.Point(12, 40);
            this.mostrarVetor.Name = "mostrarVetor";
            this.mostrarVetor.Size = new System.Drawing.Size(327, 17);
            this.mostrarVetor.TabIndex = 1;
            this.mostrarVetor.Text = "                                                                                 " +
    "                         ";
            // 
            // txtprocura
            // 
            this.txtprocura.Location = new System.Drawing.Point(116, 179);
            this.txtprocura.Name = "txtprocura";
            this.txtprocura.Size = new System.Drawing.Size(100, 23);
            this.txtprocura.TabIndex = 2;
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Location = new System.Drawing.Point(119, 152);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(85, 15);
            this.texto.TabIndex = 3;
            this.texto.Text = "Insira um valor";
            // 
            // procurar
            // 
            this.procurar.Location = new System.Drawing.Point(110, 208);
            this.procurar.Name = "procurar";
            this.procurar.Size = new System.Drawing.Size(121, 23);
            this.procurar.TabIndex = 4;
            this.procurar.Text = "Procurar no Vetor";
            this.procurar.UseVisualStyleBackColor = true;
            this.procurar.Click += new System.EventHandler(this.procurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vetor Gerado";
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.procurar);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.txtprocura);
            this.Controls.Add(this.mostrarVetor);
            this.Controls.Add(this.button1);
            this.Name = "app";
            this.Text = "Vetor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label mostrarVetor;
        private System.Windows.Forms.TextBox txtprocura;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Button procurar;
        private System.Windows.Forms.Label label1;
    }
}

