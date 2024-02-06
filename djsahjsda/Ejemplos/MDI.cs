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
    public partial class MDI : Form
        
    {
        Form1 f = new Form1();
        Form2 f2 = new Form2();
        public MDI()
        {
            InitializeComponent();
        }

        private void inssLaboralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.MdiParent = this;
            f.Show();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            f2.MdiParent = this;
            f2.Show();


        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        } 
    }
}
