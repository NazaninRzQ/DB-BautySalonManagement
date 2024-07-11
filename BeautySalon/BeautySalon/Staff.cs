using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }



        private void label7_Click(object sender, EventArgs e)
        {
            Staff_sInfo si = new Staff_sInfo();
            si.Show();
            si.TopMost = true;
            si.TopMost = false;
        }

        private void SerDef_Click(object sender, EventArgs e)
        {
            DefiningServices df = new DefiningServices();
            df.Show();
            df.TopMost = true;
            df.TopMost = false;
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            loginForm mainForm = new loginForm();
            mainForm.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ShowReservation sr = new ShowReservation();
            sr.Show();
            sr.TopMost = true;
            sr.TopMost = false;

        }

    }
}
