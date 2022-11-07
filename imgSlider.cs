using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class imgSlider : Form
    {
        public imgSlider()
        {
            InitializeComponent();
        }

       

        private void imgSlider_Load(object sender, EventArgs e)
        {
              imgBoard.Load(@"E:\5th sem\.net\WindowsFormsApp1\pic\img (1).jpg");
        }

        private void imgBoard_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if(txtNum.Text == "5")
            {
                txtNum.Text = "0";
            }
            txtNum.Text = (Convert.ToInt32(txtNum.Text) + 1).ToString();
            imgBoard.Load(@"E:\5th sem\.net\WindowsFormsApp1\pic\img ("+txtNum.Text+").jpg");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

            if (txtNum.Text == "1")
            {
                txtNum.Text = "6";
            }
            txtNum.Text = (Convert.ToInt32(txtNum.Text) - 1).ToString();
            imgBoard.Load(@"E:\5th sem\.net\WindowsFormsApp1\pic\img (" + txtNum.Text + ").jpg");

        }
    }
}
