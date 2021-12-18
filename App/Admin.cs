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
        }

        public void Init()
        {
            List<Employer> employers = new List<Employer>();

            for(int i = 0; i <= TalkWithBD.GetLastID(); i++)
            {
                employers.Add(new Employer(TalkWithBD.GetAllAboutEmployerFromID(i)));
                ChooseEmployer.Items.Add($"{employers[i].surname} {employers[i].name[0].ToString().ToUpperInvariant()}. {employers[i].patronym[0].ToString().ToUpperInvariant()}");
            }
            

        }

        private void Btn_AddEmp_Click(object sender, EventArgs e)
        {
            new AddEmployer().Show();
        }
    }
}
