using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace HotelApplication
{
    public partial class FormRoomPop : Form
    {
        public NpgsqlConnection connection;
        public FormRoomPop()
        {
            InitializeComponent();
            connection = new NpgsqlConnection("Host=127.0.0.1;Port=5432;Username=postgres;Password=1111;Database=HotelApplication"); // CONNECTION DEFINITION
            
        }

        private void FormPop_Load(object sender, EventArgs e)
        {
            LoadRoomCombo();
            comboGender.SelectedIndex = 0;
            comboPackage.SelectedIndex = 0;
            numericParticipant.Maximum = 4;
            numericParticipant.Minimum = 1;
        }

        private void LoadRoomCombo()
        {
            connection.Open();
            comboRoom.Items.Clear();
            string query = "SELECT * FROM \"HotelApplication\".\"Room\" WHERE \"IsEmpty\" = true ORDER BY \"RoomNo\"";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string roomName = reader["RoomNo"].ToString();
                    comboRoom.Items.Add(roomName);
                }
            }
            connection.Close();
        }

        private void addcustomerbutton_Click(object sender, EventArgs e)
        {

            connection.Open();
            string name = textName.Text;
            string surname = textSurname.Text;
            string phone = textPhone.Text;
            string mail = textMail.Text;
            string tc = textTC.Text;
            string gender = comboGender.SelectedItem?.ToString();
            string roomNo = comboRoom.SelectedItem?.ToString();
            int participant = (int)numericParticipant.Value;
            string package = comboPackage.SelectedItem?.ToString();
            DateTime entryDate = dateEntry.Value;
            DateTime releaseDate = dateRelease.Value;
            string city = textcity.Text;
            string district = textDistrict.Text;
            string streetNo = textStreet.Text;
            string doorNo = textDoor.Text;
            TimeSpan registrationTime = DateTime.Now.TimeOfDay;
            DateTime registrationDate = DateTime.Now.Date;


            bool hasEmpty = false;
            string alert = "(* are Mandatory)\nPlease Check These Fields: ";

            if (string.IsNullOrWhiteSpace(name))
            {
                alert += "Name, ";
                hasEmpty = true;
            }
            if (string.IsNullOrWhiteSpace(surname))
            {
                alert += "Surname, ";
                hasEmpty = true;
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                alert += "Phone, ";
                hasEmpty = true;
            }
            if (string.IsNullOrWhiteSpace(mail))
            {
                alert += "Mail, ";
                hasEmpty = true;
            }
            if (string.IsNullOrWhiteSpace(tc))
            {
                alert += "TC ID, ";
                hasEmpty = true;
            }
            if (string.IsNullOrWhiteSpace(gender))
            {
                alert += "Gender, ";
                hasEmpty = true;
            }
            if (string.IsNullOrWhiteSpace(roomNo))
            {
                alert += "Room No, ";
                hasEmpty = true;
            }
            if (!(participant >= 1 && participant <= 4))
            {
                alert += "Participant (1-4), ";
                hasEmpty = true;
            }
            if (string.IsNullOrWhiteSpace(package))
            {
                alert += "Package, ";
                hasEmpty = true;
            }
            if (string.IsNullOrWhiteSpace(city))
            {
                alert += "City, ";
                hasEmpty = true;
            }
            if (string.IsNullOrWhiteSpace(district))
            {
                alert += "District, ";
                hasEmpty = true;
            }
            if (hasEmpty)
            {
                alert = alert.TrimEnd(',', ' ');
                MessageBox.Show(alert);
            }
            else
            {
                string sqlFunctionCall = "SELECT \"HotelApplication\".AddCustomer(@NameInput, @Surname, @PhoneNo, @Mail, @TC_ID, @Gender, @RoomNo, @NumberOfCustomer, @Package, @EntryDate, @ReleaseDate, @RegistrationTime, @RegistrationDate, @City, @District, @StreetNo, @DoorNo)";
                NpgsqlCommand cmd = new NpgsqlCommand(sqlFunctionCall, connection);
                cmd.Parameters.Add("@NameInput", NpgsqlTypes.NpgsqlDbType.Varchar).Value = name;
                cmd.Parameters.Add("@Surname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = surname;
                cmd.Parameters.Add("@PhoneNo", NpgsqlTypes.NpgsqlDbType.Char).Value = phone;
                cmd.Parameters.Add("@Mail", NpgsqlTypes.NpgsqlDbType.Varchar).Value = mail;
                cmd.Parameters.Add("@TC_ID", NpgsqlTypes.NpgsqlDbType.Char).Value = tc;
                cmd.Parameters.Add("@Gender", NpgsqlTypes.NpgsqlDbType.Char).Value = gender;
                cmd.Parameters.Add("@RoomNo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = roomNo;
                cmd.Parameters.Add("@NumberOfCustomer", NpgsqlTypes.NpgsqlDbType.Smallint).Value = participant;
                cmd.Parameters.Add("@Package", NpgsqlTypes.NpgsqlDbType.Varchar).Value = package;
                cmd.Parameters.Add("@EntryDate", NpgsqlTypes.NpgsqlDbType.Date).Value = entryDate;
                cmd.Parameters.Add("@ReleaseDate", NpgsqlTypes.NpgsqlDbType.Date).Value = releaseDate;
                cmd.Parameters.Add("@RegistrationTime", NpgsqlTypes.NpgsqlDbType.Time).Value = registrationTime;
                cmd.Parameters.Add("@RegistrationDate", NpgsqlTypes.NpgsqlDbType.Date).Value = registrationDate;
                cmd.Parameters.Add("@City", NpgsqlTypes.NpgsqlDbType.Varchar).Value = city;
                cmd.Parameters.Add("@District", NpgsqlTypes.NpgsqlDbType.Char).Value = district;
                cmd.Parameters.Add("@StreetNo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = streetNo;
                cmd.Parameters.Add("@DoorNo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = doorNo;
                try
                {
                    object result = cmd.ExecuteScalar();
                    MessageBox.Show("Added Customer Successfully..");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error: " + ex.Message);
                }
                this.Close();
            }
            connection.Close();
        }

        private void textName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addcustomerbutton.PerformClick();
            }
        }
    }
}
