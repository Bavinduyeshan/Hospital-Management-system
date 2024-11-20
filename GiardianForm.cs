using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace HMS
{
    public partial class GiardianForm : Form
    {
        public GiardianForm()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();

            // Set a custom delay time if needed (optional)
            toolTip1.AutoPopDelay = 5000; // Show the tooltip for 5 seconds
            toolTip1.InitialDelay = 1000; // Wait 1 second before showing tooltip
            toolTip1.ReshowDelay = 500; // Time between showing same tooltip

            // Set the ComboBox MouseHover event
            cmbguardian.MouseHover += (sender, e) =>
            {
                toolTip1.SetToolTip(cmbguardian, "Please Do not select in insert option,slect this only in update and delete");
            };
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        string nic, name, relationship, contactNo;
        int patientid,guardianid;
        private void GiardianForm_Load(object sender, EventArgs e)
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
            Populate();
            FillGuardianid();


        }

        //guardian data drid view  load the data to text fields from the database
        private void dgtguardianlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmbguardian.Text = dgtguardianlist.SelectedRows[0].Cells[0].Value.ToString();
                cmbpatientid.Text = dgtguardianlist.SelectedRows[0].Cells[1].Value.ToString();
                txtNIC.Text = dgtguardianlist.SelectedRows[0].Cells[3].Value.ToString();
                txtname.Text = dgtguardianlist.SelectedRows[0].Cells[2].Value.ToString();
                cmbrelation.Text = dgtguardianlist.SelectedRows[0].Cells[4].Value.ToString();
                txtcontNo.Text = dgtguardianlist.SelectedRows[0].Cells[5].Value.ToString();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Populate();
        }

        //fill patient id 
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

        //delete button click
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                guardianid = Convert.ToInt32(cmbguardian.SelectedValue);
                

                Guardian guardian = new Guardian(guardianid, patientid, nic, name, relationship, contactNo);

                guardian.Delete(conn, guardianid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Populate();
        }

        //update button click
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbguardian.SelectedValue != null)
                {
                    guardianid = Convert.ToInt32(cmbguardian.SelectedValue); // This should be an integer, not a string
                }
                else
                {
                    MessageBox.Show("Please select a valid patient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method if no patient ID is selected
                }
               
                patientid = Convert.ToInt32(cmbpatientid.SelectedValue);
                nic = txtNIC.Text;
                name = txtname.Text;
                relationship = cmbrelation.Text;
                contactNo = txtcontNo.Text;

                Guardian guardian = new Guardian(guardianid, patientid, nic, name, relationship, contactNo);

                guardian.Update(conn);

                Populate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ,you need to Exit from this System", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ,you need to move to Home", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                dashboard dashboard= new dashboard();
                dashboard.Show();
            }
        }

        public void FillGuardianid()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("select guardianID  from Guardian", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("guardianID", typeof(int));
            dt.Load(rdr);
            cmbguardian.ValueMember = "guardianID";
            cmbguardian.DataSource = dt;
            conn.Close();
        }

        //populate code to refresh the data drid view 
        private void Populate()
        {
            /*
            try
            {
                conn.Open();
                string query = "SELECT * FROM Guardian";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgtguardianlist.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            try
            {
                conn.Open();
                da = new SqlDataAdapter("Select * from Guardian", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                dgtguardianlist.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                patientid = Convert.ToInt32(cmbpatientid.SelectedValue);
                nic=txtNIC.Text;
                name=txtname    .Text;
                relationship = cmbrelation.Text;
                contactNo=txtcontNo.Text;

                Guardian guardian = new Guardian(guardianid, patientid, nic, name, relationship, contactNo);

                guardian.Add(conn);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            Populate();
        }
    }


    //guardian class
    public class Guardian : Person
    {
        private int guardianid;
        private string guardianname;
        private string nic;
        private string relationship;
        private string contNo;
        private int patientid;

        public Guardian(int guardianid, int patientid ,string guardianname, string nic, string relationship, string contNo)
        {
            this.guardianid = guardianid;
            this.guardianname = guardianname;
            this.nic = nic;
            this.relationship = relationship;
            this.contNo = contNo;
            this.patientid = patientid;
        }

        public override void Add(SqlConnection conn)
        {
            // throw new NotImplementedException();
            try
            {
                conn.Open();
                SqlCommand cmd=new SqlCommand("INSERT INTO Guardian VALUES (@patientid,@NIC,@name,@relationship_to_patient,@contactNo)",conn);

                cmd.Parameters.AddWithValue("@patientid", patientid);
                cmd.Parameters.AddWithValue("@NIC", nic);
                cmd.Parameters.AddWithValue("@name", guardianname);
                cmd.Parameters.AddWithValue("@relationship_to_patient", relationship);
                cmd.Parameters.AddWithValue("@contactNo", contNo);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0) {

                    MessageBox.Show("Successfully Added", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Add, Try Again", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public override void Delete(SqlConnection conn, int guardianID)
        {
            //throw new NotImplementedException();
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Delete FROM Guardian WHERE guardianID=@guardianID", conn);
                    cmd.Parameters.AddWithValue("@guardianID", guardianid);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully deleted", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete, Try Again", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                    
                }
                   
            }
           
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        public override void Update(SqlConnection conn)
        {
            //throw new NotImplementedException();
            try
            {
                conn.Open();
                string query = "UPDATE Guardian SET  patientid=@patientid,NIC=@NIC,name=@name,relationship_to_patient=@relationship_to_patient,contactNo=@contactNo WHERE guardianID=@guardianID ";
                

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@guardianID", guardianid);
                    cmd.Parameters.AddWithValue("@patientid", patientid);
                    cmd.Parameters.AddWithValue("@NIC", nic);
                    cmd.Parameters.AddWithValue("@name", guardianname);
                    cmd.Parameters.AddWithValue("@relationship_to_patient", relationship);
                    cmd.Parameters.AddWithValue("@contactNo", contNo);


                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully Updated", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update, try again.", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                conn.Close ();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
