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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        private void btnPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patients f3= new Patients();
            f3.Show();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorForm f4= new DoctorForm();
            f4.Show();
        }

        private void btnguardian_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiardianForm f5= new GiardianForm();
            f5.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            Roomform f6= new Roomform();
            f6.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillingForm f7= new BillingForm();
            f7.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffForm f8= new StaffForm();
            f8.Show();
        }

        private void btnmedhistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicalHistoryForm f7= new MedicalHistoryForm();
            f7.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ! you want to exit from the system", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAppoinment_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppoinmnetForm f7= new AppoinmnetForm();
            f7.Show();
        }

        private void dashboard_Load(object sender, EventArgs e)
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
            GetPatientCount();
            GetDoctorcount();
            GetStaffcount();
        }
        public void GetPatientCount()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Patient"; // Replace `Patient` with your actual table name
                SqlCommand cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row
                lblpatientcount.Text = ("Total patients:" + count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching patient count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            finally
            {
                conn.Close(); 
            }
        }

        public void GetDoctorcount()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Doctor"; // Replace `Patient` with your actual table name
                SqlCommand cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row
                lbldoccount.Text = ("Total Doctors:" + count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching patient count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }
        }


        public void GetStaffcount()
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Staff"; // Replace `Patient` with your actual table name
                SqlCommand cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row
                lblstaffcount.Text = ("Total Staff Members:" + count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching patient count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
