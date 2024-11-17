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
    public partial class MedicalHistoryForm : Form
    {
        public MedicalHistoryForm()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();

            // Set a custom delay time if needed (optional)
            toolTip1.AutoPopDelay = 5000; // Show the tooltip for 5 seconds
            toolTip1.InitialDelay = 1000; // Wait 1 second before showing tooltip
            toolTip1.ReshowDelay = 500; // Time between showing same tooltip

            // Set the ComboBox MouseHover event
           cmbHistoryid.MouseHover += (sender, e) =>
            {
                toolTip1.SetToolTip(cmbHistoryid, "Please Do not select in insert option,slect this only in update and delete");
            };
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        int historyid, patientid;
        string diagnosis, treatment, notes;

        //populate code to fill data in datadrid view
        private void Populate()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM MedicalHistory";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgthistorylist.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                historyid = Convert.ToInt32(cmbHistoryid.SelectedValue);
                patientid = Convert.ToInt32(cmbpatientid.SelectedValue);
                diagnosis=txtdiagnosis.Text;
                treatment=txttreatment.Text;
                notes=txtnotes.Text;

                Medicalhistory medicalhistory=new Medicalhistory(historyid,patientid, diagnosis,treatment,notes); 
                medicalhistory.Update(conn);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgthistorylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmbHistoryid.Text = dgthistorylist.SelectedRows[0].Cells[0].Value.ToString();
                cmbpatientid.Text = dgthistorylist.SelectedRows[0].Cells[1].Value.ToString();
                txtdiagnosis.Text = dgthistorylist.SelectedRows[0].Cells[2].Value.ToString();
                txttreatment.Text = dgthistorylist.SelectedRows[0].Cells[3].Value.ToString();
                txtnotes.Text = dgthistorylist.SelectedRows[0].Cells[4].Value.ToString();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Populate();
        }

        private void MedicalHistoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = "Data Source=ASUS-EXPERTBOOK;Initial Catalog=HospitalManagementSystem2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                conn = new SqlConnection(connectionstring);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            FillPatientid();
            Populate();
            FillHistoryid();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back to Home", "HMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                dashboard dashboard = new dashboard();
                dashboard.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                historyid=Convert.ToInt32(cmbHistoryid.SelectedValue);

                Medicalhistory medicalhistory=new Medicalhistory(historyid, patientid, diagnosis, treatment, notes);
                medicalhistory.Delete(conn,historyid);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Populate();
        }

        //fill history id
        public void FillHistoryid()
        {


            conn.Open();
            SqlCommand cmd = new SqlCommand("select HistoryID  from MedicalHistory", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("HistoryID", typeof(int));
            dt.Load(rdr);
            cmbHistoryid.ValueMember = "HistoryID";
            cmbHistoryid.DataSource = dt;
            conn.Close();
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
            cmbpatientid.ValueMember = "patientid";
            cmbpatientid.DataSource = dt;
            conn.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                patientid=Convert.ToInt32(cmbpatientid.SelectedValue);
                diagnosis=txtdiagnosis.Text;
                treatment=txttreatment.Text;
                notes=txtnotes.Text;

                Medicalhistory medicalhistory=new Medicalhistory(historyid,patientid, diagnosis, treatment, notes);
                medicalhistory.Add(conn);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Populate();
        }
    }


    //medicalhistory form
    public class Medicalhistory :Person
    {
        private int historyid;
        private int patientid;
        private string diagnosis;
        private string treatment;
        private string notes;
        
        SqlCommand cmd;
        SqlDataAdapter da;

        public Medicalhistory(int historyid, int patientid, string diagnosis, string treatment, string notes)
        {
            this.historyid = historyid;
            this.patientid = patientid;
            this.diagnosis = diagnosis;
            this.treatment = treatment;
            this.notes = notes;
           
        }

        public override void Add(SqlConnection conn)
        {
            //throw new NotImplementedException();

            try
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO MedicalHistory (PatientID, Diagnosis, Treatment, Notes, Date) VALUES (@PatientID, @Diagnosis, @Treatment, @Notes, GETDATE())", conn);

                cmd.Parameters.AddWithValue("PatientID",patientid);
                cmd.Parameters.AddWithValue("Diagnosis", diagnosis);
                cmd.Parameters.AddWithValue("Treatment", treatment);
                cmd.Parameters.AddWithValue("Notes", notes);
                

                int rowsAffected = cmd.ExecuteNonQuery();


                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Added", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Add, Try Again", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override void Delete(SqlConnection conn, int patientid)
        {
            //throw new NotImplementedException();

            try
            {
                if(MessageBox.Show("Are you surer ,you need to delete this record","Medical History",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("delete FROM MedicalHistory WHERE HistoryID=@HistoryID", conn);

                    cmd.Parameters.AddWithValue("HistoryID", historyid);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Delete succesfull", "Medical History", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Failed to delete", "Medical History", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    conn.Close();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override void Update(SqlConnection conn)
        {
            //throw new NotImplementedException();
            try
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE MedicalHistory SET PatientID=@PatientID,Diagnosis=@Diagnosis,Treatment=@Treatment,Notes=@Notes WHERE HistoryID=@HistoryID",conn);

                cmd.Parameters.AddWithValue("@HistoryID", historyid);
                cmd.Parameters.AddWithValue("@PatientID", patientid);
                cmd.Parameters.AddWithValue("@Diagnosis", diagnosis);
                cmd.Parameters.AddWithValue("@Treatment", treatment);
                cmd.Parameters.AddWithValue("@Notes", notes);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Updates succesfully", "hospital management system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("unable to update", "hospital management system", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                conn.Close() ;
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
