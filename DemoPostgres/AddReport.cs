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
    public partial class AddReport : Form
    {
        DormitoryRepository dormitory = new DormitoryRepository();
        InspectorRepository inspector = new InspectorRepository();
        ReportRepository report = new ReportRepository();

        public AddReport()
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

            string fire = textBoxFire.Text;

            string system = textBoxSystem.Text;

            string general = textBoxGeneral.Text;

            long idinsp = inspector.GetAll()[comboBoxInspector.SelectedIndex].id;

            long iddorm = dormitory.GetListDormitory()[comboBoxDormitory.SelectedIndex].id;

            report.Add(number, date, fire, system, general, idinsp, iddorm);

            Close();
        }

        private void AddReport_Load(object sender, EventArgs e)
        {
            List<Inspector> insp = inspector.GetAll();

            foreach (Inspector i in insp)
                comboBoxInspector.Items.Add(i.fio);

            List<Dormitory> dorm = dormitory.GetListDormitory();

            foreach (Dormitory i in dorm)
                comboBoxDormitory.Items.Add(i.adress);
        }
    }
}
