using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Employer
    {
        private string name { get; set; }
        private string surname { get; set; }
        private string patronym { get; set; }
        private string reprinands { get; set; }
        private string rateperhour { get; set; }
        private string penalty { get; set; }
        private string sickleave { get; set; }
        private string day { get; set; }


        public Employer(string[] Employe)
        {
            name = Employe[0];
            surname = Employe[1];
            patronym = Employe[2];
            reprinands = Employe[3];
            rateperhour = Employe[4];
            penalty = Employe[5];
            sickleave = Employe[6];
            day = Employe[7];
        }

    }
}
