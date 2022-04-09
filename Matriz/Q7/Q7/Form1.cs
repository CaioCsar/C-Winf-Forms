using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gerar_Click(object sender, EventArgs e)
        {

            matriz.Text = "";
            int maior = 0;
            int posicaox = 0;
            int posicaoy = 0;

            int[,] ma = new int[5, 5];
            Random a = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    ma[i, j] = a.Next(1, 20);
                    posicaox = i;
                    posicaoy = j;
                    if (posicaox == posicaoy)
                    {
                        ma[i, j] = 1;
                    }
                    else
                    {
                        ma[i, j] = 0;
                    }
                    matriz.Text += ma[i, j].ToString() + " ";
                }
                matriz.Text += "\n";
            }
        }
    }
}
