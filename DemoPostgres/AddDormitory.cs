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
    public partial class AddDormitory : Form
    {
        TypeDormitoryRepository typeDormitory = new TypeDormitoryRepository();
        DormitoryRepository dormitory = new DormitoryRepository();
        RoomRepository room = new RoomRepository();

        public AddDormitory()
        {
            InitializeComponent();
        }

        private void AddDormitory_Load(object sender, EventArgs e)
        {
            List<TypeDormitory> type = typeDormitory.GetAll();

            foreach (TypeDormitory i in type)
                comboBoxTypeDormitory.Items.Add(i.name);

            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            string adress = textBoxAdressDormitory.Text;
            long countRoom;
            try
            {
                countRoom = Convert.ToInt64(textBoxCountRoomDormitory.Text);
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

            string condition = textBoxConditionDormitory.Text;

            List<TypeDormitory> type = typeDormitory.GetAll();
            int idTypeDormitory = comboBoxTypeDormitory.SelectedIndex;

            double costRoomDormitory;

            try
            {
                costRoomDormitory = Convert.ToDouble(textBoxPay.Text);
            }
            catch (Exception ex)
            {
                string message = "Неправильный ввод поля стоимость комнат!";
                string caption = "Ошибка!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                return;
            }

            long idDormitory = dormitory.AddDormitory(adress, countRoom, condition, type[idTypeDormitory].id);

            for (int i = 0; i < countRoom; i++)
            {
                long number = 101 + i;
                room.AddRoom(number.ToString(), costRoomDormitory, idDormitory);
            }

            Close();
        }
    }
}
