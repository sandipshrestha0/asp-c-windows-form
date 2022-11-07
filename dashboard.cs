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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void sumOfTwoNumberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           sum obj = new sum();
            obj.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculator obj1 = new calculator();
            obj1.Show();
        }

        private void imageSliderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgSlider obj2 = new imgSlider();
            obj2.Show();
        }

        private void negativPositiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NegativePositive obj3 = new NegativePositive();
            obj3.Show();
        }

        private void billingFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBilling obj4 = new frmBilling();
                obj4.Show();
        }

        private void programsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentData obj8 = new studentData();
            obj8.ShowDialog();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
