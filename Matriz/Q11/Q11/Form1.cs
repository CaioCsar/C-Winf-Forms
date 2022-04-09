using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            int[,] matriz = new int [4,4];
        private void gerar_Click(object sender, EventArgs e)
        {
            tela.Text = "";
            Random aleatorio = new Random();

            for(int a = 0; a < 4; a++){
                for(int b =0; b<4; b++)
                {
                    matriz[a, b] = aleatorio.Next(1, 99);
                    tela.Text += matriz[a, b] + " ";
                }
                tela.Text += "\n";
            }
        }

        private void trocar_Click(object sender, EventArgs e)
        {
   
            int temp = 0;
            telaTroca.Text = "";
            
                for (int b = 0; b < 4; b++)
                {   
                    temp = matriz[0, b];
                    matriz[0,b] = matriz[b,3];
                    matriz[b,3] = temp;
                }

            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    telaTroca.Text += matriz[a, b] + " ";
                }
                telaTroca.Text += "\n";
            }

        }
    }
}
