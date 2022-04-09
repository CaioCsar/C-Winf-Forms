using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] vetor = new int[8, 8];
        private void gerar_Click(object sender, EventArgs e)
        {
            tela.Text = "";
            valor.Text = "";
            Random aleatorio = new Random();

            for (int a = 0; a < 8; a++)
            {
                for (int b = 0; b < 8; b++)
                {
                    vetor[a, b] = aleatorio.Next(10, 99);
                    tela.Text += vetor[a, b].ToString() + " ";
                }
                tela.Text += "\n";
            }
        }

        private void transf_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 8; a++)
            {
                for (int b = 0; b < 8; b++)
                {
                    if (a < b || a == b)
                    {
                        vetor[a, b] = 0;
                    }


                    valor.Text += vetor[a, b].ToString() + " ";
                }
                valor.Text += "\n";
            }
        }
    }
}
