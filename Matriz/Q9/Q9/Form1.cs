using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void gerar_Click(object sender, EventArgs e)
        {
            tela.Text = "";
            int[,] matriz = new int[6, 6];
            Random a = new Random();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matriz[i, j] += a.Next(1, 99);

                    if (matriz[i, j] > 10)
                    {
                        tela.Text += matriz[i, j].ToString() + " ";
                    }
                }
                tela.Text += "\n";

            }
        }
    }
}
