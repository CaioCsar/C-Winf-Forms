using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q13
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }

            int[,] vetor = new int[5, 5];
        private void gerar_Click(object sender, EventArgs e)
        {
            mostrar.Text = "";
            Random rand = new Random();

            for(int a = 0; a <5; a++)
            {
                for(int b = 0; b < 5; b++)
                {
                    vetor[a, b] = rand.Next(10,99);
                    mostrar.Text += vetor[a,b].ToString() + " ";
                }
                    mostrar.Text += "\n";
            }
        }

            int temp = 0;


        private void transf_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 5; a++)
            {
                for (int b = a; b < 5; b++)
                {

                    temp = vetor[b, a];

                    vetor[b, a] = vetor[a, b];
                    vetor[a, b] = temp;
                }

            }

            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    telaTransf.Text += vetor[a, b].ToString() + " ";

                }
                telaTransf.Text += "\n";
            }



        }
        
    }
}
