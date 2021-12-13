using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class DbConnect
    {
        private SQLiteConnection db= new SQLiteConnection(@"Data Source=C:\Users\BL\source\repos\CourseWork\App\DataBase.db; Version=3;");


        public void Connect()
        {
            db.Open();
        }

        public void Disconnect()
        {

            db.Close();
        }
    }
}
