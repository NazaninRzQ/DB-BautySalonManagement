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
    public partial class RegisterCustomer : Form
    {
        public RegisterCustomer()
        {
            InitializeComponent();
        }

        
        private void loginlabel_Click(object sender, EventArgs e)
        {
            LoginCustomer lc = new LoginCustomer();
            lc.Show();
            this.Hide();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if(userNam.Text == "" || phone.Text == "" || passWord.Text == "" || confirmPass.Text== "")
            {
                MessageBox.Show("Please fill the textboxes correctly!");
            }
            else
            {
                try
                {
                    string userName = userNam.Text;
                    string phonenum = phone.Text;
                    string password = passWord.Text;
                    string query = "INSERT INTO CUSTOMERS (userName , phoneNum, password)" +
                        "VALUES ('" + userName + "','" +phonenum+ "','" + password + "')";
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\T460s\Desktop\DataBase Lab\Project\BeautySalon\BeautySalon\Salon'sDatabase.mdf"";Integrated Security=True");
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Succesfuly registered.");
                        userNam.Text = passWord.Text = phone.Text = "";
                        Customers cs = new Customers();
                        cs.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed.");
                        userNam.Text = passWord.Text = phone.Text = "";

                    }

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
           
        }

        private void seePass_CheckedChanged(object sender, EventArgs e)
        {
            if (seePass.Checked)
            {
                passWord.PasswordChar = '\0';
                confirmPass.PasswordChar = '\0';
            }
            else
            {
                passWord.PasswordChar = '*';
                confirmPass.PasswordChar = '*';
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm mainForm = new loginForm();
            mainForm.Show();
        }
    }
}
