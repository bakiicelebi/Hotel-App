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
using static System.Windows.Forms.DataFormats;

namespace HotelApplication
{
    public partial class FormCheckoutPop : Form
    {
        NpgsqlConnection connection;
        public FormCheckoutPop()
        {
            InitializeComponent();
            connection = new NpgsqlConnection("Host=127.0.0.1;Port=5432;Username=postgres;Password=1111;Database=HotelApplication"); // CONNECTION DEFINITION
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            string roomNo = comboBox1.SelectedItem.ToString();
            string turn = "SELECT \"Room\".\"CustomerBooked\" From \"HotelApplication\".\"Room\"  WHERE \"RoomNo\" = \'" + roomNo + "\';";
            NpgsqlCommand turnCommand = new NpgsqlCommand(turn,connection);
            string personID = Convert.ToString(turnCommand.ExecuteScalar());
            string sql = "DELETE FROM \"HotelApplication\".\"Person\" WHERE \"PersonID\" = \'"+ personID + "\';";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
            DialogResult result = MessageBox.Show("Room Will Be Deleted. Are You Sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex)
            {
                MessageBox.Show("Warning" + ex.Message);
            }
            connection.Close();
            
        }

        private void FormCheckoutPop_Load(object sender, EventArgs e)
        {
            LoadRoomCombo();
        }
        private void LoadRoomCombo()
        {
            connection.Open();
            comboBox1.Items.Clear();
            string query = "SELECT * FROM \"HotelApplication\".\"Room\" WHERE \"IsEmpty\" = false ORDER BY \"RoomNo\"";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string roomName = reader["RoomNo"].ToString();
                    comboBox1.Items.Add(roomName);
                }
            }
            comboBox1.SelectedIndex = 0;
            connection.Close();
        }
    }
}
