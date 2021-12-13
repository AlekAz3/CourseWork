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

        public SQLiteConnection DataBase
        {
            get {return database; }//Свойство чтоб вызвать метод CreateCommand
        }

        private SQLiteConnection database = new SQLiteConnection(@"Data Source=C:\Users\BL\source\repos\CourseWork\App\DataBase.db; Version=3;"); //Местоположение базы данных и версия 

        public void Connect()
        {
            database.Open(); //Открытие Базы данных
        }

        public void Disconnect()
        {

            database.Close(); //Закрытие базы данных
        }
        
    }
}
