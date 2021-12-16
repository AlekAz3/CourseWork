using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace App
{
    /// <summary>
    /// Этот класс меняется в зависимости от бд, но методы класса которые исспользуются
    /// в коде не меняются 
    /// </summary>
    static class TalkWithBD
    {
        private static string way = $@"C:\Users\{Environment.UserName}\AppData\Local\Course";
        
        public static void First_Check()
        {
            if (!File.Exists($@"{way}\DataBase.db"))
            {
                CreateBD();
            }
        }

        public static void CreateBD()
        {

            if (!Directory.Exists(way)) Directory.CreateDirectory(way);

            SQLiteConnection.CreateFile($@"{way}\DataBase.db");
            SQLiteConnection db = new SQLiteConnection($@"Data Source={way}\DataBase.db;Version=3;");
            db.Open();

            string command = "CREATE TABLE work (" +
                "id         INTEGER      PRIMARY KEY AUTOINCREMENT" +
                " NOT NULL," +
                "    name       VARCHAR (15) NOT NULL," +
                "    surname    VARCHAR (15) NOT NULL," +
                "    patronymic VARCHAR (15) NOT NULL," +
                "    passport   VARCHAR (10) NOT NULL," +
                "    login      VARCHAR (15) NOT NULL," +
                "    password   VARCHAR (15) NOT NULL," +
                "    manager    BOOLEAN      NOT NULL" +
                ");";

            SQLiteCommand cmd = new SQLiteCommand(command, db);
            cmd.ExecuteNonQuery();
        }
    }
}
