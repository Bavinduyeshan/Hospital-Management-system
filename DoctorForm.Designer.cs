namespace HMS
{
    partial class DoctorForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgtDoctorlist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmbgender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbdoc_id = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblDocid = new System.Windows.Forms.Label();
            this.lblcontno = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblspecialization = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.dtbdoc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.txtcontNo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtspecialization = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNIC = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtLname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtFname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtDoctorlist)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.Controls.Add(this.dgtDoctorlist);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(981, 113);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(767, 895);
            this.guna2GroupBox2.TabIndex = 24;
            this.guna2GroupBox2.Text = "Doctor Data";
            // 
            // dgtDoctorlist
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgtDoctorlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgtDoctorlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtDoctorlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgtDoctorlist.ColumnHeadersHeight = 4;
            this.dgtDoctorlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtDoctorlist.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgtDoctorlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgtDoctorlist.Location = new System.Drawing.Point(18, 46);
            this.dgtDoctorlist.Name = "dgtDoctorlist";
            this.dgtDoctorlist.RowHeadersVisible = false;
            this.dgtDoctorlist.RowHeadersWidth = 51;
            this.dgtDoctorlist.RowTemplate.Height = 24;
            this.dgtDoctorlist.Size = new System.Drawing.Size(712, 282);
            this.dgtDoctorlist.TabIndex = 2;
            this.dgtDoctorlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgtDoctorlist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgtDoctorlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgtDoctorlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgtDoctorlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgtDoctorlist.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.dgtDoctorlist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgtDoctorlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgtDoctorlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgtDoctorlist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgtDoctorlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgtDoctorlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgtDoctorlist.ThemeStyle.HeaderStyle.Height = 4;
            this.dgtDoctorlist.ThemeStyle.ReadOnly = false;
            this.dgtDoctorlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgtDoctorlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgtDoctorlist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgtDoctorlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.dgtDoctorlist.ThemeStyle.RowsStyle.Height = 24;
            this.dgtDoctorlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgtDoctorlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgtDoctorlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtDoctorlist_CellContentClick);
            // 
            // cmbgender
            // 
            this.cmbgender.BackColor = System.Drawing.Color.Transparent;
            this.cmbgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbgender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbgender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbgender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbgender.ItemHeight = 30;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(284, 393);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(283, 36);
            this.cmbgender.TabIndex = 35;
            // 
            // cmbdoc_id
            // 
            this.cmbdoc_id.BackColor = System.Drawing.Color.Transparent;
            this.cmbdoc_id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbdoc_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdoc_id.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbdoc_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbdoc_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbdoc_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbdoc_id.ItemHeight = 30;
            this.cmbdoc_id.Location = new System.Drawing.Point(284, 62);
            this.cmbdoc_id.Name = "cmbdoc_id";
            this.cmbdoc_id.Size = new System.Drawing.Size(283, 36);
            this.cmbdoc_id.TabIndex = 32;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.lblDocid);
            this.guna2GroupBox1.Controls.Add(this.cmbgender);
            this.guna2GroupBox1.Controls.Add(this.cmbdoc_id);
            this.guna2GroupBox1.Controls.Add(this.lblcontno);
            this.guna2GroupBox1.Controls.Add(this.lblemail);
            this.guna2GroupBox1.Controls.Add(this.lblspecialization);
            this.guna2GroupBox1.Controls.Add(this.lblgender);
            this.guna2GroupBox1.Controls.Add(this.dtbdoc);
            this.guna2GroupBox1.Controls.Add(this.lbldob);
            this.guna2GroupBox1.Controls.Add(this.lblAddress);
            this.guna2GroupBox1.Controls.Add(this.lblNic);
            this.guna2GroupBox1.Controls.Add(this.lblLname);
            this.guna2GroupBox1.Controls.Add(this.lblFname);
            this.guna2GroupBox1.Controls.Add(this.txtcontNo);
            this.guna2GroupBox1.Controls.Add(this.txtEmail);
            this.guna2GroupBox1.Controls.Add(this.txtspecialization);
            this.guna2GroupBox1.Controls.Add(this.txtAddress);
            this.guna2GroupBox1.Controls.Add(this.txtNIC);
            this.guna2GroupBox1.Controls.Add(this.txtLname);
            this.guna2GroupBox1.Controls.Add(this.txtFname);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(283, 113);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(640, 895);
            this.guna2GroupBox1.TabIndex = 23;
            this.guna2GroupBox1.Text = "Doctor Data";
            // 
            // lblDocid
            // 
            this.lblDocid.AutoSize = true;
            this.lblDocid.BackColor = System.Drawing.Color.White;
            this.lblDocid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lblDocid.Location = new System.Drawing.Point(53, 62);
            this.lblDocid.Name = "lblDocid";
            this.lblDocid.Size = new System.Drawing.Size(104, 28);
            this.lblDocid.TabIndex = 36;
            this.lblDocid.Text = "Doctor ID";
            // 
            // lblcontno
            // 
            this.lblcontno.AutoSize = true;
            this.lblcontno.BackColor = System.Drawing.Color.White;
            this.lblcontno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lblcontno.Location = new System.Drawing.Point(57, 645);
            this.lblcontno.Name = "lblcontno";
            this.lblcontno.Size = new System.Drawing.Size(119, 28);
            this.lblcontno.TabIndex = 30;
            this.lblcontno.Text = "Contact No";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.White;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lblemail.Location = new System.Drawing.Point(61, 581);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(64, 28);
            this.lblemail.TabIndex = 29;
            this.lblemail.Text = "Email";
            // 
            // lblspecialization
            // 
            this.lblspecialization.AutoSize = true;
            this.lblspecialization.BackColor = System.Drawing.Color.White;
            this.lblspecialization.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspecialization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lblspecialization.Location = new System.Drawing.Point(56, 522);
            this.lblspecialization.Name = "lblspecialization";
            this.lblspecialization.Size = new System.Drawing.Size(144, 28);
            this.lblspecialization.TabIndex = 27;
            this.lblspecialization.Text = "Specialization";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.White;
            this.lblgender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lblgender.Location = new System.Drawing.Point(56, 393);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(80, 28);
            this.lblgender.TabIndex = 24;
            this.lblgender.Text = "Gender";
            // 
            // dtbdoc
            // 
            this.dtbdoc.Checked = true;
            this.dtbdoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(220)))), ((int)(((byte)(243)))));
            this.dtbdoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtbdoc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtbdoc.Location = new System.Drawing.Point(284, 328);
            this.dtbdoc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtbdoc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtbdoc.Name = "dtbdoc";
            this.dtbdoc.Size = new System.Drawing.Size(283, 36);
            this.dtbdoc.TabIndex = 23;
            this.dtbdoc.Value = new System.DateTime(2024, 11, 10, 21, 39, 23, 97);
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.BackColor = System.Drawing.Color.White;
            this.lbldob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lbldob.Location = new System.Drawing.Point(56, 328);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(55, 28);
            this.lbldob.TabIndex = 22;
            this.lbldob.Text = "DOB";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.White;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lblAddress.Location = new System.Drawing.Point(53, 448);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(87, 28);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "Address";
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.BackColor = System.Drawing.Color.White;
            this.lblNic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lblNic.Location = new System.Drawing.Point(56, 265);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(46, 28);
            this.lblNic.TabIndex = 20;
            this.lblNic.Text = "NIC";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.BackColor = System.Drawing.Color.White;
            this.lblLname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lblLname.Location = new System.Drawing.Point(53, 184);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(112, 28);
            this.lblLname.TabIndex = 19;
            this.lblLname.Text = "Last Name";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.BackColor = System.Drawing.Color.White;
            this.lblFname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lblFname.Location = new System.Drawing.Point(53, 122);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(115, 28);
            this.lblFname.TabIndex = 18;
            this.lblFname.Text = "First Name";
            // 
            // txtcontNo
            // 
            this.txtcontNo.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtcontNo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcontNo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtcontNo.BorderThickness = 3;
            this.txtcontNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcontNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcontNo.isPassword = false;
            this.txtcontNo.Location = new System.Drawing.Point(284, 645);
            this.txtcontNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontNo.Name = "txtcontNo";
            this.txtcontNo.Size = new System.Drawing.Size(283, 44);
            this.txtcontNo.TabIndex = 17;
            this.txtcontNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtEmail.BorderThickness = 3;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(284, 581);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(283, 44);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtspecialization
            // 
            this.txtspecialization.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtspecialization.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtspecialization.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtspecialization.BorderThickness = 3;
            this.txtspecialization.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtspecialization.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtspecialization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtspecialization.isPassword = false;
            this.txtspecialization.Location = new System.Drawing.Point(284, 506);
            this.txtspecialization.Margin = new System.Windows.Forms.Padding(4);
            this.txtspecialization.Name = "txtspecialization";
            this.txtspecialization.Size = new System.Drawing.Size(283, 44);
            this.txtspecialization.TabIndex = 14;
            this.txtspecialization.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAddress.BorderThickness = 3;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.isPassword = false;
            this.txtAddress.Location = new System.Drawing.Point(284, 436);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(283, 44);
            this.txtAddress.TabIndex = 13;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNIC
            // 
            this.txtNIC.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtNIC.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNIC.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtNIC.BorderThickness = 3;
            this.txtNIC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNIC.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNIC.isPassword = false;
            this.txtNIC.Location = new System.Drawing.Point(284, 265);
            this.txtNIC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(283, 44);
            this.txtNIC.TabIndex = 12;
            this.txtNIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLname
            // 
            this.txtLname.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtLname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLname.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtLname.BorderThickness = 3;
            this.txtLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLname.isPassword = false;
            this.txtLname.Location = new System.Drawing.Point(284, 184);
            this.txtLname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(283, 44);
            this.txtLname.TabIndex = 11;
            this.txtLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFname
            // 
            this.txtFname.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtFname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFname.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtFname.BorderThickness = 3;
            this.txtFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFname.isPassword = false;
            this.txtFname.Location = new System.Drawing.Point(284, 122);
            this.txtFname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(283, 44);
            this.txtFname.TabIndex = 10;
            this.txtFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1856, 65);
            this.guna2Panel1.TabIndex = 21;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1856, 63);
            this.guna2Panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(90, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Unity Health Care     ";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(81, 63);
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(931, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doctors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(396, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.guna2Panel2.Controls.Add(this.btnExit);
            this.guna2Panel2.Controls.Add(this.btnHome);
            this.guna2Panel2.Controls.Add(this.btnclear);
            this.guna2Panel2.Controls.Add(this.btnDel);
            this.guna2Panel2.Controls.Add(this.btnupdate);
            this.guna2Panel2.Controls.Add(this.btnAdd);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 65);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(223, 1037);
            this.guna2Panel2.TabIndex = 25;
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
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.btnExit.Location = new System.Drawing.Point(28, 597);
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
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.btnHome.Location = new System.Drawing.Point(28, 484);
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
            this.btnclear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.btnclear.Location = new System.Drawing.Point(29, 376);
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
            this.btnDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.btnDel.Location = new System.Drawing.Point(28, 278);
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
            this.btnupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.btnupdate.Location = new System.Drawing.Point(27, 169);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(169, 45);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.btnAdd.Location = new System.Drawing.Point(28, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1856, 1102);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtDoctorlist)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgtDoctorlist;
        private Guna.UI2.WinForms.Guna2ComboBox cmbgender;
        private Guna.UI2.WinForms.Guna2ComboBox cmbdoc_id;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblcontno;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblspecialization;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtcontNo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtspecialization;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAddress;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLname;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFname;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnclear;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label lblDocid;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtbdoc;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblNic;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNIC;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label label3;
    }
}