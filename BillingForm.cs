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
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();

            // Set a custom delay time if needed (optional)
            toolTip1.AutoPopDelay = 5000; // Show the tooltip for 5 seconds
            toolTip1.InitialDelay = 1000; // Wait 1 second before showing tooltip
            toolTip1.ReshowDelay = 500; // Time between showing same tooltip

            // Set the ComboBox MouseHover event
            cmbbillid.MouseHover += (sender, e) =>
            {
                toolTip1.SetToolTip(cmbbillid, "Please Do not select in insert option,slect this only in update and delete");
            };
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        int billingid;
         int patientid;
         decimal billam;
         string billdate;
         string billstatus;
        private void btnreport_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you need to have a detailed report","Billing",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                billingreport billingreport = new billingreport();
                billingreport.Show();
            }
        }

        public void Populate()
        {
            try
            {
                conn.Open();
                da = new SqlDataAdapter("Select * from Bill", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                dgtBilllist.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void FillBillid()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("select billid  from Bill", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("billid", typeof(int));
            dt.Load(rdr);
           cmbbillid.ValueMember = "billid";
            cmbbillid.DataSource = dt;
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
        private void BillingForm_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = "Data Source=ASUS-EXPERTBOOK;Initial Catalog=HospitalManagementSystem2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                conn = new SqlConnection(connectionstring);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FillPatientid();
            Populate();
            FillBillid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                patientid = Convert.ToInt32(cmbpatientid.SelectedValue);
                billam=Convert.ToDecimal(txtbillam.Text);
                billstatus=cmbbillstatus.Text;

                Billing billing=new Billing(billingid ,patientid,billam,billdate,billstatus);
                billing.Add(conn);




            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgtBilllist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmbbillid.Text = dgtBilllist.SelectedRows[0].Cells[0].Value.ToString();
                cmbpatientid.Text = dgtBilllist.SelectedRows[0].Cells[1].Value.ToString();
                txtbillam.Text = dgtBilllist.SelectedRows[0].Cells[2].Value.ToString();
                cmbbillstatus.Text = dgtBilllist.SelectedRows[0].Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FillBillid();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                billingid = Convert.ToInt32(cmbbillid.SelectedValue);
                patientid=Convert.ToInt32(cmbpatientid.SelectedValue);
                billam=Convert.ToDecimal(txtbillam.Text);
                billstatus = cmbbillstatus.Text;

                Billing billing=new Billing(billingid, patientid, billam,billdate, billstatus);
                billing.Update(conn);

                Populate();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                
                billingid=Convert.ToInt32(cmbbillid.SelectedValue);

                Billing billing = new Billing(billingid, patientid, billam, billdate, billstatus);
                billing.Delete(conn, billingid);
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            Populate();
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbbillid.Text = "";
            cmbpatientid.Text = "";
            cmbbillstatus.Text = "";
            txtbillam.Text = "";
            cmbbillid.Focus();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ,you need to move to Home", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                this.Close();
                dashboard dashboard = new dashboard();
                dashboard.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ,you need to Exit from this System", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }
    }


    //Billing form

    public class Billing :Person
    {
        private int billingid;
        private int patientid;
        private decimal billam;
        private string billdate;
        private string billstatus;
        SqlCommand cmd;

        public Billing(int billingid, int patientid, decimal billam, string billdate, string billstatus)
        {
            this.billingid = billingid;
            this.patientid = patientid;
            this.billam = billam;
            this.billdate = billdate;
            this.billstatus = billstatus;
        }

        public override void Add(SqlConnection conn)
        {
            //throw new NotImplementedException();

            try
            {
                conn.Open();
                 cmd = new SqlCommand("INSERT INTO Bill (patient_id, amount, status) VALUES (@patient_id, @amount, @status)", conn);

                cmd.Parameters.AddWithValue("patient_id", patientid);
                cmd.Parameters.AddWithValue("amount", billam);
                cmd.Parameters.AddWithValue("status", billstatus);

                int rowsAffected=cmd.ExecuteNonQuery();

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
            catch (Exception ex) {
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM Bill WHERE billid=@billid", conn);
                    cmd.Parameters.AddWithValue("billid", billingid);

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
                string query = "UPDATE Bill SET patient_id = @patient_id, amount = @amount, status = @status WHERE billid = @billid";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@billid", billingid);
                    cmd.Parameters.AddWithValue("@patient_id", patientid);
                    cmd.Parameters.AddWithValue("@amount", billam);
                    cmd.Parameters.AddWithValue("@status", billstatus);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Updates succesfully", "hospital management system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("unable to update", "hospital management system", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
