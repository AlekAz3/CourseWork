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
            Load_Settings();
        }

        public void Load_Settings()
        {
            Text_Pass1.UseSystemPasswordChar = true;
            Text_Pass2.UseSystemPasswordChar = true;
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            Check check = new Check(Text_Name.Text, 
                                    Text_Surname.Text, 
                                    Text_Patronymic.Text, 
                                    Text_Passport.Text, 
                                    Text_Login.Text, 
                                    Text_Pass1.Text, 
                                    Text_Pass2.Text);
            if (check.AllCheck())
            {
                TalkWithBD.AddNewEmployer(Text_Name.Text, Text_Surname.Text, Text_Patronymic.Text, Text_Passport.Text, Text_Login.Text, Text_Pass1.Text);
                new Register().Close();
                MessageBox.Show("Вы зарегистрированы", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else MessageBox.Show("Вы где то допустили ошибку или неверно ввели какое то поле ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

