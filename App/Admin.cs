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
            Init();
        }

        public void Init()
        {
            ChooseEmployer.Items.Clear();

            var employers = new List<Employer>();
            employers.Add(new Employer());

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
            var employers = new List<Employer>();
            employers.Add(new Employer());

            for (int i = 1; i <= TalkWithBD.GetLastID(); i++)
            {
                employers.Add(new Employer(TalkWithBD.GetAllAboutEmployerFromID(i)));
            }

            int id = ChooseEmployer.SelectedIndex + 1;
            Label_FIO.Text = $"{employers[id].surname} {employers[id].name} {employers[id].patronym}";

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Init();
        }
    }
}
