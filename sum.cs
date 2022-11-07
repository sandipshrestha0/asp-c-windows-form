using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class sum : Form
    {
        public sum()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtv1.Text);
            double b = Convert.ToDouble(txtv2.Text);
            txtv3.Text = (a + b).ToString();
        }
    }
}
