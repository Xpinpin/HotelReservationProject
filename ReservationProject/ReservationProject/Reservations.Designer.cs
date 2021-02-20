namespace ReservationProject
{
    partial class Reservations
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.grpRoomSelection = new System.Windows.Forms.GroupBox();
            this.btnSearchRooms = new System.Windows.Forms.Button();
            this.btnRoomSelected = new System.Windows.Forms.Button();
            this.cmbAvailableRooms = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnCusInfo = new System.Windows.Forms.Button();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpPeople = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSaveReservation = new System.Windows.Forms.Button();
            this.txtChildNum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAdultNum = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpRoomDetails = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtMaxOccupancy = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBaseRate = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtBedNum = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.grpRoomSelection.SuspendLayout();
            this.grpCustomerInfo.SuspendLayout();
            this.grpPeople.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpRoomDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Reservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(149, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date:";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(19, 75);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(100, 24);
            this.dtpStart.TabIndex = 3;
            this.dtpStart.ValueChanged += new System.EventHandler(this.DtpStart_ValueChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(153, 75);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(96, 24);
            this.dtpEnd.TabIndex = 4;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.DtpEnd_ValueChanged);
            // 
            // grpRoomSelection
            // 
            this.grpRoomSelection.BackgroundImage = global::ReservationProject.Properties.Resources.rsz_ytwhja;
            this.grpRoomSelection.Controls.Add(this.btnSearchRooms);
            this.grpRoomSelection.Controls.Add(this.btnRoomSelected);
            this.grpRoomSelection.Controls.Add(this.cmbAvailableRooms);
            this.grpRoomSelection.Controls.Add(this.label4);
            this.grpRoomSelection.Controls.Add(this.label3);
            this.grpRoomSelection.Controls.Add(this.dtpEnd);
            this.grpRoomSelection.Controls.Add(this.label2);
            this.grpRoomSelection.Controls.Add(this.dtpStart);
            this.grpRoomSelection.ForeColor = System.Drawing.Color.Peru;
            this.grpRoomSelection.Location = new System.Drawing.Point(106, 73);
            this.grpRoomSelection.Name = "grpRoomSelection";
            this.grpRoomSelection.Size = new System.Drawing.Size(301, 239);
            this.grpRoomSelection.TabIndex = 5;
            this.grpRoomSelection.TabStop = false;
            this.grpRoomSelection.Text = "Room Selection:";
            // 
            // btnSearchRooms
            // 
            this.btnSearchRooms.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSearchRooms.Location = new System.Drawing.Point(206, 124);
            this.btnSearchRooms.Name = "btnSearchRooms";
            this.btnSearchRooms.Size = new System.Drawing.Size(77, 41);
            this.btnSearchRooms.TabIndex = 8;
            this.btnSearchRooms.Text = "Search";
            this.btnSearchRooms.UseVisualStyleBackColor = true;
            this.btnSearchRooms.Click += new System.EventHandler(this.BtnSearchRooms_Click);
            // 
            // btnRoomSelected
            // 
            this.btnRoomSelected.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRoomSelected.Location = new System.Drawing.Point(206, 180);
            this.btnRoomSelected.Name = "btnRoomSelected";
            this.btnRoomSelected.Size = new System.Drawing.Size(77, 41);
            this.btnRoomSelected.TabIndex = 7;
            this.btnRoomSelected.Text = "Continue";
            this.btnRoomSelected.UseVisualStyleBackColor = true;
            this.btnRoomSelected.Click += new System.EventHandler(this.BtnRoomSelected_Click);
            // 
            // cmbAvailableRooms
            // 
            this.cmbAvailableRooms.FormattingEnabled = true;
            this.cmbAvailableRooms.Location = new System.Drawing.Point(19, 173);
            this.cmbAvailableRooms.Name = "cmbAvailableRooms";
            this.cmbAvailableRooms.Size = new System.Drawing.Size(154, 24);
            this.cmbAvailableRooms.TabIndex = 6;
            this.cmbAvailableRooms.SelectedIndexChanged += new System.EventHandler(this.cmbAvailableRooms_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Available Rooms:";
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.BackgroundImage = global::ReservationProject.Properties.Resources.rsz_ytwhja;
            this.grpCustomerInfo.Controls.Add(this.cmbCountry);
            this.grpCustomerInfo.Controls.Add(this.label18);
            this.grpCustomerInfo.Controls.Add(this.btnCusInfo);
            this.grpCustomerInfo.Controls.Add(this.cmbProvince);
            this.grpCustomerInfo.Controls.Add(this.dtpDOB);
            this.grpCustomerInfo.Controls.Add(this.txtCity);
            this.grpCustomerInfo.Controls.Add(this.label9);
            this.grpCustomerInfo.Controls.Add(this.label15);
            this.grpCustomerInfo.Controls.Add(this.txtEmail);
            this.grpCustomerInfo.Controls.Add(this.label14);
            this.grpCustomerInfo.Controls.Add(this.txtCellPhone);
            this.grpCustomerInfo.Controls.Add(this.label13);
            this.grpCustomerInfo.Controls.Add(this.txtHomePhone);
            this.grpCustomerInfo.Controls.Add(this.label12);
            this.grpCustomerInfo.Controls.Add(this.txtPostalCode);
            this.grpCustomerInfo.Controls.Add(this.label11);
            this.grpCustomerInfo.Controls.Add(this.label10);
            this.grpCustomerInfo.Controls.Add(this.txtAddress);
            this.grpCustomerInfo.Controls.Add(this.label8);
            this.grpCustomerInfo.Controls.Add(this.txtLastName);
            this.grpCustomerInfo.Controls.Add(this.label7);
            this.grpCustomerInfo.Controls.Add(this.txtMiddleName);
            this.grpCustomerInfo.Controls.Add(this.label6);
            this.grpCustomerInfo.Controls.Add(this.txtFirstName);
            this.grpCustomerInfo.Controls.Add(this.label5);
            this.grpCustomerInfo.ForeColor = System.Drawing.Color.Peru;
            this.grpCustomerInfo.Location = new System.Drawing.Point(487, 73);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(376, 429);
            this.grpCustomerInfo.TabIndex = 6;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer Information:";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(110, 163);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(166, 24);
            this.cmbCountry.TabIndex = 5;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.CmbCountry_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Khaki;
            this.label18.ForeColor = System.Drawing.Color.Snow;
            this.label18.Location = new System.Drawing.Point(44, 163);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 17);
            this.label18.TabIndex = 22;
            this.label18.Text = "Country:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCusInfo
            // 
            this.btnCusInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCusInfo.Location = new System.Drawing.Point(285, 364);
            this.btnCusInfo.Name = "btnCusInfo";
            this.btnCusInfo.Size = new System.Drawing.Size(77, 43);
            this.btnCusInfo.TabIndex = 13;
            this.btnCusInfo.Text = "Continue";
            this.btnCusInfo.UseVisualStyleBackColor = true;
            this.btnCusInfo.Click += new System.EventHandler(this.BtnCusInfo_Click);
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(110, 195);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(166, 24);
            this.cmbProvince.TabIndex = 6;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(110, 379);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(140, 24);
            this.dtpDOB.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(110, 228);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(166, 24);
            this.txtCity.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Khaki;
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(66, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "City:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Khaki;
            this.label15.ForeColor = System.Drawing.Color.Snow;
            this.label15.Location = new System.Drawing.Point(15, 381);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "Date Of Birth:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 349);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 24);
            this.txtEmail.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Khaki;
            this.label14.ForeColor = System.Drawing.Color.Snow;
            this.label14.Location = new System.Drawing.Point(57, 349);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "Email:";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(110, 319);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(166, 24);
            this.txtCellPhone.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Khaki;
            this.label13.ForeColor = System.Drawing.Color.Snow;
            this.label13.Location = new System.Drawing.Point(27, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Cell Phone:";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(110, 288);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(166, 24);
            this.txtHomePhone.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Khaki;
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(15, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Home Phone:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(110, 258);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(166, 24);
            this.txtPostalCode.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Khaki;
            this.label11.ForeColor = System.Drawing.Color.Snow;
            this.label11.Location = new System.Drawing.Point(20, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Postal Code:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Khaki;
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(38, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Province:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(110, 132);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(166, 24);
            this.txtAddress.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Khaki;
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(4, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Street Address:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(110, 102);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(166, 24);
            this.txtLastName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Khaki;
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(27, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Last Name:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(110, 72);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(166, 24);
            this.txtMiddleName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(15, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Middle Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(110, 41);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(166, 24);
            this.txtFirstName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(27, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "First Name:";
            // 
            // grpPeople
            // 
            this.grpPeople.BackgroundImage = global::ReservationProject.Properties.Resources.rsz_ytwhja;
            this.grpPeople.Controls.Add(this.btnRefresh);
            this.grpPeople.Controls.Add(this.btnSaveReservation);
            this.grpPeople.Controls.Add(this.txtChildNum);
            this.grpPeople.Controls.Add(this.label17);
            this.grpPeople.Controls.Add(this.txtAdultNum);
            this.grpPeople.Controls.Add(this.label16);
            this.grpPeople.ForeColor = System.Drawing.Color.Peru;
            this.grpPeople.Location = new System.Drawing.Point(487, 525);
            this.grpPeople.Name = "grpPeople";
            this.grpPeople.Size = new System.Drawing.Size(362, 183);
            this.grpPeople.TabIndex = 7;
            this.grpPeople.TabStop = false;
            this.grpPeople.Text = "Participants:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRefresh.Location = new System.Drawing.Point(264, 119);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 43);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSaveReservation
            // 
            this.btnSaveReservation.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSaveReservation.Location = new System.Drawing.Point(18, 119);
            this.btnSaveReservation.Name = "btnSaveReservation";
            this.btnSaveReservation.Size = new System.Drawing.Size(220, 43);
            this.btnSaveReservation.TabIndex = 16;
            this.btnSaveReservation.Text = "CREATE RESERVATION";
            this.btnSaveReservation.UseVisualStyleBackColor = true;
            this.btnSaveReservation.Click += new System.EventHandler(this.BtnSaveReservation_Click);
            // 
            // txtChildNum
            // 
            this.txtChildNum.Location = new System.Drawing.Point(65, 65);
            this.txtChildNum.Name = "txtChildNum";
            this.txtChildNum.Size = new System.Drawing.Size(103, 24);
            this.txtChildNum.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Khaki;
            this.label17.ForeColor = System.Drawing.Color.Snow;
            this.label17.Location = new System.Drawing.Point(15, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "Child:";
            // 
            // txtAdultNum
            // 
            this.txtAdultNum.Location = new System.Drawing.Point(65, 38);
            this.txtAdultNum.Name = "txtAdultNum";
            this.txtAdultNum.Size = new System.Drawing.Size(103, 24);
            this.txtAdultNum.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Khaki;
            this.label16.ForeColor = System.Drawing.Color.Snow;
            this.label16.Location = new System.Drawing.Point(15, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 17);
            this.label16.TabIndex = 22;
            this.label16.Text = "Adult:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkKhaki;
            this.statusStrip1.BackgroundImage = global::ReservationProject.Properties.Resources.rsz_ytwhja;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 733);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(886, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackgroundImage = global::ReservationProject.Properties.Resources.rsz_ytwhja;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 18);
            // 
            // grpRoomDetails
            // 
            this.grpRoomDetails.BackgroundImage = global::ReservationProject.Properties.Resources.rsz_ytwhja;
            this.grpRoomDetails.Controls.Add(this.txtType);
            this.grpRoomDetails.Controls.Add(this.txtMaxOccupancy);
            this.grpRoomDetails.Controls.Add(this.label22);
            this.grpRoomDetails.Controls.Add(this.label23);
            this.grpRoomDetails.Controls.Add(this.txtBaseRate);
            this.grpRoomDetails.Controls.Add(this.label24);
            this.grpRoomDetails.Controls.Add(this.txtBedNum);
            this.grpRoomDetails.Controls.Add(this.txtRoomNumber);
            this.grpRoomDetails.Controls.Add(this.label19);
            this.grpRoomDetails.Controls.Add(this.label21);
            this.grpRoomDetails.Controls.Add(this.txtRoomName);
            this.grpRoomDetails.Controls.Add(this.label20);
            this.grpRoomDetails.ForeColor = System.Drawing.Color.Peru;
            this.grpRoomDetails.Location = new System.Drawing.Point(106, 333);
            this.grpRoomDetails.Name = "grpRoomDetails";
            this.grpRoomDetails.Size = new System.Drawing.Size(364, 254);
            this.grpRoomDetails.TabIndex = 9;
            this.grpRoomDetails.TabStop = false;
            this.grpRoomDetails.Text = "Room Details";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(167, 201);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(166, 24);
            this.txtType.TabIndex = 33;
            // 
            // txtMaxOccupancy
            // 
            this.txtMaxOccupancy.Location = new System.Drawing.Point(167, 140);
            this.txtMaxOccupancy.Name = "txtMaxOccupancy";
            this.txtMaxOccupancy.Size = new System.Drawing.Size(166, 24);
            this.txtMaxOccupancy.TabIndex = 30;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Khaki;
            this.label22.ForeColor = System.Drawing.Color.Snow;
            this.label22.Location = new System.Drawing.Point(17, 201);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 17);
            this.label22.TabIndex = 34;
            this.label22.Text = "Type:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Khaki;
            this.label23.ForeColor = System.Drawing.Color.Snow;
            this.label23.Location = new System.Drawing.Point(17, 140);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(146, 17);
            this.label23.TabIndex = 29;
            this.label23.Text = "Maximum Occupancy:";
            // 
            // txtBaseRate
            // 
            this.txtBaseRate.Location = new System.Drawing.Point(167, 171);
            this.txtBaseRate.Name = "txtBaseRate";
            this.txtBaseRate.Size = new System.Drawing.Size(166, 24);
            this.txtBaseRate.TabIndex = 31;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Khaki;
            this.label24.ForeColor = System.Drawing.Color.Snow;
            this.label24.Location = new System.Drawing.Point(17, 171);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 17);
            this.label24.TabIndex = 32;
            this.label24.Text = "Base Rate:";
            // 
            // txtBedNum
            // 
            this.txtBedNum.Location = new System.Drawing.Point(167, 107);
            this.txtBedNum.Name = "txtBedNum";
            this.txtBedNum.Size = new System.Drawing.Size(166, 24);
            this.txtBedNum.TabIndex = 27;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(167, 46);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(166, 24);
            this.txtRoomNumber.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Khaki;
            this.label19.ForeColor = System.Drawing.Color.Snow;
            this.label19.Location = new System.Drawing.Point(17, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 17);
            this.label19.TabIndex = 28;
            this.label19.Text = "Number Of Beds:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Khaki;
            this.label21.ForeColor = System.Drawing.Color.Snow;
            this.label21.Location = new System.Drawing.Point(17, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 17);
            this.label21.TabIndex = 23;
            this.label21.Text = "Room Number:";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(167, 77);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(166, 24);
            this.txtRoomName.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Khaki;
            this.label20.ForeColor = System.Drawing.Color.Snow;
            this.label20.Location = new System.Drawing.Point(17, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 17);
            this.label20.TabIndex = 26;
            this.label20.Text = "Room Name:";
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImage = global::ReservationProject.Properties.Resources.rsz_ytwhja;
            this.ClientSize = new System.Drawing.Size(886, 755);
            this.Controls.Add(this.grpRoomDetails);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpPeople);
            this.Controls.Add(this.grpCustomerInfo);
            this.Controls.Add(this.grpRoomSelection);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.Reservations_Load);
            this.grpRoomSelection.ResumeLayout(false);
            this.grpRoomSelection.PerformLayout();
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpPeople.ResumeLayout(false);
            this.grpPeople.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpRoomDetails.ResumeLayout(false);
            this.grpRoomDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.GroupBox grpRoomSelection;
        private System.Windows.Forms.ComboBox cmbAvailableRooms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRoomSelected;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.Button btnCusInfo;
        private System.Windows.Forms.GroupBox grpPeople;
        private System.Windows.Forms.Button btnSaveReservation;
        private System.Windows.Forms.TextBox txtChildNum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAdultNum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnSearchRooms;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox grpRoomDetails;
        private System.Windows.Forms.TextBox txtBedNum;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtMaxOccupancy;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtBaseRate;
        private System.Windows.Forms.Label label24;
    }
}