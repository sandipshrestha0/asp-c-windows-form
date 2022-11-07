using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frmBilling : Form
    {

        private Font verdana10Font;
        private StreamReader reader;
        public frmBilling()
        {
            InitializeComponent();
        }

        private void frmBilling_Load(object sender, EventArgs e)
        {
            txtBillNum.Text = GetBillNumber();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvList.Rows.Add(new string[] { (dgvList.Rows.Count + 1).ToString(), 
                txtItemName.Text, numQty.Value.ToString(), numRate.Value.ToString(), 
                numAmt.Value.ToString() });
            //empty textboxes
            txtItemName.Text = "";
            numQty.Value = 0;
            numRate.Value = 0;
            //numAmt.Value = 0;

            //set cursor in itemName
            txtItemName.Focus();
           txtTotal.Text = GetTotal().ToString();
        }
        decimal GetTotal()
        {
            decimal total = 0;
            for(int i =0; i<dgvList.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dgvList.Rows[i].Cells["colAmt"].Value);
            }
            return total;

        } 
       
        // auto bill number
        private string GetBillNumber()
        {
            string str = DateTime.Now.ToString("ddMMyyyyhhmmss");
            return str;
        }
        
        private void numQty_Enter(object sender, EventArgs e)
        {
            numQty.Text = "";
        }

        private void numRate_Enter(object sender, EventArgs e)
        {
            numRate.Text = " ";

        }

     

        private void numAmt_Enter(object sender, EventArgs e)
        {
            numAmt.Value =  numQty.Value * numRate.Value;
        }

        

        private void txtNetAmt_Enter(object sender, EventArgs e)
        {
            if(txtTotal.Text == "" || txtDiscount.Text == "")
            {

            }
            else
            {
                decimal TotalAmount = Convert.ToDecimal(txtTotal.Text);
                decimal Discount = Convert.ToDecimal(txtDiscount.Text);
                txtNetAmt.Text = (TotalAmount - ((TotalAmount * Discount) / 100)).ToString();
            }
        }

        private void txtDiscount_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvList.Rows.Clear();
            txtTotal.Clear();
        }

      

        //printing bill output


        private void SetBillHeader()
        {
            mybill.Text = "";
            mybill.Text = "ABC Co. Ltd\nKathmandu\nph:123456\n";
            mybill.Text += "Bill#:" + txtBillNum.Text + "\t Customer Name:Customer\n";
            mybill.Text += "Date:" + dateTimePicker1.Text  + "\n\n";
            mybill.Text += "Sno\tItem Name\t\tQty\tRate\tAmount\n";
            

        }
        private void SetBillFooter()
        {
            mybill.Text += "thank you for visiting us!!";

        }

        private void SetBillContent()
        {
            for (int i = 0; i < dgvList.Rows.Count; i++)
            {
                mybill.Text += dgvList.Rows[i].Cells["colSn"].Value.ToString() + "\t" +
                    dgvList.Rows[i].Cells["colItem"].Value.ToString() + "\t\t" + 
                    dgvList.Rows[i].Cells["colQty"].Value.ToString() + "\t" + 
                    dgvList.Rows[i].Cells["colRate"].Value.ToString() + "\t" + 
                    dgvList.Rows[i].Cells["colAmt"].Value.ToString() + "\n";

            }
        }

     
        private void txtItemName_Enter(object sender, EventArgs e)
        {
            //select text if exist in textbox when cursur IN
            if (txtItemName.Text.Length > 0)
            {
                txtItemName.SelectAll();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SetBillHeader();
            SetBillContent();
            SetBillFooter();
            File.WriteAllText(txtBillNum.Text + ".txt", mybill.Text);


            //print
            string filename =txtBillNum.Text + ".txt";
            //Create a StreamReader object  
            reader = new StreamReader(filename);
            //Create a Verdana font with size 10  
            verdana10Font = new Font("Verdana", 10);
            //Create a PrintDocument object  
            PrintDocument pd = new PrintDocument();
            //Add PrintPage event handler  
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
            //Call Print Method  
            pd.Print();
            //Close the reader  
            if (reader != null)
                reader.Close();
        }
        private void PrintTextFileHandler(object sender, PrintPageEventArgs ppeArgs)
        {
            //Get the Graphics object  
            Graphics g = ppeArgs.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            //Read margins from PrintPageEventArgs  
            float leftMargin = ppeArgs.MarginBounds.Left;
            float topMargin = ppeArgs.MarginBounds.Top;
            string line = null;
            //Calculate the lines per page on the basis of the height of the page and the height of the font  
            linesPerPage = ppeArgs.MarginBounds.Height / verdana10Font.GetHeight(g);
            //Now read lines one by one, using StreamReader  
            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                //Calculate the starting position  
                yPos = topMargin + (count * verdana10Font.GetHeight(g));
                //Draw text  
                g.DrawString(line, verdana10Font, Brushes.Black, leftMargin, yPos, new StringFormat());
                //Move to next line  
                count++;
            }
            //If PrintPageEventArgs has more pages to print  
            if (line != null)
            {
                ppeArgs.HasMorePages = true;
            }
            else
            {
                ppeArgs.HasMorePages = false;
            }
        }

        private void mybill_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
