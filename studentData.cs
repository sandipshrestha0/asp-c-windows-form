using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class studentData : Form
    {
        //global declaration
        DataGridViewButtonColumn coledit = new DataGridViewButtonColumn();
        DataGridViewButtonColumn coldelete = new DataGridViewButtonColumn();


        public studentData()
        {
            InitializeComponent();
        }

        private void studentData_Load(object sender, EventArgs e)
        {
            dgvStudentInfo.DataSource = GetAllRecord("DESKTOP-UV1GG8R", "sandip", "tblstudent");
            //for edit button
            coledit.HeaderText = "Edit";
            coledit.MinimumWidth = 6;
            coledit.Name = "coledit";
            coledit.ReadOnly = true;
            coledit.Text = "Edit";
            coledit.UseColumnTextForButtonValue = true;
            coledit.Width = 125;
            //add column to grid
            dgvStudentInfo.Columns.Add(coledit);


            //for delete button
            coldelete.HeaderText = "Delete";
            coldelete.MinimumWidth = 6;
            coldelete.Name = "coldelete";
            coldelete.ReadOnly = true;
            coldelete.Text = "Delete";
            coldelete.UseColumnTextForButtonValue = true;
            coldelete.Width = 125;
            //add column to grid
            dgvStudentInfo.Columns.Add(coldelete);

        }
        private DataTable GetAllRecord(string servername, string databasename, string tblname)
        {
            SqlConnection conn = new SqlConnection("server="+servername + "; database="+databasename+"; integrated security = true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from "+tblname +"");
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            conn.Close();
            return (dt);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //insert data into table
        private void DatabaseInsert()
        {

            SqlConnection conn = new SqlConnection("server=DESKTOP-UV1GG8R; database=sandip; integrated security = true;");
            conn.Open();
            
            SqlCommand cmd = new SqlCommand("insert into tblstudent" +
                "( Name, Email, Age, DOB, Address, Gender)" +
                "values( @Name, @Email, @Age, @DOB, @Address, @Gender)");
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Age", nuAge.Text);
            cmd.Parameters.AddWithValue("@DOB", dtpdob.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Gender", cbGender.Text);

            cmd.Connection = conn;

            //execute query
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
                MessageBox.Show("data saved!");
            else
                MessageBox.Show("data save Failed!");
        }

        // DataBase update code---
        private void DatabaseUpdate()
        {

            SqlConnection conn = new SqlConnection("server=DESKTOP-UV1GG8R; database=sandip; integrated security = true;");
            conn.Open();
            //update data 
            SqlCommand cmd = new SqlCommand("update tblstudent set Name=@Name, Email= @Email," +
                " Age=@Age, DOB=@DOB, Address=@Address, Gender=@Gender where sn=@sn");
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Age", nuAge.Text);
            cmd.Parameters.AddWithValue("@DOB", dtpdob.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Gender", cbGender.Text);
            cmd.Parameters.AddWithValue("@sn", txtId.Text);

            cmd.Connection = conn;

            //execute query
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
                MessageBox.Show("data saved!");
            else
                MessageBox.Show("data save Failed!");
        }
        // database delete code
        // DataBase update code---
      /* private void DatabaseDelete()
        {

            SqlConnection conn = new SqlConnection("server=DESKTOP-UV1GG8R; database=sandip; integrated security = true;");
            conn.Open();
            //update data 
            SqlCommand cmd = new SqlCommand("delete from tblstudent where sn=@sn");
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Age", nuAge.Text);
            cmd.Parameters.AddWithValue("@DOB", dtpdob.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Gender", cbGender.Text);
            //  cmd.Parameters.AddWithValue("@sn", txtId.Text);

            cmd.Parameters.AddWithValue("@sn", dgvStudentInfo.Rows[e.RowIndex].Cells["sn"].Value.ToString());
            cmd.Connection = conn;

            //execute query
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
                MessageBox.Show("data saved!");
            else
                MessageBox.Show("data save Failed!");
        }
      */

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                DatabaseInsert();
                dgvStudentInfo.DataSource = GetAllRecord("DESKTOP-UV1GG8R", "sandip", "tblstudent");

            }
            else if (btnSave.Text == "Update")
            {
                DatabaseUpdate();
                dgvStudentInfo.DataSource = GetAllRecord("DESKTOP-UV1GG8R", "sandip", "tblstudent");

            }

        }

        private void dgvStudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==coledit.Index)
            {
                txtId.Text = dgvStudentInfo.Rows[e.RowIndex].Cells["sn"].Value.ToString();
                txtName.Text = dgvStudentInfo.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtEmail.Text = dgvStudentInfo.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                nuAge.Value = Convert.ToInt32(dgvStudentInfo.Rows[e.RowIndex].Cells["Age"].Value.ToString());
                dtpdob.Value = Convert.ToDateTime(dgvStudentInfo.Rows[e.RowIndex].Cells["DOB"].Value.ToString());
                txtAddress.Text = dgvStudentInfo.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                cbGender.Text = dgvStudentInfo.Rows[e.RowIndex].Cells["Gender"].Value.ToString();

                //
                btnSave.Text = "Update";
            }
            else if(e.ColumnIndex == coldelete.Index) // delete
            {
              DialogResult ans = MessageBox.Show("Are you sure to delete ", "confirmation", MessageBoxButtons.YesNo);
                if(ans==DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection("server=DESKTOP-UV1GG8R; database=sandip; " +
                        "integrated security = true;");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from tblstudent where sn=@sn");

                    cmd.Parameters.AddWithValue("@sn", dgvStudentInfo.Rows[e.RowIndex].Cells["sn"].Value.ToString());
                    cmd.Connection = conn;

                    int rtn = cmd.ExecuteNonQuery();

                    if (rtn > 0)
                        MessageBox.Show("data deleted!");
                    else
                        MessageBox.Show("data delete Failed!");

                    dgvStudentInfo.DataSource = GetAllRecord("DESKTOP-UV1GG8R", "sandip", "tblstudent");
                }

            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //create the temproray datasource i.e. bindingsource becoz it can filter
            BindingSource bs = new BindingSource();
            // assign original datasource(i.e) data to binding source
            bs.DataSource = dgvStudentInfo.DataSource;

            //now filter the binding source
            bs.Filter = "Name like '*" + txtsearch.Text + "*'";
            //now assign filtered data in grid
            dgvStudentInfo.DataSource = bs;
            //clear any selection if any on datagrid
            dgvStudentInfo.ClearSelection();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            nuAge.Value = 0;
            cbGender.Text = "";
            dtpdob.Value = DateTime.Now;
            txtAddress.Clear();
        }
    }
}
