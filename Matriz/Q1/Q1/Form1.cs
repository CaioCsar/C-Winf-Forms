using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            caixaVetor.Text = "";
            telaVetor.Text = "";
            
            int[] vetor = new int [12];
            Random aleatorio = new Random();

            for(int i = 0; i<12; i++)
            {
               vetor[i] = aleatorio.Next(1,99);
               caixaVetor.Text += (vetor[i] + " ");
               
            }

            int i1 = vetor[aleatorio.Next(1, 12)];
            int i2 = vetor[aleatorio.Next(1, 12)];
            int soma =  i1 + i2;
            telaVetor.Text = i1 + " + " + i2 + " = " + soma.ToString();

        }
    }
}
