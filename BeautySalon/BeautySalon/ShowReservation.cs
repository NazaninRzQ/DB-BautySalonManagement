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

namespace BeautySalon
{
    public partial class ShowReservation : Form
    {
        public ShowReservation()
        {
            InitializeComponent();
        }
        string code;
        private void search_Click(object sender, EventArgs e)
        {
            code = entercode.Text;
            string query = "SELECT * FROM RESERVATION r inner join STAFF s on r.staff_name = s.fullname  WHERE staffcode= N'" + code + "'";
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\T460s\Desktop\DataBase Lab\Project\BeautySalon\BeautySalon\Salon'sDatabase.mdf"";Integrated Security=True");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            var isThere = command.ExecuteScalar();

            if (isThere == null)
            {
                MessageBox.Show("This code is invalid.");
                entercode.Text = "";

            }
            else
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["full_name"].ToString());
                    item.SubItems.Add(reader["phoneNum"].ToString());
                    item.SubItems.Add(reader["date"].ToString());
                    item.SubItems.Add(reader["service"].ToString());
                    item.SubItems.Add(reader["staff_name"].ToString());
                    listView1.Items.Add(item);
                }

            }

            sqlConnection.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
