using System.Drawing;
using Npgsql;
namespace HotelApplication
{

    public partial class Form1 : Form
    {

        private const int sidebarWidth = 200;
        private const int animationSpeed = 4;
        private bool isSidebarOpen = false;
        private RoomForm roomsForm;
        private FormEmployee employeeForm;
        private FormListing listingForm;
        private FormService serviceForm;
        private FormStart startForm;
        private bool roomsFormIsActive = false;
        private bool employeeFormIsActive = false;
        private bool listingFormIsActive = false;
        private bool serviceFormIsActive = false;
        public NpgsqlConnection connection;
        public string dbName = "";
        public string psword = "";
        public string port = "";

        public Form1()
        {
            InitializeComponent();
            StartForm();
            CloseSidebar();
            OpenConnection();
            roomsForm = new RoomForm();
            roomsForm.TopLevel = false;
            roomsForm.FormBorderStyle = FormBorderStyle.None;
            roomsForm.Dock = DockStyle.Fill;
            employeeForm = new FormEmployee();
            employeeForm.TopLevel = false;
            employeeForm.FormBorderStyle = FormBorderStyle.None;
            employeeForm.Dock = DockStyle.Fill;
            listingForm = new FormListing();
            listingForm.TopLevel = false;
            listingForm.FormBorderStyle = FormBorderStyle.None;
            listingForm.Dock = DockStyle.Fill;
            serviceForm = new FormService();
            serviceForm.TopLevel = false;
            serviceForm.FormBorderStyle = FormBorderStyle.None;
            serviceForm.Dock = DockStyle.Fill;

        }
        private void StartForm()
        {
            startForm = new FormStart();
            startForm.ShowDialog();
            dbName = startForm.textBox1.Text;
            port = startForm.textBox2.Text;
            psword = startForm.textBox3.Text;
            try
            {
                connection = new NpgsqlConnection("Host=127.0.0.1;Port=" + port + ";Username=postgres;Password=" + psword + ";Database=" + dbName);            // CONNECTION DEFINITION
            }
            catch
            {
                MessageBox.Show("Try Again", "Warning");
                StartForm();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            if (connection.State == System.Data.ConnectionState.Open)
            {
                labelConnectTest.Visible = true;
            }
        }

        private void OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void menuToggle_Click(object sender, EventArgs e)
        {
            if (isSidebarOpen)
                CloseSidebarSmoothly();
            else
                OpenSidebarSmoothly();
        }

        private void CloseSidebar()
        {
            panelSidebar.Width = 75;
            isSidebarOpen = false;
            hotelLogo.Visible = false;
        }

        private void OpenSidebarSmoothly()
        {
            timeSidebarOpen.Start();
            hotelLogo.Visible = true;
        }

        private void CloseSidebarSmoothly()
        {
            timeSidebarClose.Start();
        }

        private void timeSidebarOpen_Tick_1(object sender, EventArgs e)
        {
            if (panelSidebar.Width < sidebarWidth)
            {
                panelSidebar.Width += animationSpeed;
            }
            else
            {
                timeSidebarOpen.Stop();
                isSidebarOpen = true;
            }
        }

        private void timeSidebarClose_Tick_1(object sender, EventArgs e)
        {
            if (panelSidebar.Width > 75)
            {
                panelSidebar.Width -= animationSpeed;
            }
            else
            {
                timeSidebarClose.Stop();
                isSidebarOpen = false;
            }
            if (panelSidebar.Width == 75)
                hotelLogo.Visible = false;
        }

        private void serviceButton_Click(object sender, EventArgs e)
        {
            employeeFormIsActive = false;
            listingFormIsActive = false;
            roomsFormIsActive = false;
            if (!serviceFormIsActive)
            {
                hotelHome.Controls.Clear();
                hotelHome.Controls.Add(serviceForm);
                serviceForm.Show();
                serviceFormIsActive = true;
            }
        }

        private void roomsButton_Click(object sender, EventArgs e)
        {
            employeeFormIsActive = false;
            listingFormIsActive = false;
            serviceFormIsActive = false;
            if (!roomsFormIsActive)
            {
                hotelHome.Controls.Clear();
                hotelHome.Controls.Add(roomsForm);
                roomsForm.Show();

                roomsFormIsActive = true;
            }
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            roomsFormIsActive = false;
            listingFormIsActive = false;
            serviceFormIsActive = false;
            if (!employeeFormIsActive)
            {
                hotelHome.Controls.Clear();
                hotelHome.Controls.Add(employeeForm);
                employeeForm.Show();
                employeeFormIsActive = true;
            }
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            roomsFormIsActive = false;
            employeeFormIsActive = false;
            serviceFormIsActive = false;
            if (!listingFormIsActive)
            {
                hotelHome.Controls.Clear();
                hotelHome.Controls.Add(listingForm);
                listingForm.Show();
                listingFormIsActive = true;
            }
        }
    }

}

