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
            List<Employer> employers = new List<Employer>();
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

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            string x = (ChooseEmployer.SelectedIndex + 1).ToString();
            MessageBox.Show(x);

            ChooseEmployer.Items.Clear();
            Init();
        }

    }
}
