using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Subtotal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text != "" )
            {
                double credito, efectivo, alma, impu, tot, alma2;

                credito = double.Parse(maskedTextBox1.Text);

                if (credito < 0 || credito > 1000)
                {
                    MessageBox.Show("No puede ser negativo ni cero ni mayor a 1000", "Advertencia");
                    maskedTextBox1.Text = "";
                }
                else
                {
                    if (Efectivo.Checked == true)
                    {
                        alma = credito * 0.05;
                        alma2 = credito - alma;
                        impu = alma2 * 1.15;
                        maskedTextBox2.Text = impu.ToString();
                        maskedTextBox3.Text = alma.ToString();
                    }
                    else
                    {
                        alma = credito * 0.05;
                        impu = alma * 1.15;
                        tot = credito + impu - alma;
                    }
                }
            }
            else
            {
                MessageBox.Show("Rellene el campo SUBTOTAL");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
