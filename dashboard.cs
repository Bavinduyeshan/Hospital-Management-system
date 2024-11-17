using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patients f3= new Patients();
            f3.Show();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorForm f4= new DoctorForm();
            f4.Show();
        }

        private void btnguardian_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiardianForm f5= new GiardianForm();
            f5.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            Roomform f6= new Roomform();
            f6.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillingForm f7= new BillingForm();
            f7.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffForm f8= new StaffForm();
            f8.Show();
        }

        private void btnmedhistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicalHistoryForm f7= new MedicalHistoryForm();
            f7.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ! you want to exit from the system", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAppoinment_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppoinmnetForm f7= new AppoinmnetForm();
            f7.Show();
        }
    }
}
