using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q8
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }

        private void gerar_Click(object sender, EventArgs e)
        {

            int maior = 0;
            m1.Text = "";
            m2.Text = "";
            m3.Text = "";

            int[,] ma = new int[4, 4];
            int[,] mb = new int[4, 4];
            int[,] mr = new int[4, 4];
            Random a = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    ma[i, j] = a.Next(1, 98);
                    m1.Text += ma[i, j].ToString() + "\n";

                } }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mb[i, j] = a.Next(1, 98);
                    m2.Text += mb[i, j].ToString() + "\n";

                }
            }


            // matriz resultante
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if(ma[i,j] > mb[i, j])
                    {
                        mr[i,j] = ma[i, j];
                    }
                    else
                    {
                        mr[i, j] = mb[i, j];
                    }

            m3.Text += mr[i, j].ToString() + "\n";
                }


            }
        } 
    }
              }
            
            
            
        
    

