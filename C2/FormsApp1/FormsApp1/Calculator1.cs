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
    public partial class Calculator1 : Form
    {
        private object txtRadius;
        private object txtHeight;
        private object txtWide;
        private object txtLong;
        private object errorProvider1;

        public object LabelResult { get; private set; }

        public Calculator1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void RBC_CheckedChanged(object sender, EventArgs e)
        {
            if (RBC.Checked == true)
            {
                txtRadius.Enabled = true;
                txtHeight.Enabled = false;
                txtWide.Enabled = false;
                txtLong.Enabled = false;
                txtRadius.Focus();
            }
        }

        private void RBS_CheckedChanged(object sender, EventArgs e)
        {
            if (RBS.Checked == true)
            {
                txtRadius.Enabled = false;
                txtHeight.Enabled = true;
                txtWide.Enabled = true;
                txtLong.Enabled = true;
                txtRadius.Focus();
            }
        }

        private void RBT_CheckedChanged(object sender, EventArgs e)
        {
            if (RBT.Checked == true)
            {
                txtRadius.Enabled = false;
                txtHeight.Enabled = true;
                txtWide.Enabled = true;
                txtLong.Enabled = false;
                txtRadius.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float result, radius, height, wide, Long;
            double result1;

            //Circle

            if (RBC.Checked == true)
            {
                if (txtRadius.Text == "")
                {
                    errorProvider1.SetError(txtRadius, "Please insert radius");
                }
                else
                {
                    radius = float.Parse(txtRadius.Text);
                    result = (22 / 7) * radius * radius;
                    LabelResult.Text = result.ToString();
                }
            }
            else if (RBS.Checked == true)
            {
                if (txtHeight.Text == "")
                {
                    errorProvider1.SetError(txtHeight, "Please insert height");
                }
                else if (txtWide.Text == "")
                {
                    errorProvider1.SetError(txtWide, "Please insert width");
                }
                else if (txtLong.Text == "")
                {
                    errorProvider1.SetError(txtLong, "Please insert long");
                }
                else
                {
                    height = float.Parse(txtHeight.Text);
                    wide = float.Parse(txtWide.Text);
                    Long = float.Parse(txtLong.Text);
                    result = height * wide;
                    LabelResult.Text = result.ToString();
                }
            }

            //Triangle
            else if (RBT.Checked == true)
            {
                if (txtHeight.Text == "")
                {
                    errorProvider1.SetError(txtHeight, "Please insert height");
                }
                else if (txtWide.Text == "")
                {
                    errorProvider1.SetError(txtWide, "Please insert width");
                }
                else
                {
                    height = float.Parse(txtHeight.Text);
                    wide = float.Parse(txtWide.Text);
                    result1 = (0.5) * height * wide;
                    LabelResult.Text = result1.ToString("#.00");
                }
            }
            else
            {
                MessageBox.Show("Please input value", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RBC.Checked = true;
            txtRadius.Clear();
            txtHeight.Clear();
            txtWide.Clear();
            txtLong.Clear();
            LabelResult.Text = "";
            errorProvider1.Clear();
        }
    }
    }
}