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
    public partial class AddApplicationSet : Form
    {
        List<Employee> employees = new List<Employee>();
        EmployeeRepository employeeRepository = new EmployeeRepository();
        ApplicantRepository applicantRepository = new ApplicantRepository();
        ApplicationRepository applicationRepository = new ApplicationRepository();

        public AddApplicationSet()
        {
            InitializeComponent();
        }

        private void AddApplicationSet_Load(object sender, EventArgs e)
        {
            employees = employeeRepository.GetAll();

            foreach (var employee in employees)
            {
                comboBoxEmployee.Items.Add(employee.fio);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            long idApplicant = applicantRepository.AddApplicant(textBoxFIO.Text, maskedTextBoxNumberPhone.Text, textBoxAdress.Text);

            int idEmployee = comboBoxEmployee.SelectedIndex;
            long idApplicantion = applicationRepository.AddApplication(textBoxNumberApplication.Text, dateTimePickerDateApplication.Text, 1, employees[idEmployee].id, idApplicant);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}