using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class LoginRegform : Form
    {
        public LoginRegform()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string username,Password;

        private void LoginRegform_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = "Data Source=ASUS-EXPERTBOOK;Initial Catalog=HospitalManagementSystem2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                conn = new SqlConnection(connectionstring);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back to Login", "HMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        private void btnaddsuer_Click(object sender, EventArgs e)
        {
            try
            {
                username=txtUsername.Text;
                Password=txtpassword.Text;

                LoginReg loginReg = new LoginReg(username, Password);
                loginReg.Loginreg(conn);

            }
            catch (Exception ex) { 
                
            }
        }
    }



    public class LoginReg
    {
        private string username;
        private string password;


        public LoginReg(string username, string password) { 
            this.username = username;
            this.password = password;
        }

        public void Loginreg(SqlConnection conn)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Login (UserName,Password) VALUES (@UserName,@Password)", conn);

                cmd.Parameters.AddWithValue("UserName", username);
                cmd.Parameters.AddWithValue("Password", password);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                    MessageBox.Show("Successfully Registered", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to register, Try Again", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}