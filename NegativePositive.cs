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
    public partial class NegativePositive : Form
    {
        public NegativePositive()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtv1.Text);
            if(a<0)
            {
                txtv2.Text = "negative";
            }
            else
            {
                txtv2.Text = "positive";
            }
        }

        private void txtv1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
