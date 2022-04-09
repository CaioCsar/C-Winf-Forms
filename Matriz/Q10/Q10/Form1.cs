using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q10
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }

            int[,] vetor = new int [20,20];
        private void gerar_Click(object sender, EventArgs e)
        {
            tela.Text = "";
            valor.Text = "";
            Random aleatorio = new Random();

            for(int a = 0; a<20; a++)
            {
                for(int b=0; b<20; b++)
                {
                    vetor[a, b] = aleatorio.Next(1, 99);
                    tela.Text += vetor[a, b].ToString() + " ";
                }
                tela.Text += "\n";
            }
        }

        int posicaox = 0;
        int posicaoy = 0;
       

        private void procurar_Click(object sender, EventArgs e)
        {
            bool logic = false;

            for (int a = 0; a < 20; a++)
            {
                for (int b = 0; b < 20; b++)
                {

                   
                    if(valor.Text == vetor[a,b].ToString())
                    {
                        posicaox = a;
                        posicaoy = b;
                        valor.Text = "Valor encontrado: " + vetor[a,b].ToString() + "\n Na posiçao: ["+ a + "," + b + "]";
                        logic = true;
                        
                    }
                }

            }
                    if(!logic)
                    {
                        valor.Text = "Valor nao encontrado";
                    }
        }
    }
}
