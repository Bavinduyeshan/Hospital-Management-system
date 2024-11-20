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
    public partial class SearchFormpatient : Form
    {
        public SearchFormpatient()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void FillPatientid()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("select patientid  from Patient", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("patientid", typeof(int));
            dt.Load(rdr);
            cmbsearch.ValueMember = "patientid";
            cmbsearch.DataSource = dt;
            conn.Close();
        }
        private void SearchForm_Load(object sender, EventArgs e)
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
            FillPatientid();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Use SqlCommand to add the parameter
                cmd = new SqlCommand("SELECT * FROM Patient WHERE patientid = @patientid", conn);
                cmd.Parameters.AddWithValue("@patientid", cmbsearch.SelectedValue);

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
    }
}
