using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SQLite;

using System.Text;
using System.Threading.Tasks;

namespace App
{
    class RegisterToDb
    {

        private string name;
        private string surname;
        private string patronymic;
        private long passport;
        private string login;
        private string password;
        private bool manager;

        public RegisterToDb(string name, string surname, string patronymic,string passport, string login, string password, bool manager)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.passport = long.Parse(passport);
            this.login = login;
            this.password = password;
            this.manager = manager; // адмика тру/фолз 
        }

        public void ToDb()
        {
            DbConnect db = new DbConnect();
            db.Connect();
            SQLiteCommand cmd = db.DataBase.CreateCommand(); 
            cmd.CommandText = "INSERT INTO Work(NAME, SURNAME, PATRONYMIC, PASSPORT, LOGIN, PASSWORD, MANAGER) values(@name,@sname,@pname,@pp,@log,@pw,@m)"; //SQL запрос
            cmd.Parameters.Add("@name", DbType.String).Value = name;
            cmd.Parameters.Add("@sname", DbType.String).Value = surname;
            cmd.Parameters.Add("@pname", DbType.String).Value = patronymic;
            cmd.Parameters.Add("@pp", DbType.Int64).Value = passport; 
            cmd.Parameters.Add("@log", DbType.String).Value = login;
            cmd.Parameters.Add("@pw", DbType.String).Value = password;
            cmd.Parameters.Add("@m", DbType.Boolean).Value = manager;
            cmd.ExecuteNonQuery(); //Отправка в БД
            db.Disconnect();            
        }
    }
}
