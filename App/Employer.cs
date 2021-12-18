using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    class Employer
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string patronym { get; set; }
        public string reprinands { get; set; }
        public string rateperhour { get; set; }
        public string penalty { get; set; }
        public string sickleave { get; set; }
        public string day { get; set; }
        public string years { get; set; }
        public string salary_last { get; set; }
        public string post { get; set; }

        public Employer(string[] Employe)
        {

            if (Employe[0] == "Not Find")
            {
                MessageBox.Show("Такого работника не существует: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                name = Employe[0];
                surname = Employe[1];
                patronym = Employe[2];
                reprinands = Employe[3]; //Выговоры 
                rateperhour = Employe[4]; //часовая ставка 
                penalty = Employe[5]; //штрафы 
                sickleave = Employe[6]; // больничные 
                day = Employe[7];
                years = Employe[8];
                salary_last = Employe[9];
                post = Employe[10];
            }
        }

        public decimal Salary()
        {
            return (Convert.ToDecimal(day) * 8.0m * Convert.ToDecimal(rateperhour)) - Convert.ToDecimal(penalty) * 1500;
        }

        public decimal Taxes()
        {
            return this.Salary() * 0.3m;
        }

        public decimal ndfl()
        {
            return this.Salary() * 0.13m;
        }
        public decimal Sick()
        {
            if (Convert.ToInt32(years) > 5)
                return (Convert.ToDecimal(salary_last) / 30.0m) * 0.6m * Convert.ToDecimal(sickleave);

            else if (Convert.ToInt32(years) >= 5 && Convert.ToInt32(years) < 8) 
                return (Convert.ToDecimal(salary_last) / 30.0m) * 0.8m * Convert.ToDecimal(sickleave);

            else 
                return (Convert.ToDecimal(salary_last) / 30.0m) * Convert.ToDecimal(sickleave);
        }

        public decimal ToPay()
        {
            return Salary() + Sick() - Taxes();
        }

    }
}
