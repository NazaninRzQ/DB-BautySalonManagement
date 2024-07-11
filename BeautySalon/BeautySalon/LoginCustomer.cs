using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BeautySalon
{
    public partial class LoginCustomer : Form
    {
        public LoginCustomer()
        {
            InitializeComponent();
        }

        RegisterCustomer rc =  new RegisterCustomer();
        private void label5_Click(object sender, EventArgs e)
        {
            rc.Show();
            this.Hide();

        }
        
        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                string username = userName.Text;
                string password = passWord.Text;
                string query = "SELECT * FROM CUSTOMERS WHERE userName = '"+username+"' AND password = '"+password+"'";
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\T460s\Desktop\DataBase Lab\Project\BeautySalon\BeautySalon\Salon'sDatabase.mdf"";Integrated Security=True");
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                var dr = command.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Login successful!");
                    Customers cs = new Customers();
                    cs.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password. Please try again.");
                    userName.Text = passWord.Text = "";
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm mainForm = new loginForm();
            mainForm.Show();
        }

        private void seePass_CheckedChanged(object sender, EventArgs e)
        {
            if(seePass.Checked)
            {
                passWord.PasswordChar = '\0';
            }
            else
            {
                passWord.PasswordChar = '*';
            }
        }
    }
}
