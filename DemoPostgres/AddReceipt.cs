using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoPostgres
{
    public partial class AddReceipt : Form
    {
        ApplicantRepository applicant = new ApplicantRepository();
        EmployeeRepository employee = new EmployeeRepository();
        OrderRepository order = new OrderRepository();
        RoomRepository room = new RoomRepository();
        ReceiptRepository receipt = new ReceiptRepository();

        public AddReceipt()
        {
            InitializeComponent();
        }

        private void AddReceipt_Load(object sender, EventArgs e)
        {
            List<Applicant> appl = applicant.GetListTenant();

            foreach (Applicant i in appl)
                comboBoxApplicant.Items.Add(i.fio);

            List<Employee> empl = employee.GetAll();

            foreach (Employee i in empl)
                comboBoxEmployee.Items.Add(i.fio);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            string number = textBoxNumber.Text;

            string date = dateTimePicker.Text;

            long idappl = applicant.GetListTenant()[comboBoxApplicant.SelectedIndex].id;

            long idempl = employee.GetAll()[comboBoxEmployee.SelectedIndex].id;

            List<Order> ord = order.GetLastOrder(idappl);

            long iddorm = ord[0].dormitory;

            long idroom = ord[0].room;

            double summ = 0;

            List<Room> rooms = room.GetRoomDormitory(iddorm);

            foreach (Room i in rooms)
                if (idroom == i.id)
                {
                    summ = i.pay;
                    break;
                }

            receipt.Add(number, date, summ, idempl, idroom, iddorm, idappl);

            Close();
        }
    }
}
