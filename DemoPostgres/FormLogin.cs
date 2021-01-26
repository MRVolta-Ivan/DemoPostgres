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
    public partial class FormLogin : Form
    {
       

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                DBConnection.instance.Init(LoginBox.Text, PasswordBox.Text);

                FormMain main = new FormMain(this);
                main.Show();
                Hide();
            }
            catch (Exception ex)
            {
                string message = "Неправильный логин или пароль!";
                string caption = "Ошибка!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
