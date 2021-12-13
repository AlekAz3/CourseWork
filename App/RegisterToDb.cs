using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class RegisterToDb
    {
        private string name;
        private string sername;
        private string patronymic;
        private string login;
        private string password;
        private bool manager;



        public RegisterToDb(string name, string sername, string patronymic, string login, string password, bool manager)
        {
            this.name = name;
            this.sername = sername;
            this.patronymic = patronymic;
            this.login = login;
            this.password = password;
            this.manager = manager;
        }


        public void ToDb()
        {

        }

        private void nameToDb()
        {

        }
    }
}
