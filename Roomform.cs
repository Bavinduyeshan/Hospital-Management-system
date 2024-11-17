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
    public partial class Roomform : Form
    {
        public Roomform()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();

            // Set a custom delay time if needed (optional)
            toolTip1.AutoPopDelay = 5000; // Show the tooltip for 5 seconds
            toolTip1.InitialDelay = 1000; // Wait 1 second before showing tooltip
            toolTip1.ReshowDelay = 500; // Time between showing same tooltip

            // Set the ComboBox MouseHover event
            cmbroomid.MouseHover += (sender, e) =>
            {
                toolTip1.SetToolTip(cmbroomid, "Please Do not select in insert option,slect this only in update and delete");
            };
        }
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;
        int roomid;
        string roomnumber, roomtype;

        public void FillRoomid()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT room_id FROM Rooms ", conn);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("room_id", typeof(int));
                dt.Load(rdr);
                cmbroomid.ValueMember = "room_id";
                cmbroomid.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
           

        }
        public void Populate()
        {
            try
            {
                conn.Open();

                da = new SqlDataAdapter("SELECT * FROM Rooms", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                dgtroomlist.DataSource = dt;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                roomnumber =cmbroomno.Text;
                roomtype=cmbroomtype.Text;

                Room room=new Room(roomid, roomnumber,roomtype);
                room.Add(conn);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            Populate();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                roomid = Convert.ToInt32(cmbroomid.SelectedValue);
                roomnumber=cmbroomno.Text;
                roomtype=cmbroomtype.Text;

                Room room=new Room(roomid,roomnumber,roomtype);
                room.Update(conn);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            Populate();
        }

        private void dgtroomlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               cmbroomid.Text = dgtroomlist.SelectedRows[0].Cells[0].Value.ToString();
                cmbroomno.Text = dgtroomlist.SelectedRows[0].Cells[1].Value.ToString();
                cmbroomtype.Text = dgtroomlist.SelectedRows[0].Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                roomid =Convert.ToInt32(cmbroomid.SelectedValue);
                roomnumber=cmbroomno.Text;
                roomtype =cmbroomtype.Text;

                Room room = new Room(roomid, roomnumber, roomtype);
                room.Delete(conn, roomid);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            Populate() ;
        }

        private void cmbroomid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbroomid.Enabled) // If ComboBox is disabled (in add mode)
            {
                MessageBox.Show("You cannot select a room id; it's an identity field.");
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
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

        private void Roomform_Load(object sender, EventArgs e)
        {
            // cmbroomid.Enabled = false;
             try
             {
                 string connectionstring = "Data Source=ASUS-EXPERTBOOK;Initial Catalog=HospitalManagementSystem2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                 conn = new SqlConnection(connectionstring);
             }
             catch (Exception ex) {
                 MessageBox.Show(ex.Message);
             }
             //MessageBox.Show("You cannot select a room id; it's an identity field.");
             

           
            Populate();
            FillRoomid();
        }
    }


    //room class
    public class Room :Person
    {
        private int roomid;
        private string roomnumber;
        private string roomtype;
        private int availability;

        SqlConnection conn;

        public Room(int roomid, string roomnumber, string roomtype)
        {
            this.roomid = roomid;
            this.roomnumber = roomnumber;
            this.roomtype = roomtype;
        }

        
       
        public override void Add(SqlConnection conn)
        {

            
            //throw new NotImplementedException();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Rooms (room_number, room_type) VALUES (@room_number, @room_type)", conn);

                cmd.Parameters.AddWithValue("room_number", roomnumber);
                cmd.Parameters.AddWithValue("room_type", roomtype);
               
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

        public override void Delete(SqlConnection conn, int roomid)
        {
            //throw new NotImplementedException();
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Rooms WHERE room_id=@room_id", conn);
                    cmd.Parameters.AddWithValue("room_id", roomid);
                    
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
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        public override void Update(SqlConnection conn)
        {
            
            //throw new NotImplementedException();
            try
            {
                conn.Open();
                SqlCommand cmd =new SqlCommand( "UPDATE Rooms SET room_number=@room_number, room_type=@room_type WHERE room_id=@room_id",conn);

                
                
                    cmd.Parameters.AddWithValue("room_id", roomid);
                    cmd.Parameters.AddWithValue("room_number", roomnumber);
                    cmd.Parameters.AddWithValue("room_type", roomtype);

                    int rowsAffected =cmd.ExecuteNonQuery();

                    if (rowsAffected > 0) {
                        MessageBox.Show("Updates succesfully", "hospital management system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("unable to update", "hospital management system", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                
                conn.Close ();
                
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
