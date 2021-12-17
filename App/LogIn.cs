using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            Load_Settings();
        }

        public void Load_Settings()
        {
            Text_Password.UseSystemPasswordChar = true;
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            new Register().Show();
        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            string login = Text_Login.Text;
            string password = Text_Password.Text;
            Check check = new Check(login, password);

            if (check.Check_LogIn())
            {
                if (TalkWithBD.CompareWithDb("login", login) && TalkWithBD.CompareWithDb("password", password))
                    MessageBox.Show($"Вы успешно вошли ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else MessageBox.Show("Вы не вошли", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Логин не корректный", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
