using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
namespace ReservationProject
{
    public partial class Reservations : Form
    {
        Form1 myParent;

        public Reservations(Form1 parent)
        {
            myParent = parent;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        #region Private Helpers
        private bool ValidLength(string value, int length)
        {
            if (value.Length > length)
            {
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            txtFirstName.Text = String.Empty;
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            cmbCountry.SelectedIndex = -1;
            cmbProvince.SelectedIndex = -1;
            txtCity.Text = "";
            txtPostalCode.Text = "";
            txtHomePhone.Text = "";
            txtCellPhone.Text = "";
            txtEmail.Text = "";
            dtpDOB.Value = DateTime.Now;
            txtAdultNum.Text = "";
            txtChildNum.Text = "";
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            grpRoomSelection.Enabled = true;
            grpCustomerInfo.Enabled = true;
            txtAdultNum.Enabled = true;
            txtChildNum.Enabled = true;
            btnSaveReservation.Enabled = true;
            grpCustomerInfo.Visible = false;
            grpPeople.Visible = false;
            btnRefresh.Visible = false;
            toolStripStatusLabel1.Text = "";
        }

        private void DisabledForm()
        {
            grpCustomerInfo.Enabled = false;
            txtAdultNum.Enabled = false;
            txtChildNum.Enabled = false;
            btnSaveReservation.Enabled = false;
            btnRefresh.Visible = true;
            grpRoomSelection.Enabled = false;
        }

        private string ValidateForm()
        {
            string errMsg = string.Empty;
            if (txtFirstName.Text == string.Empty || !ValidLength(txtFirstName.Text, 30))
            {
                errMsg = errMsg + Environment.NewLine + "First name can not be blank or over 30 characters";
            }

            if (txtLastName.Text == string.Empty || !ValidLength(txtLastName.Text, 30))
            {
                errMsg = errMsg + Environment.NewLine + "Last name can not be blank or over 30 characters";
            }


            if (txtAddress.Text == string.Empty || !ValidLength(txtAddress.Text, 30))
            {
                errMsg = errMsg + Environment.NewLine + "Address can not be blank or over 30 characters";
            }


            if (txtCity.Text == string.Empty || !ValidLength(txtCity.Text, 20))
            {
                errMsg = errMsg + Environment.NewLine + "City can not be blank or over 20 characters";
            }

            if (txtPostalCode.Text == string.Empty || !ValidLength(txtPostalCode.Text, 7))
            {
                errMsg = errMsg + Environment.NewLine + "Postal code can not be blank or over 7 characters";
            }

            if (txtCellPhone.Text == string.Empty && txtHomePhone.Text == string.Empty)
            {
                errMsg = errMsg + Environment.NewLine + "A phone number is required";
            }
            if (!ValidLength(txtCellPhone.Text, 15) || !ValidLength(txtHomePhone.Text, 15))
            {
                errMsg = errMsg + Environment.NewLine + "Phone number can not be over 15 characters";
            }
            if (cmbProvince.SelectedIndex <= 0)
            {
                errMsg = errMsg + Environment.NewLine + "Province is required.";
            }
            if(cmbCountry.SelectedIndex <= 0)
            {
                errMsg = errMsg + Environment.NewLine + "Country is required.";
            }
            if(!int.TryParse(txtAdultNum.Text, out int s))
            {
                errMsg = errMsg + Environment.NewLine + "The adult number must be a valid number.";
            }
            if(!int.TryParse(txtChildNum.Text, out int a))
            {
                errMsg = errMsg + Environment.NewLine + "The child number must be a valid number.";
            }
            if(cmbAvailableRooms.SelectedIndex == 0)
            {
                errMsg = errMsg + Environment.NewLine + "You must choose a room.";
            }

            return errMsg;
        }

        #endregion

        #region Application Methods
        private void LoadProvinces(int countryId)
        {
            LookupService service = new LookupService();
            List<ProvinceDTO> provinces = service.GetAllProvinces(countryId);
            provinces.Insert(0, new ProvinceDTO { ProvinceId = 0, ProvinceName = "" });

            cmbProvince.DataSource = provinces;
            cmbProvince.DisplayMember = "ProvinceName";
            cmbProvince.ValueMember = "ProvinceId";
            cmbProvince.SelectedIndex = -1;

        }

        private void LoadCountries()
        {
            LookupService service = new LookupService();
            List<CountryDTO> countries = service.GetAllCountries();
            countries.Insert(0, new CountryDTO { CountryId = 0, CountryName = "---Select a country---" });

            cmbCountry.DataSource = countries;
            cmbCountry.DisplayMember = "CountryName";
            cmbCountry.ValueMember = "CountryId";
            cmbCountry.SelectedIndex = -1;
        }

        private void LoadRooms()
        {
            LookupService service = new LookupService();
            List<RoomDTO> rooms = service.GetRooms();
            rooms.Insert(0, new RoomDTO { RoomId = 0, RoomName = "" });
            cmbAvailableRooms.DataSource = rooms;
            cmbAvailableRooms.DisplayMember = "RoomName";
            cmbAvailableRooms.ValueMember = "RoomId";
            cmbAvailableRooms.SelectedIndex = -1;
        }

        private void LoadAvailableRooms()
        {
            LookupService service = new LookupService();
            List<RoomDTO> rooms = service.GetAvailableRooms(dtpStart.Value,dtpEnd.Value);
            if(rooms.Count == 0)
            {
                MessageBox.Show("There are no rooms at this time. Please try another time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbAvailableRooms.Enabled = false;
                btnRoomSelected.Enabled = false;
                cmbAvailableRooms.SelectedIndex = 0;
                return;
            }
            rooms.Insert(0, new RoomDTO { RoomId = 0, RoomName = "" });
            cmbAvailableRooms.DataSource = rooms;
            cmbAvailableRooms.DisplayMember = "RoomName";
            cmbAvailableRooms.ValueMember = "RoomId";
            cmbAvailableRooms.SelectedIndex = -1;
        }

        private Guest PopulateGuestObject()
        {
            return new Guest
            {
                FirstName = txtFirstName.Text.Trim(),
                MiddleName = txtMiddleName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                StreetAddress = txtAddress.Text.Trim(),
                City = txtCity.Text.Trim(),
                CountryId = Convert.ToInt32(cmbCountry.SelectedValue),
                ProvinceId = Convert.ToInt32(cmbProvince.SelectedValue),
                PostalCode = txtPostalCode.Text.Trim(),
                HomePhone = txtHomePhone.Text.Trim(),
                CellPhone = txtCellPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                DateOfBirth = dtpDOB.Value

            };
        }

        private Reservation PopulateReservationObject()
        {

            ReservationService reservationService = new ReservationService();
            return new Reservation
            {
                ReservationNumber = reservationService.GenerateLastReservationNumber(),
                CheckInDate = dtpStart.Value,
                CheckOutDate = dtpEnd.Value,
                AdultNumber = Convert.ToInt32(txtAdultNum.Text),
                ChildNumber = Convert.ToInt32(txtChildNum.Text),
                CreationDate = DateTime.Now.Date,
                ClerkId = 1,
                Guest = PopulateGuestObject(),
                RoomId = Convert.ToInt32(cmbAvailableRooms.SelectedValue)
            };
        }

        #endregion


        private void Reservations_Load(object sender, EventArgs e)
        {

            LoadCountries();
            LoadRooms();
            grpCustomerInfo.Visible = false;
            grpPeople.Visible = false;
            cmbProvince.Enabled = false;
            cmbAvailableRooms.Enabled = false;
            btnRoomSelected.Enabled = false;
            btnRefresh.Visible = false;
            grpRoomDetails.Visible = false;
            txtRoomName.Enabled = false;
            txtRoomNumber.Enabled = false;
            txtBedNum.Enabled = false;
            txtMaxOccupancy.Enabled = false;
            txtBaseRate.Enabled = false;
            txtType.Enabled = false;

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
            label21.BackColor = Color.Transparent;
            label22.BackColor = Color.Transparent;
            label23.BackColor = Color.Transparent;
            label24.BackColor = Color.Transparent;
            #endregion
        }

        private void BtnRoomSelected_Click(object sender, EventArgs e)
        {
            if (cmbAvailableRooms.SelectedIndex <= 0)
            {
                MessageBox.Show("You must choose a room to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            grpCustomerInfo.Visible = true;

        }

        private void BtnCusInfo_Click(object sender, EventArgs e)
        {
            try
            {

                
                grpPeople.Visible = true;
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           

      

        private void BtnSaveReservation_Click(object sender, EventArgs e)
        {
            try
            {
                string errMsg = ValidateForm();
                if (errMsg != string.Empty)
                {
                    toolStripStatusLabel1.Text = "Create Reservation failed";
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    MessageBox.Show(errMsg, "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ReservationService reservationService = new ReservationService();
                Reservation reservation = new Reservation();
               
              
                reservation = PopulateReservationObject();
                if (reservationService.AddNewReservation(reservation))
                {

                    DisabledForm();
                    toolStripStatusLabel1.Text = "Create Reservation successfully";
                    toolStripStatusLabel1.ForeColor = Color.LightGreen;

                    string reservationNumberToShow = reservationService.ShowReservationNumber(reservation.CheckInDate, reservation.CheckOutDate, reservation.RoomId);
                    MessageBox.Show($"The Reservation Number is: {reservationNumberToShow}","INFORMATION!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                else
                {
                    string msg = "";
                    foreach (ValidationError error in reservation.Guest.Errors)
                    {
                        msg += error.Description + Environment.NewLine;
                    }
                    foreach (ValidationError error in reservation.Errors)
                    {
                        msg += error.Description + Environment.NewLine;
                    }
                    toolStripStatusLabel1.Text = "Create Reservation failed";
                    toolStripStatusLabel1.ForeColor = Color.Red;

                    MessageBox.Show(msg, "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
               


            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Create Reservation failed";
                toolStripStatusLabel1.ForeColor = Color.Red;


                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void CmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCountry.SelectedIndex != 0)
            {
                cmbProvince.Enabled = true;
                LoadProvinces(Convert.ToInt32(cmbCountry.SelectedValue));

            }
            else
            {
                cmbProvince.Enabled = false;
            }
        }

       

        private void BtnSearchRooms_Click(object sender, EventArgs e)
        {
            if (dtpStart.Value.CompareTo(DateTime.Now.Date) < 0)
            {
                MessageBox.Show("The starting date for booking can not be in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtpEnd.Value.Date.CompareTo(dtpStart.Value.Date) <= 0)
            {
                MessageBox.Show("The ending date for booking must be after the starting date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

            cmbAvailableRooms.Enabled = true;
            btnRoomSelected.Enabled = true;
            LoadAvailableRooms();

        }

        private void DtpEnd_ValueChanged(object sender, EventArgs e)
        {
            cmbAvailableRooms.Enabled = false;
            btnRoomSelected.Enabled = false;
            cmbAvailableRooms.SelectedIndex = 0;
            toolStripStatusLabel1.Text = "";

        }

        private void DtpStart_ValueChanged(object sender, EventArgs e)
        {
            cmbAvailableRooms.Enabled = false;
            btnRoomSelected.Enabled = false;
            cmbAvailableRooms.SelectedIndex = 0;
            toolStripStatusLabel1.Text = "";

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void cmbAvailableRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAvailableRooms.SelectedIndex <= 0)
            {
                grpRoomDetails.Visible = false;
            }
            else
            {
                grpRoomDetails.Visible = true;

                int roomId = Convert.ToInt32(cmbAvailableRooms.SelectedValue);

                LookupService service = new LookupService();

                RoomDTO room = service.ShowRoomDetails(roomId);
                txtRoomNumber.Text = room.RoomNumber.ToString();
                txtRoomName.Text = room.RoomName;
                txtBedNum.Text = room.NumberOfBeds;
                txtMaxOccupancy.Text = room.MaximumOccupancy.ToString();
                txtBaseRate.Text = room.BaseRate.ToString("c");
                txtType.Text = room.Type;

            }
        }
    }
}
