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
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }
        char ch;

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text+"1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "3";
        }

       

        private void btn4_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "5";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "0";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txt1.Text = "0";
            txtmemory.Text = "0";
            txtop.Text = "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if(txt1.Text.Contains("."))
            {

            }
            else
            {
                txt1.Text = txt1.Text + ".";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(txt1.Text.Length>0)
            {

                txt1.Text = txt1.Text.Substring(0, txt1.Text.Length - 1);
            }
            if(txt1.Text.Length == 0)
            {
                txt1.Text = "0";
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            
            txtmemory.Text = txt1.Text;
           // txtop.Text = txt1.Text;
            txt1.Text = "0";
            txtop.Text = "+";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            txtmemory.Text = txt1.Text;
            txt1.Text = "0";
            txtop.Text = "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            txtmemory.Text = txt1.Text;
            txt1.Text = "0";
            txtop.Text = "*";
        }

        private void div_Click(object sender, EventArgs e)
        {

            txtmemory.Text = txt1.Text;
            txt1.Text = "0";
            txtop.Text = "/";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            
           if(txtop.Text == "+")
            {
                txt1.Text = (Convert.ToDecimal(txt1.Text) + Convert.ToDecimal(txtmemory.Text)).ToString();
            }
          else if (txtop.Text == "-")
            {
                txt1.Text = (Convert.ToDecimal(txt1.Text) - Convert.ToDecimal(txtmemory.Text)).ToString();
            }
           else if (txtop.Text == "*")
            {
                txt1.Text = (Convert.ToDecimal(txt1.Text) * Convert.ToDecimal(txtmemory.Text)).ToString();
            }
            else if (txtop.Text == "/")
            {
                txt1.Text = (Convert.ToDecimal(txt1.Text) / Convert.ToDecimal(txtmemory.Text)).ToString();
            }
        }
    }
}
