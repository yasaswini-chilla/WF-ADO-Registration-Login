using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.TextAlign = HorizontalAlignment.Left;
            }

            if (radioButton2.Checked)
            {
                textBox1.TextAlign = HorizontalAlignment.Center;
            }

            if (radioButton3.Checked)
            {
                textBox1.TextAlign = HorizontalAlignment.Right;
            }

            if (radioButton4.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }

            if (radioButton5.Checked)
            {
                textBox1.ForeColor = Color.Green;
            }

            if (radioButton6.Checked)
            {
                textBox1.ForeColor = Color.Yellow;
            }
        }
    }
    }

