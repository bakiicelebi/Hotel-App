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
    public partial class FormEmployee : Form
    {
        FormEmployeePop employeePop;
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void ViewEmployee_Click(object sender, EventArgs e)
        {
            employeePop = new FormEmployeePop();
            employeePop.Dock = DockStyle.Fill;
            Button button = sender as Button;
            string buttonValue = button.Name;
            switch(buttonValue)
            {
                case "buttonManager":
                    employeePop.event1 = "Manager\".\"Title";
                    employeePop.event2 = "Manager\".\"OfficeNo";
                    employeePop.event3 = "Manager\".\"SecretaryNo";
                    employeePop.employeeType = "Manager";
                    employeePop.label1.Text = "Manager" + employeePop.label1.Text;
                    break;
                case "buttonHousekeeper":
                    employeePop.event1 = "Housekeeper\".\"FloorNo";
                    employeePop.employeeType = "Housekeeper";
                    employeePop.label1.Text = "Manager" + employeePop.label1.Text;
                    break;
                case "buttonCook":
                    employeePop.event1 = "Cook\".\"Degree";
                    employeePop.employeeType = "Cook";
                    employeePop.label1.Text = "Cook" + employeePop.label1.Text;
                    break;
                case "buttonWaiter":
                    employeePop.event1 = "Waiter\".\"Degree";
                    employeePop.employeeType = "Waiter";
                    employeePop.label1.Text = "Waiter" + employeePop.label1.Text;
                    break;
                case "buttonValet":
                    employeePop.event1 = "Valet\".\"ParkNo";
                    employeePop.employeeType = "Valet";
                    employeePop.label1.Text = "Valet" + employeePop.label1.Text;
                    break;
                case "buttonSecretary":
                    employeePop.event1 = "Secretary\".\"OfficeNo";
                    employeePop.employeeType = "Secretary";
                    employeePop.label1.Text = "Secretary" + employeePop.label1.Text;
                    break;
                case "buttonLifeguard":
                    employeePop.event1 = "Lifeguard\".\"LicenseNo";
                    employeePop.employeeType = "Lifeguard";
                    employeePop.label1.Text = "Lifeguard" + employeePop.label1.Text;
                    break;
                case "buttonReceptionist":
                    employeePop.event1 = "Receptionist\".\"Degree";
                    employeePop.employeeType = "Receptionist";
                    employeePop.label1.Text = "Receptionist" + employeePop.label1.Text;
                    break;
                case "buttonCourier":
                    employeePop.event1 = "Courier\".\"Plate";
                    employeePop.employeeType = "Courier";
                    employeePop.label1.Text = "Courier" + employeePop.label1.Text;
                    break;
                    default: break;
            }


            employeePop.Show();
        }
    }
}
