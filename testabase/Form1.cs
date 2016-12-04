using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace testabase
{
    public partial class Friends : Form
    {

        SqlConnection connection;
        string connectionstring;

        public Friends()
        {
            InitializeComponent();

            connectionstring = ConfigurationManager.ConnectionStrings["testabase.Properties.Settings.friendsConnectionString"].ConnectionString;
        }
        private void Friends_Load(object sender, EventArgs e)
        {
            populatefriends();
        }
        private void populatefriends()
        {
            using (connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Id FROM Friends", connection))
            {
                DataTable recipetable = new DataTable();
                adapter.Fill(recipetable);
                connection.Open();
                lb1.DataSource = recipetable;
                lb1.DisplayMember = "Name";
                lb1.ValueMember = "Id";

            }
            populatesurname();
        }
        private void populatesurname()
        {

            string query = "SELECT Last_Name, Id FROM Friends WHERE Id = @Id1";
            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                try
                {
                    command.Parameters.AddWithValue("@Id1", lb1.SelectedValue);
                    DataTable recipetable = new DataTable();
                    adapter.Fill(recipetable);
                    connection.Open();
                    lb2.DataSource = recipetable;
                    lb2.DisplayMember = "Last_Name";
                    lb2.ValueMember = "Id";
                }
                catch { populateaddr(); }
            }
            populateaddr();
        }
        private void populateaddr()
        {

            string query = "SELECT Address, Id FROM Friends WHERE Id = @Id1";
            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                try
                {
                    command.Parameters.AddWithValue("@Id1", lb1.SelectedValue);
                    DataTable recipetable = new DataTable();
                    adapter.Fill(recipetable);
                    connection.Open();
                    lb3.DataSource = recipetable;
                    lb3.DisplayMember = "Address";
                    lb3.ValueMember = "Id";
                }
                finally { }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Friends (Name, Last_Name, Address) VALUES (@Name1, @surname1, @Address1)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Name1", namebox.Text);
                cmd.Parameters.AddWithValue("@surname1", surnamebox.Text);
                cmd.Parameters.AddWithValue("@Address1", addrbox.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                namebox.Clear();
                surnamebox.Clear();
                addrbox.Clear();
            }
            populatefriends();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "DELETE FROM Friends WHERE Id = @Id1";
            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Id1", lb1.SelectedValue);

                command.ExecuteScalar();
            }
            populatefriends();
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var test = lb1.SelectedValue.ToString();
            if (test != "System.Data.DataRowView")
            {
                populatesurname();
            }

        }
    }
}
