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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void ServDef_Click(object sender, EventArgs e)
        {
            Services s =  new Services();
            s.Show();
            s.TopMost = true;
            s.TopMost = false;
        }

        private void Reservation_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            r.Show();
            r.TopMost = true;
            r.TopMost = false;
        }

        private void EditRes_Click(object sender, EventArgs e)
        {
            EditReservation er = new EditReservation();
            er.Show();
            er.TopMost = true;
            er.TopMost = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            loginForm mainForm = new loginForm();
            mainForm.Show();
            this.Close();
        }
    }
}
