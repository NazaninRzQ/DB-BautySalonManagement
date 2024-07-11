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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BeautySalon
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }


        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            refresh();
            refresh2();
        }

        void refresh()
        {
            try
            {
                service.Items.Clear();
                string query = "SELECT * FROM SERVICES";
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\T460s\Desktop\DataBase Lab\Project\BeautySalon\BeautySalon\Salon'sDatabase.mdf"";Integrated Security=True");
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                var dr = command.ExecuteReader();
                while (dr.Read())
                {
                    service.Items.Add(dr["name"]);
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void refresh2()
        {
            try
            {
                server.Items.Clear();
                string query = "SELECT * FROM STAFF";
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\T460s\Desktop\DataBase Lab\Project\BeautySalon\BeautySalon\Salon'sDatabase.mdf"";Integrated Security=True");
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                var dr = command.ExecuteReader();
                while (dr.Read())
                {
                    server.Items.Add(dr["fullname"]);
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            
            string serName = service.SelectedItem.ToString();
            try
            {
                string c_name = name.Text;
                string phoneNum = phone.Text;
                string dat = date.Text;
                string s_name = server.SelectedItem.ToString();
                
                string query = "INSERT INTO RESERVATION (full_name ,phoneNum , date , service , staff_name)" +
                    "VALUES (N'" + c_name + "', N'" + phoneNum + "' , N'" + dat + "' , N'" + serName + "' , N'" + s_name + "')";

                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\T460s\Desktop\DataBase Lab\Project\BeautySalon\BeautySalon\Salon'sDatabase.mdf"";Integrated Security=True");
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);

                int i = command.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Succesfull.");
                    name.Text = phone.Text = date.Text  = service.SelectedText = "";
                    server.Text = "";
                    service.Text = "";
                    
                }
                else
                {
                    MessageBox.Show("Reservation failed.");
                    name.Text = phone.Text = date.Text = service.SelectedText = "";
                    server.Text = "";
                    service.Text = "";

                }
                sqlConnection.Close();

                try
                {
                    string query2 = "SELECT * FROM RESERVATION WHERE full_name = N'" + c_name + "'";
                    SqlConnection sqlConnection2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\T460s\Desktop\DataBase Lab\Project\BeautySalon\BeautySalon\Salon'sDatabase.mdf"";Integrated Security=True");
                    sqlConnection2.Open();
                    SqlCommand command2 = new SqlCommand(query, sqlConnection);
                    var rd = command2.ExecuteReader();
                    rd.Read();
                    string code = rd["reserve_code"].ToString();

                    MessageBox.Show(code);
                    sqlConnection2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

    }
}
