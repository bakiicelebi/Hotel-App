using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HotelApplication
{
    public partial class FormListing : Form
    {
        NpgsqlConnection connection;
        NpgsqlDataAdapter adapter;
        private bool button1IsOpen = false;
        private bool button2IsOpen = false;
        public FormListing()
        {
            InitializeComponent();
        }

        private void FormListing_Load(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection("Host=127.0.0.1;Port=5432;Username=postgres;Password=1111;Database=HotelApplication"); // CONNECTION DEFINITION
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            button1IsOpen = true;
            button2IsOpen = false;
            dateTimePicker1.Visible = false;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            connection.Close();
            connection.Open();
            comboBox1.Items.Add("Name");
            comboBox1.Items.Add("Surname");
            comboBox1.Items.Add("PhoneNo");
            comboBox1.Items.Add("NumberOfCustomer");
            comboBox1.Visible = true;
            comboBox1.SelectedIndex = 0;
            textBox1.Visible = true;
            button3.Visible = true;
            string query = "SELECT \"Person\".\"PersonID\",\"Person\".\"Name\", \"Person\".\"Surname\", \"Person\".\"PhoneNo\" ,\"Customer\".\"NumberOfCustomer\" ,\"Customer\".\"CustomerNo\", \"Room\".\"RoomNo\"\r\nFrom \"HotelApplication\".\"Person\" INNER JOIN \"HotelApplication\".\"Customer\" ON \"Person\".\"PersonID\" = \"Customer\".\"PersonID\" InNER JOIN \"HotelApplication\".\"Room\" ON \"Room\".\"CustomerBooked\" = \"Customer\".\"PersonID\" ORDER BY \"PersonID\";";
            string query1 = "SELECT \"Customer\".\"PersonID\" From \"HotelApplication\".\"Customer\" ORDER BY \"PersonID\"";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            adapter = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            NpgsqlCommand cmd1 = new NpgsqlCommand(query1, connection);
            NpgsqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                string personID = reader["PersonID"].ToString();
                comboBox2.Items.Add(personID);
            }
            comboBox2.Visible = true;
            comboBox2.SelectedIndex = 0;
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            button2IsOpen = true;
            button1IsOpen = false;
            dateTimePicker1.Visible = false;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            connection.Close();
            connection.Open();
            comboBox1.Items.Add("Name");
            comboBox1.Items.Add("Surname");
            comboBox1.Items.Add("PhoneNo");
            comboBox1.Items.Add("ShiftStart");
            comboBox1.Items.Add("OffDay");
            comboBox1.Visible = true;
            comboBox1.SelectedIndex = 0;
            textBox1.Visible = true;
            button3.Visible = true;
            string query = "SELECT \"Person\".\"PersonID\",\"Person\".\"Name\", \"Person\".\"Surname\", \"Person\".\"PhoneNo\" ,\"Employee\".\"ShiftStart\" ,\"Employee\".\"OffDay\", \"Employee\".\"Sort\"\r\nFrom \"HotelApplication\".\"Person\" INNER JOIN \"HotelApplication\".\"Employee\" ON \"Person\".\"PersonID\" = \"Employee\".\"PersonID\" ORDER BY \"PersonID\" ;";
            string query1 = "SELECT \"Employee\".\"PersonID\" From \"HotelApplication\".\"Employee\" ORDER BY \"PersonID\"";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            adapter = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            NpgsqlCommand cmd1 = new NpgsqlCommand(query1, connection);
            NpgsqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                string personID = reader["PersonID"].ToString();
                comboBox2.Items.Add(personID);
            }
            comboBox2.Visible = true;
            comboBox2.SelectedIndex = 0;
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (button1IsOpen)
            {
                if (comboBox1.SelectedItem.ToString() == "NumberOfCustomer")
                {
                    string updateQuery = "UPDATE \"HotelApplication\".\"Customer\"\r\nSET \"NumberOfCustomer\" = \'" + textBox1.Text + "' WHERE \"PersonID\" = \'" + comboBox2.SelectedItem.ToString() + "\';";
                    NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, connection);
                    try { cmd.ExecuteNonQuery(); }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Warning: " + ex.Message);
                    }
                }
                else
                {
                    string updateQuery = "UPDATE \"HotelApplication\".\"Person\"\r\n" +
                    "SET \"" + comboBox1.SelectedItem.ToString() + "\" = '" + textBox1.Text + "'\r\n" +
                    "FROM \"HotelApplication\".\"Customer\"\r\n" +
                    "WHERE \"Customer\".\"PersonID\" = \"Person\".\"PersonID\"\r\n" +
                    "AND \"Customer\".\"PersonID\" = '" + comboBox2.SelectedItem.ToString() + "'";
                    NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, connection);
                    try { cmd.ExecuteNonQuery(); }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Warning: " + ex.Message);
                    }
                }
            }
            else if (button2IsOpen)
            {
                if (comboBox1.SelectedItem.ToString() == "ShiftStart")
                {
                    string sql = "UPDATE \"HotelApplication\".\"Employee\" SET \"ShiftStart\" = \'" + dateTimePicker1.Text + "\' WHERE \"PersonID\" = \'" + comboBox2.SelectedItem.ToString() + "\'";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                    try { cmd.ExecuteNonQuery(); }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Warning: " + ex.Message);
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "OffDay")
                {
                    string sql = "UPDATE \"HotelApplication\".\"Employee\" SET \"OffDay\" = \'" + textBox1.Text + "\' WHERE \"PersonID\" = \'" + comboBox2.SelectedItem.ToString() + "\'";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                    try { cmd.ExecuteNonQuery(); }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Warning: " + ex.Message);
                    }
                }
                else
                {
                    string updateQuery = "UPDATE \"HotelApplication\".\"Person\"\r\nSET \"" + comboBox1.SelectedItem.ToString() + "\" = \'" + textBox1.Text + "' WHERE \"PersonID\" = \'" + comboBox2.SelectedItem.ToString() + "\';";
                    NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, connection);
                    try { cmd.ExecuteNonQuery(); }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Warning: " + ex.Message);
                    }
                }
            }

            if (button1IsOpen)
            {
                button1_Click(sender, e);
            }
            else if (button2IsOpen)
            {
                button2_Click(sender, e);
            }
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "ShiftStart")
            {
                dateTimePicker1.Visible = true;
            }
        }
    }
}
