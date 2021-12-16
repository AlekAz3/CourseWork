using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class DataFromDb
    {
        private string login;
        private string password;

        public DataFromDb(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public (bool,string[]) CompareWithDb()
        {
            string[] curPers = new string[6];
            bool stat;
            DbConnect db = new DbConnect();
            db.Connect();
            SQLiteCommand cmd = db.DataBase.CreateCommand();
            cmd.CommandText = "SELECT * FROM Work WHERE LOGIN LIKE '%' || @log || '%' AND PASSWORD LIKE '%' || @pw || '%' ";
            cmd.Parameters.Add("@log", DbType.String).Value = login;
            cmd.Parameters.Add("@pw", DbType.String).Value = password;

            SQLiteDataReader sql = cmd.ExecuteReader();

            stat = sql.HasRows;
            if (sql.HasRows)
            {
                while (sql.Read())
                {
                    curPers[0] = $"{sql["ID"]} ";
                    curPers[1] = $"{sql["NAME"]} ";
                    curPers[2] = $"{sql["SURNAME"]} ";
                    curPers[3] = $"{sql["PATRONYMIC"]} ";
                    curPers[4] = $"{sql["PASSPORT"]} ";
                    curPers[5] = $"{sql["MANAGER"]}";
                }
            }
            db.Disconnect();

            return (stat, curPers);
        }


    }
}
