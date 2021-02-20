namespace ReservationProject
{
    partial class ReservationView
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
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblReservationNumber = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBaseRate = new System.Windows.Forms.Label();
            this.lblChildNum = new System.Windows.Forms.Label();
            this.lblAdultNum = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReservation
            // 
            this.dgvReservation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Location = new System.Drawing.Point(18, 160);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.RowHeadersWidth = 51;
            this.dgvReservation.RowTemplate.Height = 24;
            this.dgvReservation.Size = new System.Drawing.Size(801, 248);
            this.dgvReservation.TabIndex = 0;
            this.dgvReservation.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvReservation_RowHeaderMouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(299, 101);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(120, 24);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSearch.Location = new System.Drawing.Point(441, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(122, 99);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(156, 24);
            this.cmbSearch.TabIndex = 3;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.CmbSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search By:";
            // 
            // dtpSearch
            // 
            this.dtpSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearch.Location = new System.Drawing.Point(299, 101);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(120, 24);
            this.dtpSearch.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(336, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "View Reservation";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkKhaki;
            this.statusStrip1.BackgroundImage = global::ReservationProject.Properties.Resources.rsz_ytwhja;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 731);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(886, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackgroundImage = global::ReservationProject.Properties.Resources.rsz_ytwhja;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripStatusLabel1.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 18);
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panelDetails.BackgroundImage = global::ReservationProject.Properties.Resources.rsz_ytwhja;
            this.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDetails.Controls.Add(this.lblCellPhone);
            this.panelDetails.Controls.Add(this.label18);
            this.panelDetails.Controls.Add(this.lblReservationNumber);
            this.panelDetails.Controls.Add(this.lblTotal);
            this.panelDetails.Controls.Add(this.lblBaseRate);
            this.panelDetails.Controls.Add(this.lblChildNum);
            this.panelDetails.Controls.Add(this.lblAdultNum);
            this.panelDetails.Controls.Add(this.lblRoomNumber);
            this.panelDetails.Controls.Add(this.lblRoomName);
            this.panelDetails.Controls.Add(this.lblCheckOut);
            this.panelDetails.Controls.Add(this.lblCheckIn);
            this.panelDetails.Controls.Add(this.lblDOB);
            this.panelDetails.Controls.Add(this.lblEmail);
            this.panelDetails.Controls.Add(this.lblHomePhone);
            this.panelDetails.Controls.Add(this.lblAddress);
            this.panelDetails.Controls.Add(this.lblLastName);
            this.panelDetails.Controls.Add(this.lblMiddleName);
            this.panelDetails.Controls.Add(this.lblFirstName);
            this.panelDetails.Controls.Add(this.label10);
            this.panelDetails.Controls.Add(this.label19);
            this.panelDetails.Controls.Add(this.label20);
            this.panelDetails.Controls.Add(this.label11);
            this.panelDetails.Controls.Add(this.label12);
            this.panelDetails.Controls.Add(this.label13);
            this.panelDetails.Controls.Add(this.label14);
            this.panelDetails.Controls.Add(this.label15);
            this.panelDetails.Controls.Add(this.label16);
            this.panelDetails.Controls.Add(this.label9);
            this.panelDetails.Controls.Add(this.label8);
            this.panelDetails.Controls.Add(this.label7);
            this.panelDetails.Controls.Add(this.label6);
            this.panelDetails.Controls.Add(this.label5);
            this.panelDetails.Controls.Add(this.label4);
            this.panelDetails.Controls.Add(this.label3);
            this.panelDetails.Location = new System.Drawing.Point(18, 497);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(844, 213);
            this.panelDetails.TabIndex = 8;
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCellPhone.Location = new System.Drawing.Point(117, 179);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(102, 17);
            this.lblCellPhone.TabIndex = 33;
            this.lblCellPhone.Text = "Home Number:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(32, 179);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 17);
            this.label18.TabIndex = 32;
            this.label18.Text = "Cell Number:";
            // 
            // lblReservationNumber
            // 
            this.lblReservationNumber.AutoSize = true;
            this.lblReservationNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReservationNumber.Location = new System.Drawing.Point(753, 147);
            this.lblReservationNumber.Name = "lblReservationNumber";
            this.lblReservationNumber.Size = new System.Drawing.Size(77, 17);
            this.lblReservationNumber.TabIndex = 31;
            this.lblReservationNumber.Text = "First Name:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Location = new System.Drawing.Point(752, 113);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 17);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "First Name:";
            // 
            // lblBaseRate
            // 
            this.lblBaseRate.AutoSize = true;
            this.lblBaseRate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBaseRate.Location = new System.Drawing.Point(752, 81);
            this.lblBaseRate.Name = "lblBaseRate";
            this.lblBaseRate.Size = new System.Drawing.Size(77, 17);
            this.lblBaseRate.TabIndex = 29;
            this.lblBaseRate.Text = "First Name:";
            // 
            // lblChildNum
            // 
            this.lblChildNum.AutoSize = true;
            this.lblChildNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChildNum.Location = new System.Drawing.Point(753, 46);
            this.lblChildNum.Name = "lblChildNum";
            this.lblChildNum.Size = new System.Drawing.Size(77, 17);
            this.lblChildNum.TabIndex = 28;
            this.lblChildNum.Text = "First Name:";
            // 
            // lblAdultNum
            // 
            this.lblAdultNum.AutoSize = true;
            this.lblAdultNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdultNum.Location = new System.Drawing.Point(753, 14);
            this.lblAdultNum.Name = "lblAdultNum";
            this.lblAdultNum.Size = new System.Drawing.Size(77, 17);
            this.lblAdultNum.TabIndex = 27;
            this.lblAdultNum.Text = "First Name:";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoomNumber.Location = new System.Drawing.Point(458, 179);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(77, 17);
            this.lblRoomNumber.TabIndex = 26;
            this.lblRoomNumber.Text = "First Name:";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoomName.Location = new System.Drawing.Point(452, 147);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(77, 17);
            this.lblRoomName.TabIndex = 25;
            this.lblRoomName.Text = "First Name:";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCheckOut.Location = new System.Drawing.Point(458, 109);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(77, 17);
            this.lblCheckOut.TabIndex = 24;
            this.lblCheckOut.Text = "First Name:";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCheckIn.Location = new System.Drawing.Point(458, 77);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(77, 17);
            this.lblCheckIn.TabIndex = 23;
            this.lblCheckIn.Text = "First Name:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDOB.Location = new System.Drawing.Point(458, 43);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(77, 17);
            this.lblDOB.TabIndex = 22;
            this.lblDOB.Text = "First Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(458, 14);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 17);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "First Name:";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHomePhone.Location = new System.Drawing.Point(125, 147);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(77, 17);
            this.lblHomePhone.TabIndex = 20;
            this.lblHomePhone.Text = "First Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddress.Location = new System.Drawing.Point(128, 109);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(77, 17);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLastName.Location = new System.Drawing.Point(128, 77);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(77, 17);
            this.lblLastName.TabIndex = 18;
            this.lblLastName.Text = "First Name:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMiddleName.Location = new System.Drawing.Point(128, 46);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(77, 17);
            this.lblMiddleName.TabIndex = 17;
            this.lblMiddleName.Text = "First Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFirstName.Location = new System.Drawing.Point(128, 14);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(77, 17);
            this.lblFirstName.TabIndex = 16;
            this.lblFirstName.Text = "First Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(606, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Reservation Number:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(635, 113);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 17);
            this.label19.TabIndex = 14;
            this.label19.Text = "Calculated Rate:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(670, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 17);
            this.label20.TabIndex = 13;
            this.label20.Text = "Base Rate:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(651, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Child Number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(650, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Adult Number:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(343, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Room Number:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(356, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 17);
            this.label14.TabIndex = 9;
            this.label14.Text = "Room Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(332, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Check-Out Date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(343, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "Check-In Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(349, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Date Of Birth:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(398, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(20, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Home Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(58, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(42, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(28, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Middle Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(41, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(294, 456);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(330, 38);
            this.label17.TabIndex = 9;
            this.label17.Text = "Reservation Details:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRefresh.Location = new System.Drawing.Point(522, 99);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(66, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // ReservationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImage = global::ReservationProject.Properties.Resources.rsz_ytwhja;
            this.ClientSize = new System.Drawing.Size(886, 753);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvReservation);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Name = "ReservationView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Reservation View";
            this.Load += new System.EventHandler(this.ReservationView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblReservationNumber;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBaseRate;
        private System.Windows.Forms.Label lblChildNum;
        private System.Windows.Forms.Label lblAdultNum;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnRefresh;
    }
}