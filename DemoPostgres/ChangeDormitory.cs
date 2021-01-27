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
    public partial class ChangeDormitory : Form
    {
        private Dormitory dorm;

        DormitoryRepository dormitory = new DormitoryRepository();

        public ChangeDormitory(Dormitory _dorm)
        {
            InitializeComponent();
            dorm = _dorm;
        }

        private void ChangeDormitory_Load(object sender, EventArgs e)
        {
            textBoxAdress.Text = dorm.adress;
            textBoxCondition.Text = dorm.condition;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            dorm.adress = textBoxAdress.Text;
            dorm.condition = textBoxCondition.Text;

            dormitory.Change(dorm.adress, dorm.countRoom, dorm.condition, dorm.id);

            Close();
        }
    }
}
