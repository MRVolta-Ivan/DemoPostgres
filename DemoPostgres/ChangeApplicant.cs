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
    public partial class ChangeApplicant : Form
    {
        Applicant appl;

        ApplicantRepository applicant = new ApplicantRepository();

        public ChangeApplicant(Applicant _appl)
        {
            InitializeComponent();
            appl = _appl;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            appl.adress = textBoxAdress.Text;
            appl.fio = textBoxFIO.Text;
            appl.numberTelephone = maskedTextBoxNumber.Text;

            applicant.Change(appl.fio, appl.numberTelephone, appl.adress, appl.id);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeApplicant_Load(object sender, EventArgs e)
        {
            textBoxFIO.Text = appl.fio;
            maskedTextBoxNumber.Text = appl.numberTelephone;
            textBoxAdress.Text = appl.adress;
        }
    }
}
