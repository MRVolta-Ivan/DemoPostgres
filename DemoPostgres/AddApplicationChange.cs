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
    public partial class AddApplicationChange : Form
    {
        List<Employee> employees = new List<Employee>();
        EmployeeRepository employeeRepository = new EmployeeRepository();

        ApplicantRepository applicantRepository = new ApplicantRepository();
        List<Applicant> applicant = new List<Applicant>();

        ApplicationRepository applicationRepository = new ApplicationRepository();

        TypeDocumentRepository typeDocumentRepository = new TypeDocumentRepository();
        List<TypeDocument> typeDocuments = new List<TypeDocument>();


        public AddApplicationChange()
        {
            InitializeComponent();
        }

        private void AddApplicationChange_Load(object sender, EventArgs e)
        {
            // загрузка сотрудников
            employees = employeeRepository.GetAll();

            foreach (var employee in employees)
            {
                comboBoxEmployee.Items.Add(employee.fio);
            }


            // загрузка типов документов
            typeDocuments = typeDocumentRepository.GetAll();

            foreach (var typeDocs in typeDocuments)
            {
                if (typeDocs.id != 1)
                    comboBoxTypeDocument.Items.Add(typeDocs.name);
            }


            // загрузка заявителей
            applicant = applicantRepository.GetListTenant();
            
            foreach (var applicants in applicant)
            {
                comboBoxApplicant.Items.Add(applicants.fio);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int idEmployee = comboBoxEmployee.SelectedIndex;

            int idTypeDoc = comboBoxTypeDocument.SelectedIndex;

            int idApplicant = comboBoxApplicant.SelectedIndex;

            long idApplicantion = applicationRepository.AddApplication(textBoxNumber.Text, dateTimePickerDate.Text, typeDocuments[idTypeDoc + 1].id, employees[idEmployee].id, applicant[idApplicant].id);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}