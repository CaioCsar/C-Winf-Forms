using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gerar_Click(object sender, EventArgs e)
        {
            matriz.Items.Clear();
            maiorn.Text = "";
            int maior = 0;
            int posicaox = 0;
            int posicaoy = 0;
            int posicaoxm = 0;
            int posicaoym = 0;
            int[,] ma = new int [10,10];
            Random a = new Random();

            for (int i=0; i<10; i++)
            {
                for (int j = 0; j < 10; j++) {
                    ma[i, j] = a.Next(1, 99);
                    posicaox = i;
                    posicaoy = j;
                    if (maior < ma[i, j])
                    {
                        maior = ma[i, j];
                        posicaoxm = i;
                        posicaoym = j;
                    }
                    matriz.Items.Add("[" + posicaox + "," + posicaoy + "]"+  
                        ": " + ma[i, j].ToString() + " ");
                }
            }
            maiorn.Text = "O maior número gerado foi: " + maior + "\n" +
                          "Está na posição: " + "[" + posicaoxm + "," + posicaoym + "]";

        }
    }
}
