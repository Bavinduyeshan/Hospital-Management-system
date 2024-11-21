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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace HMS
{
    public partial class DoctorForm : Form
    {
        // SqlConnection conn = new SqlConnection(@"Data Source=ASUS-EXPERTBOOK;Initial Catalog=HospitalManagementSystem2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public DoctorForm()
        {
            InitializeComponent();
            // Populate();
            // FillDoctorid();
            ToolTip toolTip1 = new ToolTip();

            // Set a custom delay time if needed (optional)
            toolTip1.AutoPopDelay = 5000; // Show the tooltip for 5 seconds
            toolTip1.InitialDelay = 1000; // Wait 1 second before showing tooltip
            toolTip1.ReshowDelay = 500; // Time between showing same tooltip

            // Set the ComboBox MouseHover event
            cmbdoc_id.MouseHover += (sender, e) =>
            {
                toolTip1.SetToolTip(cmbdoc_id, "Please Do not select in insert option,slect this only in update and delete");
            };
        }
        SqlConnection conn;
        string fname, lname, nic, gender, address, email, phone_number;


        //delete button click
        private void btnDel_Click(object sender, EventArgs e)
        {
            doctor_id = Convert.ToInt32(cmbdoc_id.SelectedValue);


            Doctor doctor = new Doctor(doctor_id, fname, lname, nic, date, gender, address, specialization, email, phone_number);
            doctor.Delete(conn, doctor_id);
            Populate();
            FillDoctorid();
        }

        string date, specialization;

        //data grid view mouse click and fill to textboxes code
        private void dgtDoctorlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmbdoc_id.Text = dgtDoctorlist.SelectedRows[0].Cells[0].Value.ToString();
                txtFname.Text = dgtDoctorlist.SelectedRows[0].Cells[1].Value.ToString();
                txtLname.Text = dgtDoctorlist.SelectedRows[0].Cells[2].Value.ToString();
                txtNIC.Text = dgtDoctorlist.SelectedRows[0].Cells[3].Value.ToString();
                dtbdoc.Text = dgtDoctorlist.SelectedRows[0].Cells[4].Value.ToString();
                cmbgender.Text = dgtDoctorlist.SelectedRows[0].Cells[6].Value.ToString();
                txtAddress.Text = dgtDoctorlist.SelectedRows[0].Cells[7].Value.ToString();

                txtspecialization.Text = dgtDoctorlist.SelectedRows[0].Cells[8].Value.ToString();
                txtEmail.Text = dgtDoctorlist.SelectedRows[0].Cells[9].Value.ToString();
                txtcontNo.Text = dgtDoctorlist.SelectedRows[0].Cells[10].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Populate();
        }

        //exit button code
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ! you want to exit from the system", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchformDoctor searchformDoctor = new SearchformDoctor();
            searchformDoctor.Show();
        }

        //home button code
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you need to move back to home", "Hospita Management system", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                dashboard dashboard = new dashboard();
                dashboard.Show();
            }
        }

        //btn update click
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbdoc_id.SelectedValue != null)
                {
                    doctor_id = Convert.ToInt32(cmbdoc_id.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Please select a valid patient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                fname = txtFname.Text;
                lname = txtLname.Text;

                nic = txtNIC.Text;
                string date = dtbdoc.Value.ToString("yyyy-MM-dd");
                // String date = dtbdoc.Text;  // Use DateTime directly
                gender = cmbgender.Text;
                address = txtAddress.Text;
                email = txtEmail.Text;
                specialization = txtspecialization.Text;
                phone_number = txtcontNo.Text;

                Doctor doctor = new Doctor(doctor_id, fname, lname, nic, date, gender, address, specialization, email, phone_number);
                doctor.Update(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Populate();
        }

        //DateTime date;
        int doctor_id;
        private void DoctorForm_Load(object sender, EventArgs e)
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

            Populate();
            FillDoctorid();
        }

        //fill doctor id code combobox
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
            Populate();
        }

        //populate code for fill specified data to datagridview
        private void Populate()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Doctor";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgtDoctorlist.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //button add code
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                fname = txtFname.Text;
                lname = txtLname.Text;

                nic = txtNIC.Text;
                string date = dtbdoc.Value.ToString("yyyy-MM-dd");
                // String date = dtbdoc.Text;  // Use DateTime directly
                gender = cmbgender.Text;
                address = txtAddress.Text;
                email = txtEmail.Text;
                specialization = txtspecialization.Text;
                phone_number = txtcontNo.Text;

                Doctor doctor = new Doctor(doctor_id, fname, lname, nic, date, gender, address, specialization, email, phone_number);
                doctor.Add(conn);

                Populate();
                FillDoctorid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }




       //doctor class
        public class Doctor : Person
        {
            private int doctor_id;
            private string fname;
            private string lname;
            private string nic;
            private string gender;
            private string address;
            private string email;
            private string specialization;
            private string phone_number;
            
           // private DateTime date;
            private string date;

            /*
            public Doctor(int doctor_id, string fname, string lname, string nic,  DateTime date, string gender, string Address, string specialization, string email, string phone_number)
            {
                this.doctor_id = doctor_id;
                this.fname = fname;
                this.lname = lname;
                this.nic = nic;
                this.date = date;
                this.gender = gender;
                this.Address = Address;
                this.specialization = specialization;
                this.email = email;
                this.phone_number = phone_number;
            }*/

            public Doctor(int doctor_id, string fname, string lname, string nic, string date, string gender, string address, string specialization, string email, string phone_number)
            {
                this.doctor_id = doctor_id;
                this.fname = fname;
                this.lname = lname;
                this.nic = nic;
                this.date = date;
                this.gender = gender;
                this.address = address;
                this.specialization = specialization;
                this.email = email;
                this.phone_number = phone_number;
            }

            //overide add button click ,in here we are parsing the sql connection conn as a parameter and when calling it we need to give parameter as well
            public override void Add(SqlConnection conn)
            {
                //throw new NotImplementedException();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Doctor VALUES (@firstname,@lastname,@NIC,@DOB,@gender,@address,@specialization,@email,@contactNO)", conn);

                    cmd.Parameters.AddWithValue("firstname", fname);
                    cmd.Parameters.AddWithValue("lastname", lname);
                    cmd.Parameters.AddWithValue("NIC", nic);
                    cmd.Parameters.Add("DOB", SqlDbType.Date).Value = date;
                    cmd.Parameters.AddWithValue("gender", gender);
                    cmd.Parameters.AddWithValue("address", address);
                    cmd.Parameters.AddWithValue("specialization", specialization);

                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("contactNO", phone_number);



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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public override void Delete(SqlConnection conn, int patientid)
            {

                //throw new NotImplementedException();

                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Doctor WHERE doctor_id = @doctor_id", conn);
                        cmd.Parameters.AddWithValue("@doctor_id", doctor_id);

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                
            public override void Update(SqlConnection conn)
            {
                //throw new NotImplementedException();

                conn.Open();
                string query = "UPDATE Doctor SET first_name=@first_name,last_name=@last_name, NIC=@NIC, DOB=@DOB, gender=@gender, address=@address, specialization=@specialization, email=@email, contactNo=@contactNo WHERE doctor_id=@doctor_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@doctor_id", doctor_id);
                    cmd.Parameters.AddWithValue("@first_name", fname);
                    cmd.Parameters.AddWithValue("@last_name", lname);
                    cmd.Parameters.AddWithValue("@NIC", nic);
                    cmd.Parameters.AddWithValue("@DOB", date); // Ensure `date` is a valid DateTime
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@address", address);
                   
                    cmd.Parameters.AddWithValue("@specialization", specialization);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@contactNo", phone_number);
                    


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

