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
            bool registration = true;
            string login = Text_Login.Text;
            string pass1 = Text_Pass1.Text;
            string pass2 = Text_Pass2.Text;

            if (Text_Login.Text.Length == 0 || Text_Name.Text.Length == 0 || Text_Pass1.Text.Length == 0 || Text_Pass2.Text.Length == 0 || Text_Passport.Text.Length == 0 || Text_Patronymic.Text.Length == 0 || Text_Surname.Text.Length == 0) 
            {
                MessageBox.Show("Заполены не все поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                registration = false;
            }

            if (!NoSpecialCharacters(login) || !NoSpecialCharacters(pass1))
            {
                MessageBox.Show("Присутствуют недопустимые символы в Логин или Пароль ","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                registration = false;
            }

            if (!String.Equals(pass1, pass2))
            {
                MessageBox.Show("Пароли не совпадают","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                registration = false;
            }

            if(OnlyRussia(Text_Name.Text) && OnlyRussia(Text_Surname.Text) && OnlyRussia(Text_Patronymic.Text))
            {
                MessageBox.Show("ФИО содержит НЕ русские буквы","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                registration = false;
            }

            if (Text_Passport.Text.Length != 10 && OnlyNumber(Text_Passport.Text))
            {
                MessageBox.Show("Серия и Номер паспорта введены неккоректно","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                registration = false;
            }

            if (registration)
            {
                RegisterToDb register = new RegisterToDb(Text_Name.Text, Text_Surname.Text, Text_Patronymic.Text, Text_Passport.Text, Text_Login.Text, Text_Pass1.Text, Check_Adm.Checked);
                register.ToDb();
                MessageBox.Show("Вы зарегистрированы", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public static bool NoSpecialCharacters(string str)
        {
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();

            int index = str.IndexOfAny(specialCharactersArray);
            if (index == -1)
                return true;
            else
                return false;
        }

        public static bool OnlyRussia(string str)
        {
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"" + "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            char[] specialCharactersArray = specialCharacters.ToCharArray();

            int index = str.IndexOfAny(specialCharactersArray);
            if (index == -1)
                return false;
            else
                return true;
        }

        public static bool OnlyNumber(string str)
        {
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"" + "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            char[] specialCharactersArray = specialCharacters.ToCharArray();

            int index = str.IndexOfAny(specialCharactersArray);
            if (index == -1)
                return true;
            else
                return false;
        }

    }
}
