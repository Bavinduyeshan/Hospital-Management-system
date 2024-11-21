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
    public partial class Searchformappoinment : Form
    {
        public Searchformappoinment()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        private void Searchformappoinment_Load(object sender, EventArgs e)
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
            FillAppoinmentid();
        }
        public void FillAppoinmentid()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("select appointment_id  from Appointment", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("appointment_id", typeof(int));
            dt.Load(rdr);
            cmbappsearch.ValueMember = "appointment_id";
            cmbappsearch.DataSource = dt;
            conn.Close();
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Use SqlCommand to add the parameter
                cmd = new SqlCommand("SELECT * FROM Appointment WHERE appointment_id = @appointment_id", conn);
                cmd.Parameters.AddWithValue("appointment_id", cmbappsearch.SelectedValue);

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppoinmnetForm appoinmnetForm = new AppoinmnetForm();
            appoinmnetForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ! you want to exit from the system", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
