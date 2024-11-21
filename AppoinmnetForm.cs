using Guna.UI2.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS
{
    public partial class AppoinmnetForm : Form
    {
        public AppoinmnetForm()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;


        int appointmentID;
        int patientID;
        int doctorID;
        DateTime appointmentDate;
        TimeSpan appointmentTime;
        string status;
        string contNo;

        private void AppoinmnetForm_Load(object sender, EventArgs e)
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
            FillPatientid();
            FillAppoinmentid();
        }
        public void Populate()
        {
            try
            {
                conn.Open();

                da = new SqlDataAdapter("SELECT * FROM Appointment", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                dgtappoinmentlist.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        public void FillDoctorid()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("select doctor_id  from Doctor", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("doctor_id", typeof(int));
            dt.Load(rdr);
            cmbdocid.ValueMember = "doctor_id";
            cmbdocid.DataSource = dt;
            conn.Close();
            Populate();
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
            cmbappid.ValueMember = "appointment_id";
            cmbappid.DataSource = dt;
            conn.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                appointmentID = Convert.ToInt32(cmbappid.SelectedValue);
                patientID = Convert.ToInt32(cmbpatientid.SelectedValue);
                doctorID = Convert.ToInt32(cmbdocid.SelectedValue);
                appointmentDate = dtbappointdate.Value.Date;
                appointmentTime = dtbappoinmenttime.Value.TimeOfDay;
                status = cmbstatus.Text;
                contNo = txtcontactno.Text;

                //Create Object
               Appoinment appointment = new Appoinment(appointmentID, patientID, doctorID, appointmentDate, appointmentTime, status, contNo);
                appointment.Add(conn); //Add Function call
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Populate();

        }

        private void dgtappoinmentlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmbappid.Text = dgtappoinmentlist.SelectedRows[0].Cells[0].Value.ToString();
                cmbpatientid.Text = dgtappoinmentlist.SelectedRows[0].Cells[1].Value.ToString();
                cmbdocid.Text = dgtappoinmentlist.SelectedRows[0].Cells[2].Value.ToString();
                dtbappointdate.Text = dgtappoinmentlist.SelectedRows[0].Cells[3].Value.ToString();
               dtbappoinmenttime.Text = dgtappoinmentlist.SelectedRows[0].Cells[4].Value.ToString();
                cmbstatus.Text = dgtappoinmentlist.SelectedRows[0].Cells[5].Value.ToString();
                txtcontactno.Text = dgtappoinmentlist.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Populate();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbappid.SelectedValue != null)
                {
                    appointmentID = Convert.ToInt32(cmbappid.SelectedValue); // This should be an integer, not a string
                }
                else
                {
                    MessageBox.Show("Please select a valid patient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method if no patient ID is selected
                }
                //appointmentID = Convert.ToInt32(cmbAppoinment.SelectedValue);
                patientID = Convert.ToInt32(cmbpatientid.SelectedValue);
                doctorID = Convert.ToInt32(cmbdocid.SelectedValue);
                appointmentDate = dtbappointdate.Value.Date;
                appointmentTime = dtbappoinmenttime.Value.TimeOfDay;
                status = cmbstatus.Text;
                contNo = txtcontactno.Text;


                Appoinment appointment = new Appoinment(appointmentID, patientID, doctorID, appointmentDate, appointmentTime, status, contNo);

                appointment.Update(conn);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Populate();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                appointmentID = Convert.ToInt32(cmbappid.SelectedValue);
                Appoinment appointment = new Appoinment(appointmentID, patientID, doctorID, appointmentDate, appointmentTime, status, contNo);

                appointment.Delete(conn, appointmentID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Populate() ;
            FillAppoinmentid();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you need to move back to home", "Hospita Management system", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                dashboard dashboard = new dashboard();
                dashboard.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ! you want to exit from the system", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            this.Hide();
            appoinmentreportform appoinmentreportform = new appoinmentreportform();
            appoinmentreportform.Show();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searchformappoinment searchformappoinment = new Searchformappoinment();
            searchformappoinment.Show();
        }
    }


    //appoinment class
    public class Appoinment : Person
    {
        private int appointmentID;
        private int patientID;
        private int doctorID;
        private DateTime appointmentDate;
        private TimeSpan appointmentTime;
        private string status;
        private string contNo;


        public Appoinment(int appointmentID, int patientID, int doctorID, DateTime appointmentDate, TimeSpan appointmentTime, string status, string contNo)
        {
            this.appointmentID = appointmentID;
            this.patientID = patientID;
            this.doctorID = doctorID;
            this.appointmentDate = appointmentDate;
            this.appointmentTime = appointmentTime;
            this.status = status;
            this.contNo = contNo;
        }

        public override void Add(SqlConnection conn)
        {
            //throw new NotImplementedException();
            try
            {
                conn.Open(); //Connection Open

                SqlCommand cmd = new SqlCommand("INSERT INTO Appointment(patient_id,doctor_id,appointment_date,appointment_time,status,phone_number) VALUES(@patient_id,@doctor_id,@appointment_date,@appointment_time,@status,@phone_number)", conn);
                
                cmd.Parameters.AddWithValue("patient_id", patientID);
                cmd.Parameters.AddWithValue("doctor_id", doctorID);
                cmd.Parameters.AddWithValue("appointment_date", appointmentDate);
                cmd.Parameters.AddWithValue("appointment_time", appointmentTime);
                cmd.Parameters.AddWithValue("status", status);
                cmd.Parameters.AddWithValue("phone_number", contNo);

                int rowsAffected = cmd.ExecuteNonQuery(); // Affect to rows(add data)
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Add", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Add", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                conn.Close(); //Connection close

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
                    SqlCommand cmd = new SqlCommand("DELETE FROM Appointment WHERE appointment_id = @appointment_id", conn);
                    cmd.Parameters.AddWithValue("appointment_id", appointmentID);

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
            try
            {
                conn.Open();
                {
                    SqlCommand cmd  =new SqlCommand( "UPDATE Appointment SET patient_id = @patient_id, doctor_id = @doctor_id, appointment_date = @appointment_date, appointment_time = @appointment_time, status = @status, phone_number = @phone_number WHERE appointment_id = @appointment_id",conn);


                    
                    
                        cmd.Parameters.AddWithValue("@appointment_id", appointmentID);
                        cmd.Parameters.AddWithValue("@patient_id", patientID);
                        cmd.Parameters.AddWithValue("@doctor_id", doctorID);
                        cmd.Parameters.AddWithValue("@appointment_date", appointmentDate);
                        cmd.Parameters.AddWithValue("@appointment_time", appointmentTime);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@phone_number", contNo);

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        { }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
