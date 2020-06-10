using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace My_WinForm_Project
{
    public partial class Apartment : Form
    {
        public Apartment()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string username = txtname.Text;
            string pass = txtpassword.Text;
            SqlConnection con = new SqlConnection("Server=DESKTOP-EKUNIJ0;Database=Customer;User Id=sa;Password=9703464435");
            con.Open();
            SqlCommand cmd = new SqlCommand("USP_insertuser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", username);
            cmd.Parameters.AddWithValue("@password", pass);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Inserted Successfully");
            }

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string validname = txtvalidname.Text;
            string password = txtp.Text;
            SqlConnection con = new SqlConnection("Server=DESKTOP-EKUNIJ0;Database=Customer;User Id=sa;Password=9703464435");
            con.Open();
            SqlCommand cmd = new SqlCommand("USP_Check", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", validname);
            cmd.Parameters.AddWithValue("@password", password);
            int result = (int)cmd.ExecuteScalar();

            MessageBox.Show(" result = " + validname + password + result);



        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /*  private void Nameenter(object sender, EventArgs e)
          {
             
              if(txtfirstname.Text=="Enter Name")
              {
                  txtfirstname.Text = "";
                  txtfirstname.ForeColor = Color.Black;
              }
          }

        

          private void NameLeave(object sender, EventArgs e)
          {
          if (txtfirstname.Text == "")
              {
                  txtfirstname.Text = "Enter Name";
                  txtfirstname.ForeColor = Color.Red;
              }
          }

          private void label22_Click(object sender, EventArgs e)
          {

          }

          }*./

        

        

         /* private void btnsubmit_Click(object sender, EventArgs e)
          {
              Register r = new Register();
              r.Show();
              this.Hide();
          }*/








    }
        

    }

