using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gerarVetor_Click(object sender, EventArgs e)
        {
            mostrar.Text = "";
            int [] vetor = new int[10];
            Random a = new Random();

            for (int i = 0; i< 10; i++)
            {
                
                int valor = vetor[i] = a.Next(1, 99);
                if ( valor % 2 != 0)
                {   
                    mostrar.Text += vetor[i].ToString() + " ";
                }
            }
        }
    }
}
