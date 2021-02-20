using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationProject
{
    public partial class Form1 : Form
    {
        public int ClerkId {get; set;}

        public Form1()
        {

            InitializeComponent();
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.FlatAppearance.BorderColor = Color.DarkSlateGray;

        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = null;
            
            ToolStripMenuItem m = (ToolStripMenuItem)sender;

            switch (m.Tag)
            {
                case "Reservations":
                  
                    this.panel2.Controls.Clear();
                    childForm = new Reservations(this);
                    childForm.TopLevel = false;
                    this.panel2.Controls.Add(childForm);
                    break;
                case "ViewReservation":
                    this.panel2.Controls.Clear();
                    childForm = new ReservationView(this);
                    childForm.TopLevel = false;
                    this.panel2.Controls.Add(childForm);
                    break;

            }

            if (childForm != null)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == childForm.GetType())
                    {

                        f.Activate();
                        return;
                    }
                }

                //childForm.MdiParent = this;
                childForm.Show();
            }
        }
        private void Button_ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = null;
            Button m = (Button)sender;

            switch (m.Tag)
            {
                case "Home":
                    panelShown.Height = btnHome.Height;
                    panelShown.Top = btnHome.Top;
                    this.panel2.Controls.Clear();
                    childForm = new Home(this);
                    childForm.TopLevel = false;
                    this.panel2.Controls.Add(childForm);
                    break;

                case "Reservations":
                    panelShown.Height = btnCreateReservation.Height;
                    panelShown.Top = btnCreateReservation.Top;
                    this.panel2.Controls.Clear();
                    childForm = new Reservations(this);
                    childForm.TopLevel = false;
                    this.panel2.Controls.Add(childForm);
                    break;
                case "ViewReservation":
                    panelShown.Height = btnReservationsList.Height;
                    panelShown.Top = btnReservationsList.Top;
                    this.panel2.Controls.Clear();
                    childForm = new ReservationView(this);
                    childForm.TopLevel = false;
                    this.panel2.Controls.Add(childForm);
                    break;

            }

            if (childForm != null)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == childForm.GetType())
                    {

                        f.Activate();
                        return;
                    }
                }

                //childForm.MdiParent = this;
                childForm.Show();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Splash splash = new Splash();
            splash.ShowDialog();
            if (splash.DialogResult != DialogResult.OK)
            {
                this.Close();
            }
            else
            {


                this.Show();


            }


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelShown.Height = btnHome.Height;
            panelShown.Top = btnHome.Top;
        }

      
    }
}
