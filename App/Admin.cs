using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Admin : Form
    {
        private TalkWithBD talkWithBD = new TalkWithBD();

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

            for(int i = 1; i <= talkWithBD.GetLastID(); i++)
            {
                employers.Add(new Employer(talkWithBD.GetAllAboutEmployerFromID(i)));
                ChooseEmployer.Items.Add($"{employers[i].surname}");
            }
        }



        private void ChooseEmployer_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 1; i <= talkWithBD.GetLastID(); i++)
            {
                employers.Add(new Employer(talkWithBD.GetAllAboutEmployerFromID(i)));
            }

            CurID = ChooseEmployer.SelectedIndex + 1;
            Label_FIO.Text = $"{employers[CurID].surname} {employers[CurID].name} {employers[CurID].patronym} \nДолжность {employers[CurID].post}";

            Num_Day.Value = int.Parse(employers[CurID].day);
            Num_Penalty.Value = int.Parse(employers[CurID].penalty);
            Num_Reprimands.Value = int.Parse(employers[CurID].reprinands);
            Num_Reteperhour.Value = int.Parse(employers[CurID].rateperhour);
            Num_Sickleave.Value = int.Parse(employers[CurID].years);
            Num_Last.Value = int.Parse(employers[CurID].salary_last);
            Num_Years.Value = int.Parse(employers[CurID].years);



            string reprimands = Num_Reprimands.Value.ToString();
            string rateperhour = Num_Reteperhour.Value.ToString();
            string penalty = Num_Penalty.Value.ToString();
            string sickleave = Num_Sickleave.Value.ToString();
            string day = Num_Day.Value.ToString();
            string years = Num_Years.Value.ToString();
            string salary_last = Num_Last.Value.ToString();

            talkWithBD.UpdateAllAboutEmployer(CurID, reprimands, rateperhour, penalty, sickleave, day, years, salary_last);

            employers[CurID].reprinands = reprimands;
            employers[CurID].rateperhour = rateperhour;
            employers[CurID].penalty = penalty;
            employers[CurID].sickleave = sickleave;
            employers[CurID].day = day;
            employers[CurID].years = years;
            employers[CurID].salary_last = salary_last;

            L_salary.Text = $"Зарплата {(int)employers[CurID].Salary()} рублей";
            L_Tax.Text = $"Налоги составят {(int)employers[CurID].Taxes()} рублей";
            L_ndfl.Text = $"Выплата НДФЛ составит {(int)employers[CurID].ndfl()} рублей";
            L_Pay.Text = $"Итого к выплате {(int)employers[CurID].ToPay()} рублей";
        }

        private void добавитьРаботникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddEmployer().Show();
        }

        private void программаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            talkWithBD.CloseBD();
            new LogIn().Close();
            new AddEmployer().Close();
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reprimands = Num_Reprimands.Value.ToString();
            string rateperhour = Num_Reteperhour.Value.ToString();
            string penalty = Num_Penalty.Value.ToString();
            string sickleave = Num_Sickleave.Value.ToString();
            string day = Num_Day.Value.ToString();
            string years = Num_Years.Value.ToString();
            string salary_last = Num_Last.Value.ToString();

            talkWithBD.UpdateAllAboutEmployer(CurID, reprimands, rateperhour, penalty, sickleave, day, years, salary_last);

            employers[CurID].reprinands = reprimands;
            employers[CurID].rateperhour = rateperhour;
            employers[CurID].penalty = penalty;
            employers[CurID].sickleave = sickleave;
            employers[CurID].day = day;
            employers[CurID].years = years;
            employers[CurID].salary_last = salary_last;

            L_salary.Text = $"Зарплата {(int)employers[CurID].Salary()} рублей";
            L_Tax.Text = $"Налоги составят {(int)employers[CurID].Taxes()} рублей";
            L_ndfl.Text = $"Выплата НДФЛ составит {(int)employers[CurID].ndfl()} рублей";
            L_Pay.Text = $"Итого к выплате {(int)employers[CurID].ToPay()} рублей";
        }
    }
}
