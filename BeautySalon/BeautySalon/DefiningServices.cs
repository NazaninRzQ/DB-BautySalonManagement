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
    public partial class DefiningServices : Form
    {
        public DefiningServices()
        {
            InitializeComponent();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (serName.Text == "" || serDes.Text == "")
            {
                MessageBox.Show("Fill the inputs correctly!");

            }
            else
            {

                try
                {
                    string name = serName.Text;
                    string des = serDes.Text;
                    string query = "INSERT INTO SERVICES(name , description)" +
                        "VALUES (N'"+name+"' , N'"+des+"') ";

                    SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\T460s\\Desktop\\DataBase Lab\\Project\\BeautySalon\\BeautySalon\\Salon'sDatabase.mdf\";Integrated Security=True");
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    int i = command.ExecuteNonQuery();

                    if (i>0)
                    {
                        MessageBox.Show("Your Service inserted succesfuly!");
                        serName.Text = serDes.Text = "";
                        
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong:(");
                        serName.Text = serDes.Text = "";
                    }
                    sqlConnection.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
