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
            MessageBox.Show(TalkWithBD.GetLastID().ToString(), "Да", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for(int i = 1; i<TalkWithBD.GetLastID()+1; i++)
            {
                ChooseEmployer.Items.Add($"{TalkWithBD.GetCurrentValue(i, "surname")}");
            }
        }



    }
}
