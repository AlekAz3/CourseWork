using System;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;

namespace App
{
    /// <summary>
    /// Этот класс меняется в зависимости от бд, но методы класса которые исспользуются
    /// в коде не меняются 
    /// </summary>
    static class TalkWithBD
    {
        private static string way = $@"C:\Users\{Environment.UserName}\AppData\Local\Course";
        
        public static void Check()
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

            string command = "CREATE TABLE Employer (     id          INTEGER      PRIMARY KEY AUTOINCREMENT,     name        VARCHAR (15) NOT NULL,     surname     VARCHAR (15) NOT NULL,     patronym    VARCHAR (10) NOT NULL,     passport    VARCHAR (15) NOT NULL,     reprimands  VARCHAR (6),     rateperhour VARCHAR (6),     penalty     VARCHAR (6),     sickleave   VARCHAR (6),     day         VARCHAR (6),     login       VARCHAR (10) NOT NULL,     password    VARCHAR (10) NOT NULL );";
            SQLiteCommand cmd = new SQLiteCommand(command, db);
            cmd.ExecuteNonQuery();
        }

        public static string[] GetAllAboutEmployerFromID(int id)
        {
            Check();
            SQLiteConnection db = new SQLiteConnection($@"Data Source={way}\DataBase.db;Version=3;");
            db.Open();
            
            //StringBuilder Employe = new StringBuilder();
            string[] Employe = new string[8];

            string command = "SELECT * FROM Employer WHERE ID LIKE '%' || @id || '%' ";
            SQLiteCommand cmd = new SQLiteCommand(command, db);
            cmd.Parameters.Add("@id", System.Data.DbType.Int32).Value = id;
            SQLiteDataReader sql = cmd.ExecuteReader();

            if (sql.HasRows)
            {
                Employe[0] = (string)sql["name"];
                Employe[1] = (string)sql["surname"];
                Employe[2] = (string)sql["patronym"];
                Employe[3] = (string)sql["reprimands"];
                Employe[4] = (string)sql["rateperhour"];
                Employe[5] = (string)sql["penalty"];
                Employe[6] = (string)sql["sickleave"];
                Employe[7] = (string)sql["day"];
                db.Close();
                return Employe;
            }
            else 
            { 
                Employe[0] = "Not Find";
                db.Close();
                return Employe;
            }
        }

        public static void UpdateField(int id, string field, string value)
        {
            Check();
            SQLiteConnection db = new SQLiteConnection($@"Data Source={way}\DataBase.db;Version=3;");
            db.Open();
            string command = $@"UPDATE Employer SET {field} = ‘{value}’ WHERE id = {id};";
            SQLiteCommand cmd = new SQLiteCommand(command, db);
            cmd.ExecuteNonQuery();
            db.Close();
        }

        public static string GetCurrentValue(int id, string field)
        {
            Check();
            string result;

            SQLiteConnection db = new SQLiteConnection($@"Data Source={way}\DataBase.db;Version=3;");
            db.Open();

            string command = "SELECT * FROM Employer WHERE ID LIKE '%' || @id || '%' ";
            SQLiteCommand cmd = new SQLiteCommand(command, db);

            cmd.Parameters.Add("@id", System.Data.DbType.Int32).Value = id;
            SQLiteDataReader sql = cmd.ExecuteReader();

            if (sql.HasRows)
            {
                result = (string)sql[field];
                db.Close();
                return result;
            }
            else
            {
                result = "Not Find";
                return result;
            }
        }

        public static void AddNewEmployer(string name, string surname, string patronym, string passport, string login, string password)
        {
            Check();
            SQLiteConnection db = new SQLiteConnection($@"Data Source={way}\DataBase.db;Version=3;");
            db.Open();
            string command = $"INSERT INTO Employer (name, surname, patronym, passport, login, password) VALUES ('{name}', '{surname}', '{patronym}', '{passport}', '{login}', '{password}')";
            SQLiteCommand cmd = new SQLiteCommand(command, db);
            cmd.ExecuteNonQuery();
            db.Close();
        }

        public static bool CompareWithDb(string field, string value)
        {
            Check();

            SQLiteConnection db = new SQLiteConnection($@"Data Source={way}\DataBase.db;Version=3;");
            db.Open();

            string command = $"SELECT * FROM Employer WHERE {field} == '{value}'";
            SQLiteCommand cmd = new SQLiteCommand(command, db);

            SQLiteDataReader sql = cmd.ExecuteReader();

            if (sql.HasRows)
            {
                db.Close();
                return true;
            }
            else
            {
                db.Close();
                return false;
            }
        }

        public static int GetLastID()
        {
            Check();

            SQLiteConnection db = new SQLiteConnection($@"Data Source={way}\DataBase.db;Version=3;");
            db.Open();

            string command = $"SELECT * FROM Employer WHERE id = (SELECT MAX(id) FROM Employer);";
            SQLiteCommand cmd = new SQLiteCommand(command, db);

            SQLiteDataReader sql = cmd.ExecuteReader();

            if (sql.HasRows)
            {
                int x =(int)sql["id"];
                db.Close();
                return x;
            }
            else
            {
                return 0;
            }

        }

    }
}
