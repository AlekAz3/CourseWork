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

            Num_Day.Value = int.Parse(employers[CurID].day);
            Num_Penalty.Value = int.Parse(employers[CurID].penalty);
            Num_Reprimands.Value = int.Parse(employers[CurID].reprinands);
            Num_Reteperhour.Value = int.Parse(employers[CurID].rateperhour);
            Num_Sickleave.Value = int.Parse(employers[CurID].years);
            Num_Last.Value = int.Parse(employers[CurID].salary_last);
            Num_Years.Value = int.Parse(employers[CurID].years);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ComboBoxReFrash();
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            //TalkWithBD.UpdateAllAboutEmployer(CurID, Num_Reprimands.Value.ToString(), Num_Reteperhour.Value.ToString(), Num_Penalty.Value.ToString(), Num_Sickleave.Value.ToString(), Num_Day.Value.ToString(), Num_Years.Value.ToString(), Num_Last.Value.ToString());
            //TalkWithBD.UpdateField(CurID, "reprimands", Num_Reprimands.Value.ToString());
            //TalkWithBD.UpdateField(CurID, "rateperhour", Num_Reteperhour.Value.ToString());
            //TalkWithBD.UpdateField(CurID, "penalty", Num_Penalty.Value.ToString());
            //TalkWithBD.UpdateField(CurID, "sickleave", Num_Sickleave.Value.ToString());
            //TalkWithBD.UpdateField(CurID, "day", Num_Day.Value.ToString());
            //TalkWithBD.UpdateField(CurID, "years", Num_Years.Value.ToString());
            //TalkWithBD.UpdateField(CurID, "salary_last", Num_Last.Value.ToString());

            employers[CurID].reprinands = Num_Reprimands.Value.ToString();
            employers[CurID].rateperhour = Num_Reteperhour.Value.ToString();
            employers[CurID].penalty = Num_Penalty.Value.ToString();
            employers[CurID].sickleave = Num_Sickleave.Value.ToString();
            employers[CurID].day = Num_Day.Value.ToString();
            employers[CurID].years = Num_Years.Value.ToString();
            employers[CurID].salary_last = Num_Last.Value.ToString();

            MessageBox.Show($"Итого к выплате {(int)employers[CurID].ToPay()}") ;
        }

    }
}
