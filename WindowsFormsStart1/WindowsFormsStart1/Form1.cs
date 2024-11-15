using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStart1
{
    public partial class Back : Form
    {
        public Back()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Text = checkBox1.Text;
            }
            else if (checkBox2.Checked)
            {
                label1.Text = checkBox2.Text;
            }
            else if (checkBox3.Checked)
            {
                label1.Text = checkBox3.Text;

            }
            else
            {
                label1.Text = "바보";

            }

        }

    }
}
