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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            ComboBoxReFrash();
        }

        public int CurID { get; set; }

        private List<Employer> employers = new List<Employer>() {new Employer() };

        public void ComboBoxReFrash()
        {
            ChooseEmployer.Items.Clear();

            for(int i = 1; i <= TalkWithBD.GetLastID(); i++)
            {
                employers.Add(new Employer(TalkWithBD.GetAllAboutEmployerFromID(i)));
                ChooseEmployer.Items.Add($"{employers[i].surname}");
            }
        }

        private void Btn_AddEmp_Click(object sender, EventArgs e)
        {
            new AddEmployer().Show();
        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= TalkWithBD.GetLastID(); i++)
            {
                employers.Add(new Employer(TalkWithBD.GetAllAboutEmployerFromID(i)));
            }

            CurID = ChooseEmployer.SelectedIndex + 1;
            Label_FIO.Text = $"{employers[CurID].surname} {employers[CurID].name} {employers[CurID].patronym}";

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ComboBoxReFrash();
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"Итого к выплате {employers[CurID].Salary()}") ;
        }

    }
}
