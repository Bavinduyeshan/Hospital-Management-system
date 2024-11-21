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
    public partial class SearchformDoctor : Form
    {
        public SearchformDoctor()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataAdapter da;
        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Use SqlCommand to add the parameter
                cmd = new SqlCommand("SELECT * FROM Doctor WHERE doctor_id = @doctor_id", conn);
                cmd.Parameters.AddWithValue("doctor_id", cmbdocsearch.SelectedValue);

                // Use DataAdapter to fill the DataTable
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Bind the result to DataGridView
                dgtsearchlist.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchformDoctor_Load(object sender, EventArgs e)
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
            FillDoctorid();
        }
        public void FillDoctorid()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("select doctor_id  from Doctor", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("doctor_id", typeof(int));
            dt.Load(rdr);
            cmbdocsearch.ValueMember = "doctor_id";
            cmbdocsearch.DataSource = dt;
            conn.Close();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ! you want to exit from the system", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.Show();
        }
    }
}
