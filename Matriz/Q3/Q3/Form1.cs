using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trocar2.Visible = false;
        }
        
        int[] vetor = new int[16];
        Random a = new Random();
        private void gerarVetor_Click(object sender, EventArgs e)
        {
            mostrar.Text = "";
            

            for (int i = 0; i < 8; i++)
            {
                vetor[i] = a.Next(1, 99);
                mostrar.Text += vetor[i] + " ";
            }

            mostrar.Text +=  " || ";

            for  (int j = 8; j<16; j++)
            {
                vetor[j] = a.Next(1, 99);
                mostrar.Text += vetor[j] + " ";
            }
        }

        private void trocar_Click(object sender, EventArgs e)
        {
            mostrar.Text = "";
            for (int j = 8; j < 16; j++)
            {
               
                mostrar.Text += vetor[j] + " ";
            }

            mostrar.Text += " || ";

            for (int i = 0; i < 8; i++)
            {
             
                mostrar.Text += vetor[i] + " ";
            }

            trocar.Visible = false;
            trocar2.Visible = true;
            
        }

        private void trocar2_Click(object sender, EventArgs e)
        {
            
            mostrar.Text = "";


            for (int i = 0; i < 8; i++)
            {
           
                mostrar.Text += vetor[i] + " ";
            }

            mostrar.Text += " || ";

            for (int j = 8; j < 16; j++)
            {
       
                mostrar.Text += vetor[j] + " ";
            }
            
            trocar.Visible = true;
            trocar2.Visible = false;
        }
    }
}
