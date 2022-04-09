using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            int[,] m1 = new int[10, 10];
            int[,] m2 = new int[10, 10];
        private void gerar_Click(object sender, EventArgs e)
        {
            tela.Text = "";
            tela2.Text = "";

            Random a = new Random();


            for(int l=0; l<10; l++)
            {
                for(int c=0; c<10; c++)
                {
                    m1[l, c] = a.Next(10,99);
                    tela.Text += m1[l, c].ToString() + " ";
                }
                tela.Text += "\n";
            }

            for (int b = 0; b < 10; b++)
            {
                for (int d = 0; d < 10; d++)
                {
                    m2[b, d] = a.Next(10,99);
                    tela2.Text += m2[b, d].ToString() + " ";
                }
                tela2.Text += "\n";
            }

        }

        private void trocar_Click(object sender, EventArgs e)
        {
            result.Text = " ";

            for (int l = 0; l < 10; l++)
            {
                for (int c = l; c < 10; c++)
                {
                    if(l != c)
                    {
                    int temp = m1[l,c];
                    m1[l, c] = m2[l, c];
                    m2[l, c] = temp;
                    }
                    
                    
                }
            }

            for (int l = 0; l < 10; l++)
            {
                for (int c = 0; c < 10; c++)
                {

                    result.Text += m1[l, c].ToString() + " ";
                }
                result.Text += "\n";
            }
        }
    }
}
