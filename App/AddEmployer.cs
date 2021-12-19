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
    public partial class AddEmployer : Form
    {
        public AddEmployer()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Check check = new Check(Text_Surname.Text, 
                                    Text_Name.Text, 
                                    Text_Patronymic.Text,
                                    Text_Passport.Text,
                                    Text_Post.Text);
            if (check.AllCheck())
            {
                TalkWithBD.AddNewEmployer(Text_Name.Text.Trim(), Text_Surname.Text.Trim(), Text_Patronymic.Text.Trim(), Text_Passport.Text, Text_Post.Text);
                Text_Surname.Text = "";
                Text_Name.Text = "";
                Text_Patronymic.Text = "";
                Text_Passport.Text = "";
                Text_Post.Text = "";
                MessageBox.Show("Работник добавлен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else MessageBox.Show("Вы где то допустили ошибку или неверно ввели какое то поле ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}