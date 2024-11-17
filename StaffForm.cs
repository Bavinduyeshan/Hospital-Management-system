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
using System.Xml.Linq;


namespace HMS
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();

            // Set a custom delay time if needed (optional)
            toolTip1.AutoPopDelay = 5000; // Show the tooltip for 5 seconds
            toolTip1.InitialDelay = 1000; // Wait 1 second before showing tooltip
            toolTip1.ReshowDelay = 500; // Time between showing same tooltip

            // Set the ComboBox MouseHover event
            cmbstaffID.MouseHover += (sender, e) =>
            {
                toolTip1.SetToolTip(cmbstaffID, "Please Do not select in insert option,slect this only in update and delete");
            };
        }
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;
        int staffID;
        string first_name;
        string last_name;
        string role;
        string department;
        string contactNo;
        string email;

        private void StaffForm_Load(object sender, EventArgs e)
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
            FillStaffid();
        }
        public void Populate()
        {
            try
            {
                conn.Open();

                da = new SqlDataAdapter("SELECT * FROM Staff", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                dgtstafflist.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FillStaffid()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT staffid FROM Staff ", conn);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("staffid", typeof(int));
                dt.Load(rdr);
                cmbstaffID.ValueMember = "staffid";
                cmbstaffID.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                staffID = Convert.ToInt32(cmbstaffID.SelectedValue);
                first_name = txtFname.Text;
                last_name = txtlname.Text;
                role = cmbROle.Text;
                department = cmbdepartment.Text;
                contactNo = txtcontno.Text;
                email = txtemail.Text;

                //Create Object
                Staff staff = new Staff(staffID, first_name, last_name, role, department, contactNo, email);
                staff.Add(conn); //Add Function call
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
                /*
                if (cmbstaffID.SelectedValue != null)
                {
                    staffID = Convert.ToInt32(cmbstaffID.SelectedValue); // This should be an integer, not a string
                }
                else
                {
                    MessageBox.Show("Please select a valid patient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method if no patient ID is selected
                }*/

                staffID = Convert.ToInt32(cmbstaffID.SelectedValue);
                first_name = txtFname.Text;
                last_name = txtlname.Text;
                role = cmbROle.Text;
                department = cmbdepartment.Text;
                contactNo = txtcontno.Text;
                email = txtemail.Text;

                Staff staff = new Staff(staffID, first_name, last_name, role, department, contactNo, email);

                staff.Update(conn);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Populate();

        }

        private void dgtstafflist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmbstaffID.Text = dgtstafflist.SelectedRows[0].Cells[0].Value.ToString();
                txtFname.Text = dgtstafflist.SelectedRows[0].Cells[1].Value.ToString();
                txtlname.Text = dgtstafflist.SelectedRows[0].Cells[2].Value.ToString();
                cmbROle.Text = dgtstafflist.SelectedRows[0].Cells[3].Value.ToString();
               cmbdepartment.Text = dgtstafflist.SelectedRows[0].Cells[4].Value.ToString();
                txtcontno.Text = dgtstafflist.SelectedRows[0].Cells[5].Value.ToString();
                txtemail.Text = dgtstafflist.SelectedRows[0].Cells[6].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Populate() ;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                staffID = Convert.ToInt32(cmbstaffID.SelectedValue);


                Staff staff = new Staff(staffID, first_name, last_name, role,department, contactNo, email);

                staff.Delete(conn, staffID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Populate();

        }

        private void cmbstaffID_MouseHover(object sender, EventArgs e)
        {
           // toolTip1.SetToolTip(cmbstaffID, "Please select an option from the list.");
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbstaffID.Text = "";
            cmbdepartment.Text = "";
            cmbROle.SelectedValue = "";
            txtFname.Text = "";
            txtlname.Text = "";
            txtemail.Text = "";
            txtcontno.Text = "";
            txtFname.Focus();
        }
    }




    //staff class

    public class Staff :Person
    {
        private int staffID;
        private string first_name;
        private string last_name;
        private string role;
        private string department;
        private string contactNo;
        private string email;

        public Staff(int staffID, string first_name, string last_name, string role, string department, string contactNo, string email)
        {
            this.staffID = staffID;
            this.first_name = first_name;
            this.last_name = last_name;
            this.role = role;
            this.department = department;
            this.contactNo = contactNo;
            this.email = email;
        }

        public override void Add(SqlConnection conn)
        {
            //throw new NotImplementedException();
            try
            {
                conn.Open(); //Connection Open

                SqlCommand cmd = new SqlCommand("INSERT INTO Staff VALUES (@firstname,@lastname,@role,@department,@contactNo,@email)", conn);

                //cmd.Parameters.AddWithValue("staffid", staffID);
                cmd.Parameters.AddWithValue("firstname", first_name);
                cmd.Parameters.AddWithValue("lastname", last_name);
                cmd.Parameters.AddWithValue("role", role);
                cmd.Parameters.AddWithValue("department", department);
                cmd.Parameters.AddWithValue("contactNo", contactNo);
                cmd.Parameters.AddWithValue("email", email);

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
            // throw new NotImplementedException();
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Staff WHERE staffid = @staffid", conn);
                    cmd.Parameters.AddWithValue("staffid", staffID);

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
            // throw new NotImplementedException();
            try
            {
                conn.Open();
                string query = "UPDATE Staff SET firstname = @firstname, lastname =@lastname, role = @role, department = @department, contactNo = @contactNo, email = @email WHERE staffid = @staffid";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@staffid", staffID);
                    cmd.Parameters.AddWithValue("@firstname", first_name);
                    cmd.Parameters.AddWithValue("@lastname", last_name);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@department", department);
                    cmd.Parameters.AddWithValue("@contactNo", contactNo);
                    cmd.Parameters.AddWithValue("@email", email);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
