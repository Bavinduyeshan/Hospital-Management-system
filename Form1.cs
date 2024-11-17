using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HMS
{



    
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter dt;

       
        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtUsername.Text;
            password=txtpassword.Text;
           

            Login login=new Login(username, password);
            login.Checklogin(conn);
            this.Hide();
            dashboard f2 = new dashboard();
            f2.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure ,you need to Exit from this System", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        /*private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginRegform loginRegform = new LoginRegform();
            loginRegform.Show();
        }*/

       /* private void txtreglabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginRegform loginRegform = new LoginRegform();
            loginRegform.Show();
        }*/

        private void btnregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginRegform loginRegform = new LoginRegform();
            loginRegform.Show();
        }
    }



    public class Login 
    {
        public string username;
        public string password;



        public Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void Checklogin(SqlConnection conn)
        {

            try
            {
                conn.Open();
                string query = "select * from Login where Username=@UserName and Password=@Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    MessageBox.Show("Login successful", "Railway login system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Railway login system", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {

                MessageBox.Show("Error while searching", "Railway login system", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            conn.Close();
        }
    }

 }
