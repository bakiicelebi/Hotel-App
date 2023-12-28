using HotelApplication.Properties;
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
    public partial class RoomForm : Form
    {
        private NpgsqlConnection connection;
        private string fullRoom = "..\\..\\..\\Resources\\fullRoom.png";
        private string emptyRoom = "..\\..\\..\\Resources\\emptyRoom.png";
        private bool room11001 = true;
        private bool room11002 = true;
        private bool room11003 = true;
        private bool room11004 = true;
        private bool room11005 = true;
        private bool room12001 = true;
        private bool room12002 = true;
        private bool room12003 = true;
        private bool room12004 = true;
        private bool room12005 = true;
        private bool room21001 = true;
        private bool room21002 = true;
        private bool room21003 = true;
        private bool room21004 = true;
        private bool room21005 = true;
        private bool room22001 = true;
        private bool room22002 = true;
        private bool room22003 = true;
        private bool room22004 = true;
        private bool room22005 = true;

        private FormRoomPop popupForm;
        private FormInfoRoomPop roomInfoForm;
        private FormCheckoutPop checkoutForm;

        public RoomForm()
        {
            InitializeComponent();
            roomInfoForm = new FormInfoRoomPop();
            connection = new NpgsqlConnection("Host=127.0.0.1;Port=5432;Username=postgres;Password=1111;Database=HotelApplication"); // CONNECTION DEFINITION
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CheckRooms();
            LoadLabels();
        }
        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            popupForm = new FormRoomPop();
            Label label = new Label();
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            popupForm.Controls.Add(label);
            popupForm.ShowDialog();

            this.Focus();
            CheckRooms();
            LoadLabels();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkoutForm = new FormCheckoutPop();
            Label label = new Label();
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            checkoutForm.Controls.Add(label);
            checkoutForm.ShowDialog();

            this.Focus();
            CheckRooms();
            LoadLabels();

        }
        private void CheckRooms()
        {
            connection.Open();
            string sql = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '11001'";
            using var cmd = new NpgsqlCommand(sql, connection);
            room11001 = Convert.ToBoolean(cmd.ExecuteScalar());
            string sql1 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '11002'";
            using var cmd1 = new NpgsqlCommand(sql1, connection);
            room11002 = Convert.ToBoolean(cmd1.ExecuteScalar());
            string sql2 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '11003'";
            using var cmd2 = new NpgsqlCommand(sql2, connection);
            room11003 = Convert.ToBoolean(cmd2.ExecuteScalar());
            string sql3 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '11004'";
            using var cmd3 = new NpgsqlCommand(sql3, connection);
            room11004 = Convert.ToBoolean(cmd3.ExecuteScalar());
            string sql4 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '11005'";
            using var cmd4 = new NpgsqlCommand(sql4, connection);
            room11005 = Convert.ToBoolean(cmd4.ExecuteScalar());
            string sql5 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '12001'";
            using var cmd5 = new NpgsqlCommand(sql5, connection);
            room12001 = Convert.ToBoolean(cmd5.ExecuteScalar());
            string sql6 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '12002'";
            using var cmd6 = new NpgsqlCommand(sql6, connection);
            room12002 = Convert.ToBoolean(cmd6.ExecuteScalar());
            string sql7 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '12003'";
            using var cmd7 = new NpgsqlCommand(sql7, connection);
            room12003 = Convert.ToBoolean(cmd7.ExecuteScalar());
            string sql8 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '12004'";
            using var cmd8 = new NpgsqlCommand(sql8, connection);
            room12004 = Convert.ToBoolean(cmd8.ExecuteScalar());
            string sql9 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '12005'";
            using var cmd9 = new NpgsqlCommand(sql9, connection);
            room12005 = Convert.ToBoolean(cmd9.ExecuteScalar());
            string sql10 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '21001'";
            using var cmd10 = new NpgsqlCommand(sql10, connection);
            room21001 = Convert.ToBoolean(cmd10.ExecuteScalar());
            string sql11 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '21002'";
            using var cmd11 = new NpgsqlCommand(sql11, connection);
            room21002 = Convert.ToBoolean(cmd11.ExecuteScalar());
            string sql12 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '21003'";
            using var cmd12 = new NpgsqlCommand(sql12, connection);
            room21003 = Convert.ToBoolean(cmd12.ExecuteScalar());
            string sql13 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '21004'";
            using var cmd13 = new NpgsqlCommand(sql13, connection);
            room21004 = Convert.ToBoolean(cmd13.ExecuteScalar());
            string sql14 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '21005'";
            using var cmd14 = new NpgsqlCommand(sql14, connection);
            room21005 = Convert.ToBoolean(cmd14.ExecuteScalar());
            string sql15 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '22001'";
            using var cmd15 = new NpgsqlCommand(sql15, connection);
            room22001 = Convert.ToBoolean(cmd15.ExecuteScalar());
            string sql16 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '22002'";
            using var cmd16 = new NpgsqlCommand(sql16, connection);
            room22002 = Convert.ToBoolean(cmd16.ExecuteScalar());
            string sql17 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '22003'";
            using var cmd17 = new NpgsqlCommand(sql17, connection);
            room22003 = Convert.ToBoolean(cmd17.ExecuteScalar());
            string sql18 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '22004'";
            using var cmd18 = new NpgsqlCommand(sql18, connection);
            room22004 = Convert.ToBoolean(cmd18.ExecuteScalar());
            string sql19 = "SELECT \"IsEmpty\" FROM \"HotelApplication\".\"Room\" WHERE \"RoomNo\" = '22005'";
            using var cmd19 = new NpgsqlCommand(sql19, connection);
            room22005 = Convert.ToBoolean(cmd19.ExecuteScalar());
            connection.Close();
        }
        
        private void LoadLabels()
        {
            if (room11001 == false)
            {
                img_11001.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_11001.Image = Image.FromFile(emptyRoom);
            }
            if (room11002 == false)
            {
                img_11002.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_11002.Image = Image.FromFile(emptyRoom);
            }
            if (room11003 == false)
            {
                img_11003.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_11003.Image = Image.FromFile(emptyRoom);
            }
            if (room11004 == false)
            {
                img_11004.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_11004.Image = Image.FromFile(emptyRoom);
            }
            if (room11005 == false)
            {
                img_11005.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_11005.Image = Image.FromFile(emptyRoom);
            }
            if (room12001 == false)
            {
                img_12001.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_12001.Image = Image.FromFile(emptyRoom);
            }
            if (room12002 == false)
            {
                img_12002.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_12002.Image = Image.FromFile(emptyRoom);
            }
            if (room12003 == false)
            {
                img_12003.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_12003.Image = Image.FromFile(emptyRoom);
            }
            if (room12004 == false)
            {
                img_12004.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_12004.Image = Image.FromFile(emptyRoom);
            }
            if (room12005 == false)
            {
                img_12005.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_12005.Image = Image.FromFile(emptyRoom);
            }
            if (room21001 == false)
            {
                img_21001.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_21001.Image = Image.FromFile(emptyRoom);
            }
            if (room21002 == false)
            {
                img_21002.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_21002.Image = Image.FromFile(emptyRoom);
            }
            if (room21003 == false)
            {
                img_21003.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_21003.Image = Image.FromFile(emptyRoom);
            }
            if (room21004 == false)
            {
                img_21004.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_21004.Image = Image.FromFile(emptyRoom);
            }
            if (room21005 == false)
            {
                img_21005.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_21005.Image = Image.FromFile(emptyRoom);
            }
            if (room22001 == false)
            {
                img_22001.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_22001.Image = Image.FromFile(emptyRoom);
            }
            if (room22002 == false)
            {
                img_22002.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_22002.Image = Image.FromFile(emptyRoom);
            }
            if (room22003 == false)
            {
                img_22003.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_22003.Image = Image.FromFile(emptyRoom);
            }
            if (room22004 == false)
            {
                img_22004.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_22004.Image = Image.FromFile(emptyRoom);
            }
            if (room22005 == false)
            {
                img_22005.Image = Image.FromFile(fullRoom);
            }
            else
            {
                img_22005.Image = Image.FromFile(emptyRoom);
            }
        }

        
        private async void label_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            connection.Open();
            Label clickedLabel = sender as Label;

            // Tıklama olayı gerçekleştiğinde label rengini değiştir
            if (clickedLabel != null)
            {
                clickedLabel.BackColor = Color.FromArgb(31, 31, 31); // Örnek olarak kırmızı yapalım
            }
            await Task.Delay(150);
            label_MouseEnter(clickedLabel, e);
            string labelName = clickedLabel.Name;
            string holder = labelName.Substring(labelName.Length - 5);
            bool boolHolder = false;
            string name = "";
            string surname = "";
            string phoneNo = "";
            int participant = 0;
            string dateEntry = "";
            string dateRelease = "";
            if (holder == "11001")
            {
                boolHolder = room11001;
            }
            if (holder == "11002")
            {
                boolHolder = room11002;
            }
            if (holder == "11003")
            {
                boolHolder = room11003;
            }
            if (holder == "11004")
            {
                boolHolder = room11004;
            }
            if (holder == "11005")
            {
                boolHolder = room11005;
            }
            if (holder == "12001")
            {
                boolHolder = room12001;
            }
            if (holder == "12002")
            {
                boolHolder = room12002;
            }
            if (holder == "12003")
            {
                boolHolder = room12003;
            }
            if (holder == "12004")
            {
                boolHolder = room12004;
            }
            if (holder == "12005")
            {
                boolHolder = room12005;
            }
            if (holder == "21001")
            {
                boolHolder = room21001;
            }
            if (holder == "21002")
            {
                boolHolder = room21002;
            }
            if (holder == "21003")
            {
                boolHolder = room21003;
            }
            if (holder == "21004")
            {
                boolHolder = room21004;
            }
            if (holder == "21005")
            {
                boolHolder = room21005;
            }
            if (holder == "22001")
            {
                boolHolder = room22001;
            }
            if (holder == "22002")
            {
                boolHolder = room22002;
            }
            if (holder == "22003")
            {
                boolHolder = room22003;
            }
            if (holder == "22004")
            {
                boolHolder = room22004;
            }
            if (holder == "22005")
            {
                boolHolder = room22005;
            }
            if (!boolHolder)
            {
                string query = "SELECT \"Person\".\"Name\", \"Person\".\"Surname\", \"Room\".\"RoomPhoneNo\",\"Customer\".\"NumberOfCustomer\", \"Reservation\".\"EntryDate\", \"Reservation\".\"ReleaseDate\" From \"HotelApplication\".\"Room\" INNER JOIN \"HotelApplication\".\"Customer\" ON \"Room\".\"CustomerBooked\" = \"Customer\".\"PersonID\"\r\nINNER JOIN \"HotelApplication\".\"Reservation\" ON \"Reservation\".\"ReservationNo\" = \"Customer\".\"ReservationNo\" INNER Join \"HotelApplication\".\"Person\" ON \"Customer\".\"PersonID\" = \"Person\".\"PersonID\" WHERE \"RoomNo\" = @RoomNo;";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.Add("@RoomNo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = holder;
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        name = reader["Name"].ToString();
                        surname = reader["Surname"].ToString();
                        phoneNo = reader["RoomPhoneNo"].ToString();
                        participant = int.Parse(reader["NumberOfCustomer"].ToString());
                        dateEntry = Convert.ToDateTime(reader["EntryDate"]).ToString("yyyy-MM-dd");
                        dateRelease = Convert.ToDateTime(reader["ReleaseDate"]).ToString("yyyy-MM-dd");
                    }
                }
                roomInfoForm.label10.Text = name;
                roomInfoForm.label6.Text = surname;
                roomInfoForm.label13.Text = phoneNo;
                roomInfoForm.label8.Text = dateEntry;
                roomInfoForm.label3.Text = dateRelease;
                roomInfoForm.label12.Text = participant.ToString();
                roomInfoForm.Dock = DockStyle.Fill;
                roomInfoForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Oda Boş");
            }
            connection.Close();
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label enteredLabel = sender as Label;

            // Fare etiketin üzerine geldiğinde rengini değiştir
            if (enteredLabel != null)
            {
                enteredLabel.BackColor = Color.FromArgb(51, 51, 51); // Örnek olarak mavi yapalım
            }
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label leftLabel = sender as Label;

            // Fare etiketten çıkınca renkleri geri al
            if (leftLabel != null)
            {
                leftLabel.BackColor = Color.FromArgb(41, 41, 41); // Kontrolün varsayılan rengine dön
            }
        }

    }
}
