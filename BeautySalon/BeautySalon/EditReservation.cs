using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BeautySalon
{
    public partial class EditReservation : Form
    {
        public EditReservation()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string usercode;

        private void des_Click(object sender, EventArgs e)
        {
            
            if (reserve.Text == "")
            {
                MessageBox.Show("Enter Your code.");
            }
            else
            {
                usercode = reserve.Text;
                string query = "SELECT * FROM RESERVATION WHERE reserve_code= N'" + usercode + "'";
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\T460s\Desktop\DataBase Lab\Project\BeautySalon\BeautySalon\Salon'sDatabase.mdf"";Integrated Security=True");
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                var isThere = command.ExecuteScalar();
                
                if(isThere == null)
                {
                    MessageBox.Show("This code is invalid.");
                    reserve.Text = "";

                }
                else
                {
                    var rd = command.ExecuteReader();
                    rd.Read();
                    name.Text = rd["full_name"].ToString();
                    phone.Text = rd["phoneNum"].ToString();
                    date.Text = rd["date"].ToString();
                    service.Text = rd["service"].ToString();
                    server.Text = rd["staff_name"].ToString();

                }
             
                sqlConnection.Close();

            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            
            try
            {
                string c_name = name.Text;
                string phoneNum = phone.Text;
                string dat = date.Text;
                string serv = service.SelectedItem.ToString();
                string s_name = server.SelectedItem.ToString();
                string query = "UPDATE RESERVATION SET full_name=N'" + c_name + "',phoneNum=N'" + phoneNum + "'," +
                    "date=N'" + dat + "',service=N'" + serv + "', staff_name = N'"+s_name+"' WHERE reserve_code = N'"+usercode+"' " ;
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\T460s\Desktop\DataBase Lab\Project\BeautySalon\BeautySalon\Salon'sDatabase.mdf"";Integrated Security=True");
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Update OK");
                    name.Text = phone.Text = date.Text = service.Text = server.Text = "" ;
                    
                }
                else
                    MessageBox.Show("Update Failed.");
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            
            try
            {
                string query = "DELETE FROM RESERVATION WHERE reserve_code =N'" + usercode + "'";
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\T460s\Desktop\DataBase Lab\Project\BeautySalon\BeautySalon\Salon'sDatabase.mdf"";Integrated Security=True");
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("DELETE OK");
                    name.Text = phone.Text = date.Text = service.Text = server.Text = "" ;
                    
                }
                else
                    MessageBox.Show("Delete Failed.");
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
