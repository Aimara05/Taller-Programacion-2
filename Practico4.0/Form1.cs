using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BGenerarFuncion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TDesde.Text) || string.IsNullOrWhiteSpace(THasta.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                listBox1.Items.Clear();
                chart1.Series.Clear();

                Series series =  new Series("Numeros Generados");
                series.ChartType = SeriesChartType.Column;

                for (int i = Int32.Parse(TDesde.Text); i <= Int32.Parse(THasta.Text); i++)
                {
                    listBox1.Items.Add(i);
                    series.Points.AddXY(i.ToString(),i);
                    
                }

                chart1.Series.Add(series);
                
            }
        }

        private void TDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void THasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BNumPares_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = Int32.Parse(TDesde.Text); i <= Int32.Parse(THasta.Text); i++)
            {
                if(i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void BNumImp_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = Int32.Parse(TDesde.Text); i <= Int32.Parse(THasta.Text); i++)
            {
                if (i % 2 != 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void BNumPrimos_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


            for (int i = Int32.Parse(TDesde.Text); i <= Int32.Parse(THasta.Text); i++)
            {
                int contador = 0;
                for(int k = 1; k <=i; k++)
                {
                    if(i % k == 0)
                    {
                        contador = contador + 1;
                    }                
                }
                if (contador == 2) 
                {
                    listBox1.Items.Add(i);
                }
            }

        }
    }
}
