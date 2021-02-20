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
    public partial class Home : Form
    {
        Form1 myParent;
        public Home(Form1 parent)
        {
            myParent = parent;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
