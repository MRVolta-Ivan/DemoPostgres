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
    public partial class AddPermission : Form
    {
        EmployeeRepository employee = new EmployeeRepository();
        ApplicantRepository applicant = new ApplicantRepository();
        OrderRepository order = new OrderRepository();
        PermissionRepository permission = new PermissionRepository();

        public AddPermission()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            string number = textBoxNumber.Text;

            string date = dateTimePicker.Text;

            long idempl = employee.GetAll()[comboBoxEmployee.SelectedIndex].id;

            long idappl = applicant.GetListTenant()[comboBoxApplicant.SelectedIndex].id;

            List<Order> ord = order.GetLastOrder(idappl);

            long iddorm = ord[0].dormitory;
            long idroom = ord[0].room;

            permission.Add(number, date, idempl, idroom, iddorm, idappl);

            Close();
        }

        private void AddPermission_Load(object sender, EventArgs e)
        {
            comboBoxEmployee.Items.Clear();
            comboBoxApplicant.Items.Clear();

            List<Employee> empl = employee.GetAll();

            foreach (Employee i in empl)
                comboBoxEmployee.Items.Add(i.fio);

            List<Applicant> appl = applicant.GetListTenant();

            foreach (Applicant i in appl)
                comboBoxApplicant.Items.Add(i.fio);
                
        }
    }
}
