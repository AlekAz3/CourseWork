using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Reg
    {
        private string login;
        private string pass1;
        private string pass2;


        public Reg(string login, string pass1, string pass2)
        {
            this.login = login;
            this.pass1 = pass1;
            this.pass2 = pass2;
        }

        public bool AllCheck()
        {
            return false;
        }

        public bool Check_Password()
        {
            if (pass1 != pass2) {return false;}
            else {return true;}
        }
    }
}
