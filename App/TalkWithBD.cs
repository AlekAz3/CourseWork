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

            string command = "CREATE TABLE Employer (     id          INTEGER      PRIMARY KEY AUTOINCREMENT,     name        VARCHAR (15) NOT NULL,     surname     VARCHAR (15) NOT NULL,     patronym    VARCHAR (10) NOT NULL,     passport    VARCHAR (15) NOT NULL,     reprimands  VARCHAR (6) DEFAULT (0),     rateperhour VARCHAR (6) DEFAULT (0),     penalty     VARCHAR (6) DEFAULT (0),     sickleave   VARCHAR (6) DEFAULT (0),     day         VARCHAR (6) DEFAULT (0),     years         VARCHAR (6) DEFAULT (0),     salary_last         VARCHAR (6) DEFAULT (0),     post         VARCHAR (6) DEFAULT (0));";
            SQLiteCommand cmd = new SQLiteCommand(command, db);
            cmd.ExecuteNonQuery();
        }

        public static string[] GetAllAboutEmployerFromID(int id)
        {
            Check();
            SQLiteConnection db = new SQLiteConnection($@"Data Source={way}\DataBase.db;Version=3;");
            db.Open();

            string[] Employe = new string[11];

            string command = $"SELECT * FROM Employer WHERE id LIKE '%' || {id} || '%'; ";
            SQLiteCommand cmd = new SQLiteCommand(command, db);
            SQLiteDataReader sql = cmd.ExecuteReader();

            if (sql.HasRows)
            {
                sql.Read();
                Employe[0] = (string)sql["name"];
                Employe[1] = (string)sql["surname"];
                Employe[2] = (string)sql["patronym"];
                Employe[3] = (string)sql["reprimands"];
                Employe[4] = (string)sql["rateperhour"];
                Employe[5] = (string)sql["penalty"];
                Employe[6] = (string)sql["sickleave"];
                Employe[7] = (string)sql["day"];
                Employe[8] = (string)sql["years"];
                Employe[9] = (string)sql["salary_last"];
                Employe[10] = (string)sql["post"];
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

        public static void UpdateAllAboutEmployer(int id, string reprimands, string rateperhour, string penalty, string sickleave, string day, string years, string salary_last)
        {
            UpdateField(id, "reprimands", reprimands);
            UpdateField(id, "rateperhour", rateperhour);
            UpdateField(id, "penalty", penalty);
            UpdateField(id, "sickleave", sickleave);
            UpdateField(id, "day", day);
            UpdateField(id, "years", years);
            UpdateField(id, "salary_last", salary_last);
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

        public static object GetCurrentValue(int id, string field)
        {
            Check();
            object result;

            SQLiteConnection db = new SQLiteConnection($@"Data Source={way}\DataBase.db;Version=3;");
            db.Open();

            string command = "SELECT * FROM Employer WHERE ID LIKE '%' || @id || '%' ";
            SQLiteCommand cmd = new SQLiteCommand(command, db);

            cmd.Parameters.Add("@id", System.Data.DbType.Int32).Value = id;
            SQLiteDataReader sql = cmd.ExecuteReader();

            if (sql.HasRows)
            {
                sql.Read();
                result = sql[$"{field}"];
                db.Close();
                return result;
            }
            else
            {
                db.Close();
                result = "Not Find";
                return result;
            }
        }

        public static void AddNewEmployer(string name, string surname, string patronym, string passport, string post)
        {
            Check();
            SQLiteConnection db = new SQLiteConnection($@"Data Source={way}\DataBase.db;Version=3;");
            db.Open();
            string command = $"INSERT INTO Employer (name, surname, patronym, passport, post) VALUES ('{name}', '{surname}', '{patronym}', '{passport}', '{post}')";
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
            int i = 0;
            string command = $"SELECT max(id) FROM Employer;";
            SQLiteCommand cmd = new SQLiteCommand(command, db);

            SQLiteDataReader sql = cmd.ExecuteReader();

            if (sql.HasRows)
            {
                sql.Read();
                if (sql["max(id)"].ToString() != "") i = Convert.ToInt32(sql["max(id)"].ToString());
                else MessageBox.Show("Пустая база данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.Close();
                return i;
            }
            else
            {
                db.Close();
                return i;
            }

        }

    }
}
