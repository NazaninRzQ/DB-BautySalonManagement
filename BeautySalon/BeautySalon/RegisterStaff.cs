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

namespace BeautySalon
{
    public partial class RegisterStaff : Form
    {
        public RegisterStaff()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (s_username.Text == "" || name.Text == "" || passWord.Text == "" || confirmPass.Text == "")
            {
                MessageBox.Show("Please fill the textboxes correctly!");
            }
            else
            {
                try
                {
                    string userName = s_username.Text;
                    string s_name = name.Text;
                    string staff_job = comboBox1.SelectedItem.ToString();
                    string password = passWord.Text;
                    string query = "INSERT INTO STAFF (username ,fullname , service , password)" +
                        "VALUES (N'" + userName + "', N'" + s_name + "' , N'" + staff_job + "' , N'" + password + "')";

                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\T460s\Desktop\DataBase Lab\Project\BeautySalon\BeautySalon\Salon'sDatabase.mdf"";Integrated Security=True");
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand(query, sqlConnection);

                    int i = command.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Succesfuly registered.");
                        s_username.Text = name.Text = passWord.Text = "";
                        Staff sf = new Staff();
                        sf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed.");
                        s_username.Text = name.Text = passWord.Text = "";

                    }

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
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

        private void loginlabel_Click(object sender, EventArgs e)
        {
            LoginStaff ls = new LoginStaff();
            ls.Show();
            this.Hide();
        }


        void refresh()
        {
            try
            {
                comboBox1.Items.Clear();
                string query = "SELECT * FROM SERVICES";
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\T460s\source\repos\BeautySalon\BeautySalon\Salon'sDatabase.mdf"";Integrated Security=True");
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                var dr = command.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["name"]);
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RegisterStaff_Load(object sender, EventArgs e)
        {
            refresh();

        }

    }
}
