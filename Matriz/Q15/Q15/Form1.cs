using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gerar_Click(object sender, EventArgs e)
        {
            tela.Text = " ";
            Random a = new Random();
            int[,] m1 = new int[8, 8];

            for (int l = 0; l < 8; l++)
            {
                for (int c = 0; c < 8; c++)
                {
                    m1[l, c] = a.Next(10, 99);
                    tela.Text += m1[l, c].ToString() + " ";
                }
                tela.Text += "\n";
            }
            //result
            int maior = 0;
            int soma = 0;
            for (int l = 0; l < 8; l++)
            {
                for (int c = 0; c < 8; c++)
                {
                    if (l == c)
                    {
                        
                        if(m1[l,c] > maior)
                        {
                            maior = m1[l,c];
                        }
                    }

                    if (c == 8 -1 - l)
                    {

                        soma = soma + m1[l, c];

                    }



                }
              
            }
           
                    result.Text = "O maior elemento da diagonal principal é: " + maior.ToString() +
                        "\n" + "A soma dos elementos da diagonal secundária é: " + soma;
        }
    }
}
