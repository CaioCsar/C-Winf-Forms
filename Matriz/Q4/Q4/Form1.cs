using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }

            int[] vetor = new int[20];
            Random a = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarVetor.Text = " ";
            txtprocura.Text = "";

            for (int i = 0; i < 20; i++)
            {
                vetor[i] = a.Next(1, 99);
                mostrarVetor.Text += vetor[i].ToString() + " ";

            }
        }

        bool logic = false;
        private void procurar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                int num = int.Parse(txtprocura.Text);
                if(num.ToString() == vetor[i].ToString())
                {
                    MessageBox.Show("O número está contido no vetor !");
                    logic = true;
                }

            }
                if(!logic)
                {
                    MessageBox.Show("O número não está contido no vetor !");
                }
        }
    }
}
