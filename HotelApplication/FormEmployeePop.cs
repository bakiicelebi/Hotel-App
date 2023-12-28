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

namespace HotelApplication
{
    public partial class FormEmployeePop : Form
    {
        public string event1 = null;
        public string event2 = null;
        public string event3 =  null;
        public string employeeType = "";


        NpgsqlConnection connection;
        public FormEmployeePop()
        {
            InitializeComponent();

        }

        private void FormEmployeePop_Load(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection("Host=127.0.0.1;Port=5432;Username=postgres;Password=1111;Database=HotelApplication"); // CONNECTION DEFINITION
            
            LoadData();
        }

        private void LoadData()
        {

            connection.Open();
            string sqlQuery = "SELECT \"Person\".\"Name\", \"Person\".\"Surname\", \"Person\".\"PhoneNo\" ,\"Employee\".\"EmployeeNo\", \"EmployeeCardNo\" , \"Employee\".\"ShiftStart\", \"Employee\".\"OffDay\"";

            if (event1 != null)
            {
                sqlQuery += ", \"" + event1 + "\"";
            }

            if (event2 != null)
            {
                sqlQuery += ", \"" + event2 + "\"";
            }

            if (event3 != null)
            {
                sqlQuery += ", \"" + event3 + "\"";
            }

            sqlQuery += " From \"HotelApplication\".\"" + employeeType + "\" INNER JOIN \"HotelApplication\".\"Employee\" ON \"" + employeeType + "\".\"PersonID\" = \"Employee\".\"PersonID\" INNER JOIN \"HotelApplication\".\"Person\" ON \"Employee\".\"PersonID\" = \"Person\".\"PersonID\" ORDER BY \"EmployeeNo\";";

            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlQuery, connection))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            connection.Close();
        }
    }
}
