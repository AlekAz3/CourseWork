using System;
using System.IO;
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
        private static string way = @"C:\Users\BL\source\repos\CourseWork\App\DataBase.db";
        public SQLiteConnection database = new SQLiteConnection($"Data Source={way}; Version=3;");//Местоположение базы данных и версия 


        public DbConnect()
        {

        }


        public SQLiteConnection DataBase
        {
            get { return database; }//Свойство чтоб вызвать метод CreateCommand
        }


        public void Connect()
        {
            database.Open(); //Открытие Базы данных
        }
    }

}

