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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            Check check = new Check(Text_Name.Text, Text_Surname.Text, Text_Patronymic.Text, Text_Passport.Text, Text_Login.Text, Text_Pass1.Text, Text_Pass2.Text);

            if (check.AllCheck())
            {
                RegisterToDb register = new RegisterToDb(Text_Name.Text, Text_Surname.Text, Text_Patronymic.Text, Text_Passport.Text, Text_Login.Text, Text_Pass1.Text, Check_Adm.Checked);
                register.ToDb();
                MessageBox.Show("Вы зарегистрированы", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Register().Close();
            }
            else MessageBox.Show("Вы где то допустили ошибку или неверно ввели какое то поле ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
