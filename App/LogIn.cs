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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            Load_Settings();
            
        }

        public void Load_Settings()
        {
            Text_Password.UseSystemPasswordChar = true;
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().Show();
        }
    }
}
