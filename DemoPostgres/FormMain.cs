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

namespace DemoPostgres
{
    public partial class FormMain : Form
    {
        bool exit;

        Form loginForm;

        ApplicantRepository applicant = new ApplicantRepository();
        DormitoryRepository dormitory = new DormitoryRepository();
        RoomRepository room = new RoomRepository();
        EmployeeRepository employee = new EmployeeRepository();
        Inspectorrepository inspector = new Inspectorrepository();

        ApplicationRepository application = new ApplicationRepository();
        PermissionRepository permission = new PermissionRepository();
        OrderRepository order = new OrderRepository();
        ReceiptRepository receipt = new ReceiptRepository();
        ReportRepository report = new ReportRepository();

        TypeDormitoryRepository typeDormitory = new TypeDormitoryRepository();
        TypeDocumnetRepository typeDocument = new TypeDocumnetRepository();

        public FormMain(Form _loginForm)
        {
            InitializeComponent();
            exit = true;
            loginForm = _loginForm;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            DBConnection.instance.CloseCon();

            if (exit)
                Application.Exit();
            else
                loginForm.Show();

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit = false;
            Close();
        }

        private void MapperApplicant(List<Applicant> data)
        {
            dataGrid.ContextMenuStrip = null;

            dataGrid.Rows.Clear();

            dataGrid.ColumnCount = 4;

            dataGrid.Columns[0].Name = "ID";
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].Name = "ФИО";
            dataGrid.Columns[2].Name = "Номер телефона";
            dataGrid.Columns[3].Name = "Адрес";

            foreach (Applicant i in data)
            {
                dataGrid.Rows.Add(i.id, i.fio, i.nuberTelephone, i.adress);
            }
        }

        private void AllApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<Applicant> data = applicant.GetListApplicant();

            MapperApplicant(data);
        }

        private void TenantToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<Applicant> data = applicant.GetListTenant();

            MapperApplicant(data);
        }

        private void PaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<Applicant> data = applicant.GetListPayment();

            MapperApplicant(data);
        }

        private void MapperDormitory(List<Dormitory> data)
        {
            dataGrid.ContextMenuStrip = contextDormitoryMenuGridData;

            dataGrid.Rows.Clear();

            dataGrid.ColumnCount = 5;

            dataGrid.Columns[0].Name = "ID";
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].Name = "Адрес";
            dataGrid.Columns[2].Name = "Количество комнат";
            dataGrid.Columns[3].Name = "Условия проживания";
            dataGrid.Columns[4].Name = "Тип общежития";

            List<TypeDormitory> type = typeDormitory.GetAll();

            Dictionary<long, string> typeD = new Dictionary<long, string>();

            foreach (TypeDormitory i in type)
            {
                typeD[i.id] = i.name;
            }

            foreach (Dormitory i in data)
            {
                dataGrid.Rows.Add(i.id, i.adress, i.countRoom, i.condition, typeD[i.typeDormitory]);
            }
        }

        private void AllDormitoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<Dormitory> data = dormitory.GetListDormitory();

            MapperDormitory(data);
        }

        private void CheckDormitoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            List<Dormitory> data = dormitory.GetListCheck();

            MapperDormitory(data);
        }

        private void FreeDormitoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<Dormitory> data = dormitory.getListFree();

            MapperDormitory(data);
        }

        private void ApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGrid.ContextMenuStrip = null;

            dataGrid.Rows.Clear();

            dataGrid.ColumnCount = 6;

            dataGrid.Columns[0].Name = "ID";
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].Name = "Номер заявления";
            dataGrid.Columns[2].Name = "Дата заявления";
            dataGrid.Columns[3].Name = "Тип документа";
            dataGrid.Columns[4].Name = "Сотрудник";
            dataGrid.Columns[5].Name = "Заявитель";

            List<ApplicationDoc> data = application.GetAll();

            List<TypeDocument> type = typeDocument.GetAll();

            Dictionary<long, string> typeD = new Dictionary<long, string>();

            foreach (TypeDocument i in type)
            {
                typeD[i.id] = i.name;
            }

            List<Employee> empl = employee.GetAll();

            Dictionary<long, string> emplD = new Dictionary<long, string>();

            foreach (Employee i in empl)
            {
                emplD[i.id] = i.fio;
            }

            List<Applicant> app = applicant.GetListApplicant();

            Dictionary<long, string> appD = new Dictionary<long, string>();

            foreach (Applicant i in app)
            {
                appD[i.id] = i.fio;
            }

            foreach (ApplicationDoc i in data)
            {
                dataGrid.Rows.Add(i.id, i.numberApplication, i.date, typeD[i.typeDocument], emplD[i.employee], appD[i.applicant]);
            }
        }

        private void PermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dataGrid.ContextMenuStrip = null;

            dataGrid.Rows.Clear();

            dataGrid.ColumnCount = 7;

            dataGrid.Columns[0].Name = "ID";
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].Name = "Номер разрешения";
            dataGrid.Columns[2].Name = "Дата разрешения";
            dataGrid.Columns[3].Name = "Сотрудник";
            dataGrid.Columns[4].Name = "Комната";
            dataGrid.Columns[5].Name = "Общежитие";
            dataGrid.Columns[6].Name = "Заявитель";

            List<Permission> data = permission.GetAll();

            List<Employee> empl = employee.GetAll();

            Dictionary<long, string> emplD = new Dictionary<long, string>();

            foreach (Employee i in empl)
            {
                emplD[i.id] = i.fio;
            }

            List<Room> r = room.GetAll();

            Dictionary<long, string> rD = new Dictionary<long, string>();

            foreach (Room i in r)
            {
                rD[i.id] = i.number;
            }

            List<Dormitory> dorm = dormitory.GetListDormitory();

            Dictionary<long, string> dormD = new Dictionary<long, string>();

            foreach (Dormitory i in dorm)
            {
                dormD[i.id] = i.adress;
            }

            List<Applicant> app = applicant.GetListApplicant();

            Dictionary<long, string> appD = new Dictionary<long, string>();

            foreach (Applicant i in app)
            {
                appD[i.id] = i.fio;
            }

            foreach (Permission i in data)
            {
                dataGrid.Rows.Add(i.id, i.numberPermission, i.date, emplD[i.employee], rD[i.room], dormD[i.dormitory], appD[i.applicant]);
            }
        }

        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGrid.ContextMenuStrip = null;

            dataGrid.Rows.Clear();

            dataGrid.ColumnCount = 8;

            dataGrid.Columns[0].Name = "ID";
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].Name = "Номер приказа";
            dataGrid.Columns[2].Name = "Дата приказа";
            dataGrid.Columns[3].Name = "Тип документа";
            dataGrid.Columns[4].Name = "Сотрудник";
            dataGrid.Columns[5].Name = "Комната";
            dataGrid.Columns[6].Name = "Общежитие";
            dataGrid.Columns[7].Name = "Заявитель";
            
            List<Order> data = order.GetAll();

            List<TypeDocument> type = typeDocument.GetAll();

            Dictionary<long, string> typeD = new Dictionary<long, string>();

            foreach (TypeDocument i in type)
            {
                typeD[i.id] = i.name;
            }

            List<Employee> empl = employee.GetAll();

            Dictionary<long, string> emplD = new Dictionary<long, string>();

            foreach (Employee i in empl)
            {
                emplD[i.id] = i.fio;
            }

            List<Room> r = room.GetAll();

            Dictionary<long, string> rD = new Dictionary<long, string>();

            foreach (Room i in r)
            {
                rD[i.id] = i.number;
            }

            List<Dormitory> dorm = dormitory.GetListDormitory();

            Dictionary<long, string> dormD = new Dictionary<long, string>();

            foreach (Dormitory i in dorm)
            {
                dormD[i.id] = i.adress;
            }

            List<Applicant> app = applicant.GetListApplicant();

            Dictionary<long, string> appD = new Dictionary<long, string>();

            foreach (Applicant i in app)
            {
                appD[i.id] = i.fio;
            }

            foreach (Order i in data)
            {
                dataGrid.Rows.Add(i.id, i.number, i.date, typeD[i.typeDocument], emplD[i.employee], rD[i.room], dormD[i.dormitory], appD[i.applicant]);
            }
        }

        private void ReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGrid.ContextMenuStrip = null;

            dataGrid.Rows.Clear();

            dataGrid.ColumnCount = 8;

            dataGrid.Columns[0].Name = "ID";
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].Name = "Номер квитанции";
            dataGrid.Columns[2].Name = "Дата квитанции";
            dataGrid.Columns[3].Name = "Сумма";
            dataGrid.Columns[4].Name = "Сотрудник";
            dataGrid.Columns[5].Name = "Комната";
            dataGrid.Columns[6].Name = "Общежитие";
            dataGrid.Columns[7].Name = "Заявитель";

            List<Receipt> data = receipt.GetAll();

            List<Employee> empl = employee.GetAll();

            Dictionary<long, string> emplD = new Dictionary<long, string>();

            foreach (Employee i in empl)
            {
                emplD[i.id] = i.fio;
            }

            List<Room> r = room.GetAll();

            Dictionary<long, string> rD = new Dictionary<long, string>();

            foreach (Room i in r)
            {
                rD[i.id] = i.number;
            }

            List<Dormitory> dorm = dormitory.GetListDormitory();

            Dictionary<long, string> dormD = new Dictionary<long, string>();

            foreach (Dormitory i in dorm)
            {
                dormD[i.id] = i.adress;
            }

            List<Applicant> app = applicant.GetListApplicant();

            Dictionary<long, string> appD = new Dictionary<long, string>();

            foreach (Applicant i in app)
            {
                appD[i.id] = i.fio;
            }

            foreach (Receipt i in data)
            {
                dataGrid.Rows.Add(i.id, i.number, i.date, i.summ, emplD[i.employee], rD[i.room], dormD[i.dormitory], appD[i.applicant]);
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGrid.ContextMenuStrip = null;

            dataGrid.Rows.Clear();

            dataGrid.ColumnCount = 8;

            dataGrid.Columns[0].Name = "ID";
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].Name = "Номер отчёта";
            dataGrid.Columns[2].Name = "Дата отчёта";
            dataGrid.Columns[3].Name = "Оценка пожаробезопасности";
            dataGrid.Columns[4].Name = "Оценка состояния систем";
            dataGrid.Columns[5].Name = "Оценка состояния дома";
            dataGrid.Columns[6].Name = "Инспектор";
            dataGrid.Columns[7].Name = "Общежитие";

            List<Report> data = report.GetAll();

            List<Inspector> insp = inspector.GetAll();

            Dictionary<long, string> inspD = new Dictionary<long, string>();

            foreach (Inspector i in insp)
            {
                inspD[i.id] = i.fio;
            }

            List<Dormitory> dorm = dormitory.GetListDormitory();

            Dictionary<long, string> dormD = new Dictionary<long, string>();

            foreach (Dormitory i in dorm)
            {
                dormD[i.id] = i.adress;
            }

            foreach (Report i in data)
            {
                dataGrid.Rows.Add(i.id, i.number, i.date, i.fire, i.system, i.condition, inspD[i.inspector], dormD[i.dormitory]);
            }
        }

        private void MapperRoom(List<Room> data)
        {
            dataGrid.ContextMenuStrip = null;

            dataGrid.Rows.Clear();

            dataGrid.ColumnCount = 4;

            dataGrid.Columns[0].Name = "ID";
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].Name = "Номер комнаты";
            dataGrid.Columns[2].Name = "Оплата";
            dataGrid.Columns[3].Name = "Общежитие";

            List<Dormitory> dorm = dormitory.GetListDormitory();

            Dictionary<long, string> dormD = new Dictionary<long, string>();

            foreach (Dormitory i in dorm)
            {
                dormD[i.id] = i.adress;
            }

            foreach (Room i in data)
            {
                dataGrid.Rows.Add(i.id, i.number, i.pay, dormD[i.dormitory]);
            }
        }

        private void ShowAllRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long index = Convert.ToInt64(dataGrid.SelectedCells[0].Value);

            List<Room> data = room.GetRoomDormitory(index);

            MapperRoom(data);
        }

        private void ShowFreeRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long index = Convert.ToInt64(dataGrid.SelectedCells[0].Value);

            List<Room> data = room.GetFreeRoomDormitory(index);

            MapperRoom(data);
        }
    }
}
