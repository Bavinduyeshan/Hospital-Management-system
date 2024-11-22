using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Guna.UI2.WinForms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HMS
{
   
    public partial class Patients : Form
    {

        
        //SqlConnection conn = new SqlConnection(@"Data Source=ASUS-EXPERTBOOK;Initial Catalog=HospitalManagementSystem2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public Patients()
        {
            InitializeComponent();
           

            ToolTip toolTip1 = new ToolTip();

            // Set a custom delay time if needed (optional)
            toolTip1.AutoPopDelay = 5000; // Show the tooltip for 5 seconds
            toolTip1.InitialDelay = 1000; // Wait 1 second before showing tooltip
            toolTip1.ReshowDelay = 500; // Time between showing same tooltip

            // Set the ComboBox MouseHover event
            cmbpatientid.MouseHover += (sender, e) =>
            {
                toolTip1.SetToolTip(cmbpatientid, "Please Do not select in insert option,slect this only in update and delete");
            };

        }
        SqlConnection conn;
        string fname, lname, nic, gender, address, email, civilstatus, occupation, contactno;
        string date,doc_id, room_id;
        int patientid;
        //DateTime date;

        //datagridview cell click load code
        private void dgtpatientslist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmbpatientid.Text = dgtpatientslist.SelectedRows[0].Cells[0].Value.ToString();
                txtFname.Text = dgtpatientslist.SelectedRows[0].Cells[1].Value.ToString();
                txtLname.Text = dgtpatientslist.SelectedRows[0].Cells[2].Value.ToString();
                txtNIC.Text = dgtpatientslist.SelectedRows[0].Cells[3].Value.ToString();
                dtb1.Text = dgtpatientslist.SelectedRows[0].Cells[4].Value.ToString();
                cmbgender.Text = dgtpatientslist.SelectedRows[0].Cells[6].Value.ToString();
                txtAddress.Text = dgtpatientslist.SelectedRows[0].Cells[7].Value.ToString();
                txtOccupation.Text = dgtpatientslist.SelectedRows[0].Cells[8].Value.ToString();
                txtcivilstatus.Text = dgtpatientslist.SelectedRows[0].Cells[9].Value.ToString();
                txtEmail.Text = dgtpatientslist.SelectedRows[0].Cells[10].Value.ToString();
                txtcontNo.Text = dgtpatientslist.SelectedRows[0].Cells[11].Value.ToString();
                cmbdoc_id.Text = dgtpatientslist.SelectedRows[0].Cells[12].Value.ToString();
                cmbroom_id.Text = dgtpatientslist.SelectedRows[0].Cells[13].Value.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Populate();
         }

        //update  button code
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cmbpatientid.SelectedValue != null)
            {
                patientid = Convert.ToInt32(cmbpatientid.SelectedValue); // This should be an integer, not a string
            }
            else
            {
                MessageBox.Show("Please select a valid patient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if no patient ID is selected
            }

            //patientid = Convert.ToInt32(cmbpatientid.SelectedValue);
            fname = txtFname.Text;
            lname = txtLname.Text;
            nic = txtNIC.Text;
            // date = DateTime.Parse(dtb1.Text);
            //DateTime date = dtb1.Value.ToString("yyyy-MM-dd");
            string date = dtb1.Value.ToString("yyyy-MM-dd");
            gender = cmbgender.Text;
            address = txtAddress.Text;
            email = txtEmail.Text;
            occupation = txtOccupation.Text;
            civilstatus = txtcivilstatus.Text;
            doc_id = cmbdoc_id.Text;
            room_id = cmbroom_id.Text;
            contactno = txtcontNo.Text;
            
            Patient patient = new Patient(patientid, fname, lname, nic, date, gender, address, email, occupation, civilstatus, contactno, doc_id, room_id);

            
            patient.Update(conn);
            /*try
            {
                conn.Open();
                cmd = new SqlCommand("update Patient set firstname='" + txtFname.Text + "',lastname='" + txtLname.Text + "',NIC='" + txtNIC.Text + "',date_of_birth='" + dtb1.Value + "',gender='" + cmbgender.Text + "',address='" + txtAddress.Text + "',occupation='" + txtOccupation.Text + "',civilstatus='" + txtcivilstatus.Text + "',email='" + txtEmail.Text + "',contactNo='" + txtcontNo.Text + "',Doctor_id='" + cmbdoc_id.Text + "',room_id='" + cmbroom_id.Text + "' where patientid='" + cmbpatientid.SelectedValue + "'", conn);
                
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Updated", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update, try again.", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            Populate();
            FillRoomid();
            FillDoctorid();
        }

        private Guna.UI2.WinForms.Guna2ComboBox GetCmbpatientid()
        {
            return cmbpatientid;
        }


        //delelte button code
        private void btnDel_Click(object sender, EventArgs e)
        {
            patientid = Convert.ToInt32(cmbpatientid.SelectedValue);
           
            
                Patient patient = new Patient(patientid, fname, lname, nic, date, gender, address, email, occupation, civilstatus, contactno, doc_id, room_id);
                patient.Delete(conn, patientid);
                Populate();
                FillRoomid();





        }

        //report view code
        private void btnview_Click(object sender, EventArgs e)
        {
           patientreport r1=new patientreport();
            r1.Show();
        }



        //clear button code
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtcivilstatus.Text = "";
            txtcontNo.Text = "";
            txtEmail.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtNIC.Text = "";
            txtOccupation.Text = "";
            cmbdoc_id.Text = "";
            cmbgender.Text = "";
            cmbpatientid.Text = "";
            cmbroom_id.Text = "";
            txtFname.Focus();
        }

       /* private void cmbdescselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( cmbdescselect.SelectedItem.ToString() == "Add data")
            {
                btnupdate.Enabled = false;
                btnDel.Enabled = false;
                cmbpatientid.Enabled = false;
            }
            else if (cmbdescselect.SelectedItem != null && cmbdescselect.SelectedItem.ToString() == "Update  and Delete")

            {
                btnupdate.Enabled = true;
                btnDel.Enabled = true;
                cmbpatientid.Enabled=true;
            }
        }*/


        //exit button code
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        //home button click code
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back to Home", "HMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                dashboard dashboard= new dashboard();
                dashboard.Show();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchFormpatient searchFormpatient = new SearchFormpatient();
            searchFormpatient.Show();
        }

        //SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void Patients_Load(object sender, EventArgs e)
        {
            
            try
            {
                string connectionstring = "Data Source=ASUS-EXPERTBOOK;Initial Catalog=HospitalManagementSystem2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                conn = new SqlConnection(connectionstring);
            }
            catch (SqlException)
            {
                MessageBox.Show("Database error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtcontNo.Mask = "0000000000"; // Allows only 10 digits

            FillDoctorid();
            FillRoomid();
            FillPatientid();
            Populate();


           

        }

        private void guna2VScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void txtcivilstatus_OnValueChanged(object sender, EventArgs e)
        {

        }

        //fill doctor id code
        public void FillDoctorid()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("select doctor_id  from Doctor", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("doctor_id", typeof(int));
            dt.Load(rdr);
            cmbdoc_id.ValueMember = "doctor_id";
            cmbdoc_id.DataSource = dt;
            conn.Close();
        }


        //fill room id code
        public void FillRoomid()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT room_id FROM Rooms WHERE availability = 1", conn);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("room_id", typeof(string));
                dt.Load(rdr);

                cmbroom_id.ValueMember = "room_id";
                cmbroom_id.DataSource = dt;
                rdr.Close();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
           

        }


        //fillpatient code
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


        //populate code to display the data int the data table
        private void Populate()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Patient";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgtpatientslist.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            

        }


        //btn add click code
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbroom_id.Text))
                {
                    MessageBox.Show("Please select a room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                /*
                if(txtcontNo.Text.Length !=10)
                {
                    MessageBox.Show("invalid contact no", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }*/
                string contactNumber = txtcontNo.Text.Trim();

                if (string.IsNullOrEmpty(contactNumber) || contactNumber.Length != 10 || !contactNumber.All(char.IsDigit))
                {
                    MessageBox.Show("Please enter a valid 10-digit contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               



                // Check if room is available
                conn.Open();
                SqlCommand checkRoomCmd = new SqlCommand("SELECT availability FROM Rooms WHERE room_id = @room_id", conn);
                checkRoomCmd.Parameters.AddWithValue("@room_id", cmbroom_id.Text);
                int roomAvailability = (int)checkRoomCmd.ExecuteScalar();
                conn.Close();

                if (roomAvailability == 0)
                {
                    MessageBox.Show("The selected room is unavailable. Please choose a different room.", "Room Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }




                fname = txtFname.Text;
                lname = txtLname.Text;
                nic = txtNIC.Text;
               // date = DateTime.Parse(dtb1.Text);
                //DateTime date = dtb1.Value;
                 date = dtb1.Value.ToString("yyyy-MM-dd");
                gender = cmbgender.Text;
                address = txtAddress.Text;
                email = txtEmail.Text;
                occupation = txtOccupation.Text;
                civilstatus = txtcivilstatus.Text;
                doc_id = cmbdoc_id.Text;
                room_id = cmbroom_id.Text;
                contactno=txtcontNo.Text;

                Patient patient = new Patient(patientid,fname, lname, nic, date, gender, address, email, occupation, civilstatus, contactno, doc_id, room_id);

                // Call the Add method to insert data into the database
                patient.Add(conn);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            Populate();
            FillPatientid();
            //FillRoomid();
        }
    }

    //patient class
    public class Patient : Person
    {
        private int patientid;
        private string fname;
        private string lname;
        private string nic;
        private string gender;
        private string address;
        private string email;
        private string civilstatus;
        private string occupation;
        private string contactno;
        private string date;
        private string doc_id;
        private string room_id;

        // Constructor
        public Patient(int patientid,string fname, string lname, string nic, String date, string gender, string address,
                       string email, string occupation, string civilstatus, string contactno,
                       string doc_id, string room_id)
        {
            this.patientid= patientid;
            this.fname = fname;
            this.lname = lname;
            this.nic = nic;
            this.date = date;
            this.gender = gender;
            this.address = address;
            this.email = email;
            this.occupation = occupation;
            this.civilstatus = civilstatus;
            this.contactno = contactno;
            this.doc_id = doc_id;
            this.room_id = room_id;
        }

        /*public void Add(SqlConnection conn)
        {
            
        }
        */

        //overide add button
        public override void Add(SqlConnection conn)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Patient VALUES (@firstname,@lastname,@NIC,@date_of_birth,@gender,@address,@occupation,@civilstatus,@email,@contactNo,@Doctor_id,@room_id)", conn);

                cmd.Parameters.AddWithValue("@firstname", fname);
                cmd.Parameters.AddWithValue("@lastname", lname);
                cmd.Parameters.AddWithValue("@NIC", nic);
                cmd.Parameters.AddWithValue("@date_of_birth", date);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@occupation", occupation);
                cmd.Parameters.AddWithValue("@civilstatus", civilstatus);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@contactNo", contactno);
                cmd.Parameters.AddWithValue("@Doctor_id", doc_id);
                cmd.Parameters.AddWithValue("@room_id", room_id);


                int rowsAffected = cmd.ExecuteNonQuery();


                if (rowsAffected > 0)
                {
                    // MessageBox.Show("Successfully Added", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SqlCommand updateRoomCmd = new SqlCommand("UPDATE Rooms SET availability = 0 WHERE room_id = @room_id", conn);
                    updateRoomCmd.Parameters.AddWithValue("@room_id", room_id);
                    updateRoomCmd.ExecuteNonQuery();

                    MessageBox.Show("Patient added and room marked as unavailable.", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Add, Try Again", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //overide delte button
        public override void Delete(SqlConnection conn, int patientid)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();

                    
                    SqlCommand getRoomCmd = new SqlCommand("SELECT room_id FROM Patient WHERE patientid = @patientid", conn);
                    getRoomCmd.Parameters.AddWithValue("@patientid", patientid);
                    int room_id = (int)getRoomCmd.ExecuteScalar();
                   
                        SqlCommand checkBillCmd = new SqlCommand("SELECT * FROM Bill WHERE patient_id = @patient_id AND status = 'pending'", conn);
                        checkBillCmd.Parameters.AddWithValue("@patient_id", patientid);
                    SqlDataReader reader = checkBillCmd.ExecuteReader();

                    // If there are any unpaid bills, display an error message and exit
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Cannot delete patient. Bill is not paid yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close(); // Close the reader
                        conn.Close();
                        return;  // Exit the method if there are unpaid bills
                    }

                    reader.Close();

                    
                    SqlCommand cmd = new SqlCommand("DELETE FROM Patient WHERE patientid = @patientid", conn);
                    cmd.Parameters.AddWithValue("@patientid", patientid);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        SqlCommand updateRoomCmd = new SqlCommand("UPDATE Rooms SET availability = 1 WHERE room_id = @room_id", conn);

                        updateRoomCmd.Parameters.AddWithValue("@room_id", room_id);
                        updateRoomCmd.ExecuteNonQuery();

                        MessageBox.Show("Patient deleted and room marked as available.", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete, Try Again", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex) { 
                    MessageBox.Show(ex.Message);
                }
            // throw new NotImplementedException();
            
               
        }

        //overide update code
        public override void Update(SqlConnection conn)
        {
            
            
            conn.Open();
            string query = "UPDATE Patient SET firstname=@firstname,lastname=@lastname, NIC=@NIC, date_of_birth=@date_of_birth, gender=@gender, address=@address, occupation=@occupation, civilstatus=@civilstatus, email=@email, contactNo=@contactNo, Doctor_id=@Doctor_id, room_id=@room_id WHERE patientid=@patientid";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                
                cmd.Parameters.AddWithValue("@patientid", patientid);
                cmd.Parameters.AddWithValue("@firstname", fname);
                cmd.Parameters.AddWithValue("@lastname", lname);
                cmd.Parameters.AddWithValue("@NIC", nic);
                cmd.Parameters.AddWithValue("@date_of_birth", date); // Ensure `date` is a valid DateTime
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@occupation", occupation);
                cmd.Parameters.AddWithValue("@civilstatus", civilstatus);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@contactNo", contactno);
                cmd.Parameters.AddWithValue("@Doctor_id", doc_id);
                cmd.Parameters.AddWithValue("@room_id", room_id);

                
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
            conn.Close();
            
        }
    }
}
