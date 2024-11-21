namespace HMS
{
    partial class AppoinmnetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppoinmnetForm));
            this.btnreport = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtcontactno = new System.Windows.Forms.MaskedTextBox();
            this.lblcontno = new System.Windows.Forms.Label();
            this.dtbappointdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtbappoinmenttime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbstatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbappid = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblappid = new System.Windows.Forms.Label();
            this.cmbdocid = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbldtstatus = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.cmbpatientid = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblappoinmentdate = new System.Windows.Forms.Label();
            this.lblappoinmnettime = new System.Windows.Forms.Label();
            this.lbldoctorid = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgtappoinmentlist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnsearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtappoinmentlist)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnreport
            // 
            this.btnreport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.btnreport.BorderRadius = 20;
            this.btnreport.BorderThickness = 1;
            this.btnreport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreport.FillColor = System.Drawing.Color.White;
            this.btnreport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btnreport.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(178)))), ((int)(((byte)(253)))));
            this.btnreport.Location = new System.Drawing.Point(36, 401);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(199, 53);
            this.btnreport.TabIndex = 7;
            this.btnreport.Text = "Generate Report";
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.btnExit.BorderRadius = 20;
            this.btnExit.BorderThickness = 1;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(178)))), ((int)(((byte)(253)))));
            this.btnExit.Location = new System.Drawing.Point(44, 96);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 45);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHome
            // 
            this.btnHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.btnHome.BorderRadius = 20;
            this.btnHome.BorderThickness = 1;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btnHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(178)))), ((int)(((byte)(253)))));
            this.btnHome.Location = new System.Drawing.Point(44, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(170, 45);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnclear
            // 
            this.btnclear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.btnclear.BorderRadius = 20;
            this.btnclear.BorderThickness = 1;
            this.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclear.FillColor = System.Drawing.Color.White;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btnclear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(178)))), ((int)(((byte)(253)))));
            this.btnclear.Location = new System.Drawing.Point(44, 312);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(169, 45);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "clear";
            // 
            // btnDel
            // 
            this.btnDel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.btnDel.BorderRadius = 20;
            this.btnDel.BorderThickness = 1;
            this.btnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDel.FillColor = System.Drawing.Color.White;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btnDel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(178)))), ((int)(((byte)(253)))));
            this.btnDel.Location = new System.Drawing.Point(44, 205);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(170, 45);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.btnupdate.BorderRadius = 20;
            this.btnupdate.BorderThickness = 1;
            this.btnupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnupdate.FillColor = System.Drawing.Color.White;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btnupdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(178)))), ((int)(((byte)(253)))));
            this.btnupdate.Location = new System.Drawing.Point(42, 114);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(169, 45);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(178)))), ((int)(((byte)(253)))));
            this.btnAdd.Location = new System.Drawing.Point(42, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.txtcontactno);
            this.guna2GroupBox1.Controls.Add(this.lblcontno);
            this.guna2GroupBox1.Controls.Add(this.dtbappointdate);
            this.guna2GroupBox1.Controls.Add(this.dtbappoinmenttime);
            this.guna2GroupBox1.Controls.Add(this.cmbstatus);
            this.guna2GroupBox1.Controls.Add(this.cmbappid);
            this.guna2GroupBox1.Controls.Add(this.lblappid);
            this.guna2GroupBox1.Controls.Add(this.cmbdocid);
            this.guna2GroupBox1.Controls.Add(this.lbldtstatus);
            this.guna2GroupBox1.Controls.Add(this.lblPatientID);
            this.guna2GroupBox1.Controls.Add(this.cmbpatientid);
            this.guna2GroupBox1.Controls.Add(this.lblappoinmentdate);
            this.guna2GroupBox1.Controls.Add(this.lblappoinmnettime);
            this.guna2GroupBox1.Controls.Add(this.lbldoctorid);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(337, 180);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(584, 662);
            this.guna2GroupBox1.TabIndex = 29;
            this.guna2GroupBox1.Text = "Appoinment Entry";
            // 
            // txtcontactno
            // 
            this.txtcontactno.Location = new System.Drawing.Point(266, 474);
            this.txtcontactno.Mask = "(000)_0000000";
            this.txtcontactno.Name = "txtcontactno";
            this.txtcontactno.Size = new System.Drawing.Size(225, 27);
            this.txtcontactno.TabIndex = 61;
            // 
            // lblcontno
            // 
            this.lblcontno.AutoSize = true;
            this.lblcontno.BackColor = System.Drawing.Color.White;
            this.lblcontno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lblcontno.Location = new System.Drawing.Point(38, 470);
            this.lblcontno.Name = "lblcontno";
            this.lblcontno.Size = new System.Drawing.Size(119, 28);
            this.lblcontno.TabIndex = 60;
            this.lblcontno.Text = "Contact No";
            // 
            // dtbappointdate
            // 
            this.dtbappointdate.Checked = true;
            this.dtbappointdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(220)))), ((int)(((byte)(243)))));
            this.dtbappointdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtbappointdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtbappointdate.Location = new System.Drawing.Point(266, 225);
            this.dtbappointdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtbappointdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtbappointdate.Name = "dtbappointdate";
            this.dtbappointdate.Size = new System.Drawing.Size(225, 36);
            this.dtbappointdate.TabIndex = 59;
            this.dtbappointdate.Value = new System.DateTime(2024, 11, 15, 9, 42, 38, 121);
            // 
            // dtbappoinmenttime
            // 
            this.dtbappoinmenttime.Checked = true;
            this.dtbappoinmenttime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(220)))), ((int)(((byte)(243)))));
            this.dtbappoinmenttime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtbappoinmenttime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtbappoinmenttime.Location = new System.Drawing.Point(266, 290);
            this.dtbappoinmenttime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtbappoinmenttime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtbappoinmenttime.Name = "dtbappoinmenttime";
            this.dtbappoinmenttime.Size = new System.Drawing.Size(225, 36);
            this.dtbappoinmenttime.TabIndex = 58;
            this.dtbappoinmenttime.Value = new System.DateTime(2024, 11, 15, 9, 39, 32, 411);
            // 
            // cmbstatus
            // 
            this.cmbstatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbstatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbstatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbstatus.ItemHeight = 30;
            this.cmbstatus.Items.AddRange(new object[] {
            "Father",
            "Mom",
            "Sister/brother",
            "Other"});
            this.cmbstatus.Location = new System.Drawing.Point(266, 378);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(225, 36);
            this.cmbstatus.TabIndex = 57;
            // 
            // cmbappid
            // 
            this.cmbappid.BackColor = System.Drawing.Color.Transparent;
            this.cmbappid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbappid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbappid.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbappid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbappid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbappid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbappid.ItemHeight = 30;
            this.cmbappid.Location = new System.Drawing.Point(266, 54);
            this.cmbappid.Name = "cmbappid";
            this.cmbappid.Size = new System.Drawing.Size(225, 36);
            this.cmbappid.TabIndex = 56;
            // 
            // lblappid
            // 
            this.lblappid.AutoSize = true;
            this.lblappid.BackColor = System.Drawing.Color.White;
            this.lblappid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblappid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lblappid.Location = new System.Drawing.Point(35, 54);
            this.lblappid.Name = "lblappid";
            this.lblappid.Size = new System.Drawing.Size(156, 28);
            this.lblappid.TabIndex = 55;
            this.lblappid.Text = "Appoinment ID";
            // 
            // cmbdocid
            // 
            this.cmbdocid.BackColor = System.Drawing.Color.Transparent;
            this.cmbdocid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbdocid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdocid.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbdocid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbdocid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbdocid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbdocid.ItemHeight = 30;
            this.cmbdocid.Items.AddRange(new object[] {
            "Father",
            "Mom",
            "Sister/brother",
            "Other"});
            this.cmbdocid.Location = new System.Drawing.Point(262, 155);
            this.cmbdocid.Name = "cmbdocid";
            this.cmbdocid.Size = new System.Drawing.Size(229, 36);
            this.cmbdocid.TabIndex = 54;
            // 
            // lbldtstatus
            // 
            this.lbldtstatus.AutoSize = true;
            this.lbldtstatus.BackColor = System.Drawing.Color.White;
            this.lbldtstatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lbldtstatus.Location = new System.Drawing.Point(38, 378);
            this.lbldtstatus.Name = "lbldtstatus";
            this.lbldtstatus.Size = new System.Drawing.Size(71, 28);
            this.lbldtstatus.TabIndex = 53;
            this.lbldtstatus.Text = "Status";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.BackColor = System.Drawing.Color.White;
            this.lblPatientID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lblPatientID.Location = new System.Drawing.Point(35, 100);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(104, 28);
            this.lblPatientID.TabIndex = 51;
            this.lblPatientID.Text = "Patient id";
            // 
            // cmbpatientid
            // 
            this.cmbpatientid.BackColor = System.Drawing.Color.Transparent;
            this.cmbpatientid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbpatientid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpatientid.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbpatientid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbpatientid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbpatientid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbpatientid.ItemHeight = 30;
            this.cmbpatientid.Location = new System.Drawing.Point(266, 100);
            this.cmbpatientid.Name = "cmbpatientid";
            this.cmbpatientid.Size = new System.Drawing.Size(225, 36);
            this.cmbpatientid.TabIndex = 49;
            // 
            // lblappoinmentdate
            // 
            this.lblappoinmentdate.AutoSize = true;
            this.lblappoinmentdate.BackColor = System.Drawing.Color.White;
            this.lblappoinmentdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblappoinmentdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lblappoinmentdate.Location = new System.Drawing.Point(38, 225);
            this.lblappoinmentdate.Name = "lblappoinmentdate";
            this.lblappoinmentdate.Size = new System.Drawing.Size(180, 28);
            this.lblappoinmentdate.TabIndex = 44;
            this.lblappoinmentdate.Text = "Appoinment Date";
            // 
            // lblappoinmnettime
            // 
            this.lblappoinmnettime.AutoSize = true;
            this.lblappoinmnettime.BackColor = System.Drawing.Color.White;
            this.lblappoinmnettime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblappoinmnettime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lblappoinmnettime.Location = new System.Drawing.Point(35, 298);
            this.lblappoinmnettime.Name = "lblappoinmnettime";
            this.lblappoinmnettime.Size = new System.Drawing.Size(182, 28);
            this.lblappoinmnettime.TabIndex = 43;
            this.lblappoinmnettime.Text = "Appoinmnet Time";
            // 
            // lbldoctorid
            // 
            this.lbldoctorid.AutoSize = true;
            this.lbldoctorid.BackColor = System.Drawing.Color.White;
            this.lbldoctorid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctorid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lbldoctorid.Location = new System.Drawing.Point(35, 155);
            this.lbldoctorid.Name = "lbldoctorid";
            this.lbldoctorid.Size = new System.Drawing.Size(104, 28);
            this.lbldoctorid.TabIndex = 42;
            this.lbldoctorid.Text = "Doctor ID";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.Controls.Add(this.dgtappoinmentlist);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(964, 180);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(859, 662);
            this.guna2GroupBox2.TabIndex = 30;
            this.guna2GroupBox2.Text = "Appoinment  Data";
            // 
            // dgtappoinmentlist
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgtappoinmentlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtappoinmentlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtappoinmentlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgtappoinmentlist.ColumnHeadersHeight = 4;
            this.dgtappoinmentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtappoinmentlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgtappoinmentlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgtappoinmentlist.Location = new System.Drawing.Point(18, 46);
            this.dgtappoinmentlist.Name = "dgtappoinmentlist";
            this.dgtappoinmentlist.RowHeadersVisible = false;
            this.dgtappoinmentlist.RowHeadersWidth = 51;
            this.dgtappoinmentlist.RowTemplate.Height = 24;
            this.dgtappoinmentlist.Size = new System.Drawing.Size(787, 282);
            this.dgtappoinmentlist.TabIndex = 2;
            this.dgtappoinmentlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgtappoinmentlist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgtappoinmentlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgtappoinmentlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgtappoinmentlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgtappoinmentlist.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.dgtappoinmentlist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgtappoinmentlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgtappoinmentlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgtappoinmentlist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgtappoinmentlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgtappoinmentlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgtappoinmentlist.ThemeStyle.HeaderStyle.Height = 4;
            this.dgtappoinmentlist.ThemeStyle.ReadOnly = false;
            this.dgtappoinmentlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgtappoinmentlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgtappoinmentlist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgtappoinmentlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.dgtappoinmentlist.ThemeStyle.RowsStyle.Height = 24;
            this.dgtappoinmentlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgtappoinmentlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgtappoinmentlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtappoinmentlist_CellContentClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(633, 27);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel1.Size = new System.Drawing.Size(727, 64);
            this.guna2Panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(286, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Appoinment";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.guna2Panel3.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel3.BorderRadius = 25;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Panel3.Location = new System.Drawing.Point(-15, -6);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel3.Size = new System.Drawing.Size(244, 134);
            this.guna2Panel3.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(32, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unity Health Care";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(74, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(94, 79);
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 25;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.btnsearch);
            this.guna2Panel2.Controls.Add(this.btnreport);
            this.guna2Panel2.Controls.Add(this.btnclear);
            this.guna2Panel2.Controls.Add(this.btnAdd);
            this.guna2Panel2.Controls.Add(this.btnupdate);
            this.guna2Panel2.Controls.Add(this.btnDel);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Panel2.Location = new System.Drawing.Point(-15, 180);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel2.Size = new System.Drawing.Size(244, 571);
            this.guna2Panel2.TabIndex = 33;
            // 
            // btnsearch
            // 
            this.btnsearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.btnsearch.BorderRadius = 20;
            this.btnsearch.BorderThickness = 1;
            this.btnsearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsearch.FillColor = System.Drawing.Color.White;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btnsearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(178)))), ((int)(((byte)(253)))));
            this.btnsearch.Location = new System.Drawing.Point(42, 496);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(169, 45);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Search";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.guna2Panel4.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel4.BorderRadius = 25;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.btnHome);
            this.guna2Panel4.Controls.Add(this.btnExit);
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Panel4.Location = new System.Drawing.Point(-15, 820);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel4.Size = new System.Drawing.Size(244, 240);
            this.guna2Panel4.TabIndex = 33;
            // 
            // AppoinmnetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1835, 1055);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.Name = "AppoinmnetForm";
            this.Text = "AppoinmnetForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AppoinmnetForm_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtappoinmentlist)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnclear;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbappid;
        private System.Windows.Forms.Label lblappid;
        private Guna.UI2.WinForms.Guna2ComboBox cmbdocid;
        private System.Windows.Forms.Label lbldtstatus;
        private System.Windows.Forms.Label lblPatientID;
        private Guna.UI2.WinForms.Guna2ComboBox cmbpatientid;
        private System.Windows.Forms.Label lblappoinmentdate;
        private System.Windows.Forms.Label lblappoinmnettime;
        private System.Windows.Forms.Label lbldoctorid;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgtappoinmentlist;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtbappoinmenttime;
        private Guna.UI2.WinForms.Guna2ComboBox cmbstatus;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtbappointdate;
        private System.Windows.Forms.MaskedTextBox txtcontactno;
        private System.Windows.Forms.Label lblcontno;
        private Guna.UI2.WinForms.Guna2Button btnreport;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnsearch;
    }
}