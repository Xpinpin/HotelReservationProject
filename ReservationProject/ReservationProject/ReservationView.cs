using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationProject
{
    public partial class ReservationView : Form
    {
        Form1 myParent;
        public ReservationView(Form1 parent)
        {
            myParent = parent;
            InitializeComponent();
            dtpSearch.Visible = false;
            panelDetails.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void PopulateComboBoxSearchCriteria()
        {
            cmbSearch.Items.Add("");
            cmbSearch.Items.Add("Room Number");
            cmbSearch.Items.Add("Room Name");
            cmbSearch.Items.Add("Guest's Last Name");
            cmbSearch.Items.Add("Reservation Number");
            cmbSearch.Items.Add("Creation Date");
            cmbSearch.Items.Add("Check-In Date");
            cmbSearch.Items.Add("Check-Out Date");
            cmbSearch.SelectedIndex = 0;

        }

        private void GenerateDataGridView(SortableBindingList<ReservationViewDTO> reservations)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = reservations;
            dgvReservation.DataSource = bs;
         
            dgvReservation.ReadOnly = true;
            dgvReservation.AllowUserToAddRows = false;
            dgvReservation.DefaultCellStyle.BackColor = Color.MediumPurple;
            dgvReservation.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dgvReservation.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            dgvReservation.AllowUserToResizeColumns = false;
            dgvReservation.Columns[0].HeaderText = "Reservation Number";
            dgvReservation.Columns[1].HeaderText = "Check-In Date";
            dgvReservation.Columns[2].HeaderText = "Check-Out Date";
            dgvReservation.Columns[3].HeaderText = "Creation Date";
            dgvReservation.Columns[4].HeaderText = "Room Number";
            dgvReservation.Columns[5].HeaderText = "Room Name";
            dgvReservation.Columns[6].HeaderText = "Guest Name";
            dgvReservation.AutoResizeColumns();

         


        }

        private void ReservationView_Load(object sender, EventArgs e)
        {
            ReservationService service = new ReservationService();
            SortableBindingList<ReservationViewDTO> reservations = service.GetReservations();

            GenerateDataGridView(reservations);
            if (reservations.Count == 0)
            {
                toolStripStatusLabel1.Text = "There are no reservations to view.";
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
            else
            {
                toolStripStatusLabel1.Text = $"Total: {reservations.Count} reservation(s)";
                toolStripStatusLabel1.ForeColor = Color.White;

            }
            PopulateComboBoxSearchCriteria();

            #region Transparent Label
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            label16.BackColor = Color.Transparent;
            label17.BackColor = Color.Transparent;
            label18.BackColor = Color.Transparent;
            label19.BackColor = Color.Transparent;
            label20.BackColor = Color.Transparent;
            #endregion

            lblFirstName.BackColor = Color.Transparent;
            lblMiddleName.BackColor = Color.Transparent;
            lblLastName.BackColor = Color.Transparent;
            lblAddress.BackColor = Color.Transparent;
            lblHomePhone.BackColor = Color.Transparent;
            lblCellPhone.BackColor = Color.Transparent;
            lblEmail.BackColor = Color.Transparent;
            lblDOB.BackColor = Color.Transparent;
            lblCheckIn.BackColor = Color.Transparent;
            lblCheckOut.BackColor = Color.Transparent;
            lblRoomNumber.BackColor = Color.Transparent;
            lblRoomName.BackColor = Color.Transparent;
            lblAdultNum.BackColor = Color.Transparent;
            lblChildNum.BackColor = Color.Transparent;
            lblBaseRate.BackColor = Color.Transparent;
            lblTotal.BackColor = Color.Transparent;
            lblReservationNumber.BackColor = Color.Transparent;

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            panelDetails.Visible = false;

            if(cmbSearch.SelectedIndex == 0 && txtSearch.Text == "")
            {
                MessageBox.Show("There are no search criteria to be used.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            ReservationService service = new ReservationService();
            SortableBindingList<ReservationViewDTO> reservations = new SortableBindingList<ReservationViewDTO>();

            switch (cmbSearch.SelectedItem)
            {
                case "":
                    reservations = service.GetReservations();
                    txtSearch.Text = "";
                    dtpSearch.Value = DateTime.Now;
                    break;
                case "Room Number":
                    if (!int.TryParse(txtSearch.Text, out int s) && txtSearch.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter a room number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!int.TryParse(txtSearch.Text, out int a) && txtSearch.Text != string.Empty)
                    {
                        txtSearch.Text = "";
                        dtpSearch.Value = DateTime.Now;
                        MessageBox.Show("Please enter a valid number.", "Missing Information",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        return;
                    }
                
                    reservations = service.GetReservationsByRoomNumber(Convert.ToInt32(txtSearch.Text));

                    break;
                case "Room Name":
                    if(txtSearch.Text == "")
                    {
                        MessageBox.Show("Please enter a room name.", "Missing Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                    reservations = service.GetReservationsByRoomName(txtSearch.Text);
                    break;
                case "Guest's Last Name":
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Please enter the guest last name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    reservations = service.GetReservationByLastName(txtSearch.Text);
                    break;
                case "Reservation Number":
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Please enter a reservation number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    reservations = service.GetReservationByReservationNumber(txtSearch.Text);
                    break;
                case "Creation Date":
                    reservations = service.GetReservationByCreationDate(dtpSearch.Value);
                    break;
                case "Check-In Date":
                    reservations = service.GetReservationByCheckInDate(dtpSearch.Value);
                    break;
                case "Check-Out Date":
                    reservations = service.GetReservationByCheckOutDate(dtpSearch.Value);
                    break;

            }

            if (reservations.Count == 0)
            {
                txtSearch.Text = "";
                dtpSearch.Value = DateTime.Now;
                MessageBox.Show("There are no match records.");
                toolStripStatusLabel1.Text = $"Total: {reservations.Count} reservation(s)";
                toolStripStatusLabel1.ForeColor = Color.Red;
                dgvReservation.DataSource = null;
                return;
            }
            GenerateDataGridView(reservations);
            toolStripStatusLabel1.Text = $"Total: {reservations.Count} reservation(s)";
            toolStripStatusLabel1.ForeColor = Color.White;

        }

        private void CmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            ReservationService service = new ReservationService();

            switch (cmbSearch.SelectedItem)
            {
                case "":
                    txtSearch.Visible = true;
                    dtpSearch.Visible = false;
                    break;
                case "Room Number":
                    txtSearch.Visible = true;
                    dtpSearch.Visible = false;
                    break;
                case "Room Name":
                    txtSearch.Visible = true;
                    dtpSearch.Visible = false;
                    break;
                case "Guest's Last Name":
                    txtSearch.Visible = true;
                    dtpSearch.Visible = false;
                    break;
                case "Reservation Number":
                    txtSearch.Visible = true;
                    dtpSearch.Visible = false;
                    break;
                case "Creation Date":
                    txtSearch.Visible = false;
                    dtpSearch.Visible = true;
                    break;
                case "Check-In Date":
                    txtSearch.Visible = false;
                    dtpSearch.Visible = true;
                    break;
                case "Check-Out Date":
                    txtSearch.Visible = false;
                    dtpSearch.Visible = true;
                    break;

            }
            SortableBindingList<ReservationViewDTO> reservations = service.GetReservations();

            GenerateDataGridView(reservations);
            toolStripStatusLabel1.Text = $"Total: {reservations.Count} reservation(s)";
            toolStripStatusLabel1.ForeColor = Color.White;

            txtSearch.Text = string.Empty;
            
        }

        private void DgvReservation_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panelDetails.Visible = true;
            string reservationNumber = dgvReservation.SelectedRows[0].Cells[0].Value.ToString();

            ReservationService service = new ReservationService();
            ReservationDetailsDTO reservation = service.GetReservationDetails(reservationNumber);
            lblFirstName.Text = reservation.FirstName;
            lblMiddleName.Text = reservation.MiddleName;
            lblLastName.Text = reservation.LastName;
            lblAddress.Text = $"{reservation.StreetAddress}, {reservation.City}, \r\n" +
                                 $"{reservation.ProvinceAbbre}, {reservation.CountryName}," +
                                 $" {reservation.PostalCode}";
            lblHomePhone.Text = reservation.HomePhone.ToString();
            lblCellPhone.Text = reservation.CellPhone.ToString();
            lblEmail.Text = reservation.Email.ToString();
            lblDOB.Text = reservation.DateOfBirth.ToShortDateString();
            lblCheckIn.Text = reservation.CheckInDate.ToShortDateString();
            lblCheckOut.Text = reservation.CheckOutDate.ToShortDateString();
            lblRoomName.Text = reservation.RoomName.ToString();
            lblRoomNumber.Text = reservation.RoomNumber.ToString();
            lblAdultNum.Text = reservation.AdultNumber.ToString();
            lblChildNum.Text = reservation.ChildNumber.ToString();
            lblBaseRate.Text = reservation.BaseRate.ToString("C");
            lblTotal.Text = reservation.Total.ToString("C");
            lblReservationNumber.Text = reservation.ReservationNumber.ToString();

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ReservationService service = new ReservationService();
            SortableBindingList<ReservationViewDTO> reservations = service.GetReservations();
            GenerateDataGridView(reservations);
            toolStripStatusLabel1.Text = $"Total: {reservations.Count} reservation(s)";
            toolStripStatusLabel1.ForeColor = Color.White;
            cmbSearch.SelectedIndex = 0;
            panelDetails.Visible = false;

        }

     
    }
}
