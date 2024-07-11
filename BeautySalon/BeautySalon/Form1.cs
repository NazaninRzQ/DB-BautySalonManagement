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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        LoginCustomer cs = new LoginCustomer();
        private void button1_Click(object sender, EventArgs e)
        {
            cs.Show();
            //cs.TopMost = true;
            //cs.TopMost = false;
            this.Hide();
        }

        LoginStaff ls = new LoginStaff();
        private void button2_Click(object sender, EventArgs e)
        {
            ls.Show();
            this.Hide();
        }

        private void closeProg_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
