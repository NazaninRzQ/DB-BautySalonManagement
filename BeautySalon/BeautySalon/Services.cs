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

namespace BeautySalon
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }


        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void des_Click(object sender, EventArgs e)
        {
            string serName = service.SelectedItem.ToString();
            try
            {
                string query = "SELECT description FROM SERVICES WHERE name=N'" + serName + "'";
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\T460s\source\repos\BeautySalon\BeautySalon\Salon'sDatabase.mdf"";Integrated Security=True");
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                var rd = command.ExecuteReader();

                rd.Read();
                label9.Text = rd["description"].ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

        private void Services_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void service_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
