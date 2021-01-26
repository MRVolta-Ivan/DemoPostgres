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
    public partial class AddOrder : Form
    {
        EmployeeRepository employee = new EmployeeRepository();
        ApplicantRepository applicant = new ApplicantRepository();
        TypeDocumentRepository typeDocument = new TypeDocumentRepository();
        RoomRepository room = new RoomRepository();
        DormitoryRepository dormitory = new DormitoryRepository();
        OrderRepository order = new OrderRepository();

        public AddOrder()
        {
            InitializeComponent();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            List<TypeDocument> type = typeDocument.GetAll();

            foreach (TypeDocument i in type)
                comboBoxTypeDocument.Items.Add(i.name);

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

            long idType = typeDocument.GetAll()[comboBoxTypeDocument.SelectedIndex].id;

            long idEmpl = employee.GetAll()[comboBoxEmployee.SelectedIndex].id;

            long idAppl;

            long idDorm;

            long idRoom;

            if (idType == 2)
            {
                idAppl = applicant.GetListTenant()[comboBoxApplicant.SelectedIndex].id;
                List<Order> last = order.GetLastOrder(idAppl);
                idDorm = last[0].dormitory;
                idRoom = last[0].room;
            }
            else
            {
                if (idType == 1)
                    idAppl = applicant.GetListNoTenant()[comboBoxApplicant.SelectedIndex].id;
                else
                    idAppl = applicant.GetListTenant()[comboBoxApplicant.SelectedIndex].id;

                idDorm = dormitory.getListFree()[comboBoxDormitory.SelectedIndex].id;
                idRoom = room.GetFreeRoomDormitory(idDorm)[comboBoxRoom.SelectedIndex].id;
            }

            order.Add(number, date, idType, idEmpl, idRoom, idDorm, idAppl);

            Close();
        }

        private void comboBoxDormitory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRoom.Enabled = true;

            comboBoxRoom.Items.Clear();

            List<Dormitory> dorm = dormitory.getListFree();

            List<Room> data = room.GetFreeRoomDormitory(dorm[comboBoxDormitory.SelectedIndex].id);

            foreach (Room i in data)
                comboBoxRoom.Items.Add(i.number);
        }

        private void comboBoxTypeDocument_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxApplicant.Enabled = true;

            comboBoxRoom.Enabled = false;

            comboBoxApplicant.Items.Clear();

            comboBoxDormitory.Items.Clear();

            comboBoxRoom.Items.Clear();

            List<TypeDocument> type = typeDocument.GetAll();

            List<Applicant> appl;

            if (type[comboBoxTypeDocument.SelectedIndex].id == 1)
                appl = applicant.GetListNoTenant();
            else
                appl = applicant.GetListTenant();

            if (type[comboBoxTypeDocument.SelectedIndex].id != 2)
                comboBoxDormitory.Enabled = true;
            else
                comboBoxDormitory.Enabled = false;

            foreach (Applicant i in appl)
                comboBoxApplicant.Items.Add(i.fio);

            List<Dormitory> dorm = dormitory.getListFree();

            foreach (Dormitory i in dorm)
                comboBoxDormitory.Items.Add(i.adress);
        }
    }
}
