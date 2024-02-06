namespace Ejemplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ing, il,ip;
            ing = double.Parse(maskedTextBox1.Text);
           
            if (maskedTextBox1.Text==String.Empty)
            {
                MessageBox.Show("No puede ser nulo", "Advertencia");
                
            }
            else
            {
                if (ing <= 0 || ing > 500000)
                {
                    MessageBox.Show("No puede ser negativo ni cero ni mayor a 500000", "Advertencia");
                    maskedTextBox1.Text = "";


                }
                else
                {
                    if (comboBox1.SelectedItem.Equals("Laboral"))
                    {
                        il = ing * 0.07;
                        textBox1.Text = il.ToString();
                    }
                    else
                    {

                        ip = ing * 22;
                        textBox2.Text = ip.ToString();

                    }
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            textBox1.Text = "";
            maskedTextBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}