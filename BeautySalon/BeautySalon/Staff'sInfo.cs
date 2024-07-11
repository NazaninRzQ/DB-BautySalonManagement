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
    public partial class Staff_sInfo : Form
    {
        public Staff_sInfo()
        {
            InitializeComponent();
        }


        private void search_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Enter Your Username.");
            }
            else
            {
                string user = textBox1.Text;
                string query = "SELECT * FROM STAFF WHERE username= '" + user + "'";
                SqlConnection sqlConnection =new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\T460s\Desktop\DataBase Lab\Project\BeautySalon\BeautySalon\Salon'sDatabase.mdf"";Integrated Security=True");
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                var rd = command.ExecuteReader();

                rd.Read();
                label9.Text = rd["fullname"].ToString();
                label11.Text = rd["staffcode"].ToString();
                label12.Text = rd["service"].ToString();
                sqlConnection.Close();
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
