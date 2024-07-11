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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BeautySalon
{
    public partial class LoginStaff : Form
    {
        public LoginStaff()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm mainForm = new loginForm();
            mainForm.Show();
        }

        
        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                string username = userName.Text;
                string password = passWord.Text;
                string query = "SELECT * FROM STAFF WHERE username = '" + username + "' AND password = '" + password + "'";
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\T460s\Desktop\DataBase Lab\Project\BeautySalon\BeautySalon\Salon'sDatabase.mdf"";Integrated Security=True");
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                var dr = command.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Login successful!");
                    Staff sf = new Staff();
                    sf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password. Please try again.");
                    this.userName.Text = passWord.Text = "";
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
        private void register_label_Click(object sender, EventArgs e)
        {
            RegisterStaff rsf = new RegisterStaff();
            rsf.Show();
            this.Hide();
        }

        private void seePass_CheckedChanged(object sender, EventArgs e)
        {
            if (seePass.Checked)
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
