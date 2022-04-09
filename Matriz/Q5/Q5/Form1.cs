using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cont = 0;
            int[] vetor = new int[40];

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarVetor.Text = "";
            mostrarpar.Text = "                                                                                                          ";
            cont = 0;
            Random a = new Random();

            for(int i = 0; i<40; i++)
            {
                vetor[i] = a.Next(1, 99);
                mostrarVetor.Text += vetor[i].ToString() + " ";
                
            }
        }

        private void procurar_Click(object sender, EventArgs e)
        {
            mostrarpar.Text = "";
            cont = 0;
            for (int i = 0; i < 40; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    mostrarpar.Text += vetor[i].ToString() + " ";
                    cont++;
                    par.Text = cont.ToString();
                }
            }
        }
    }
}
