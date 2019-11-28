using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Calculator1 form = new Calculator1();
            form.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator1 form = new Calculator1();
            form.Show();
        }
    }
}
