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
    public partial class ChangeRoom : Form
    {
        Room r;

        RoomRepository room = new RoomRepository();

        public ChangeRoom(Room _r)
        {
            InitializeComponent();
            r = _r;
        }

        private void ChangeRoom_Load(object sender, EventArgs e)
        {
            textBoxNumber.Text = r.number;
            textBoxCost.Text = r.pay.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            r.number = textBoxNumber.Text;

            try
            {
                r.pay = Convert.ToDouble(textBoxCost.Text);
            }
            catch (Exception ex)
            {
                string message = "Неправильный ввод поля количество комнат!";
                string caption = "Ошибка!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                return;
            }

            room.Change(r.number, r.pay, r.id);

            Close();
        }
    }
}
