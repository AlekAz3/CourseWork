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
            if (!File.Exists($@"{way}+\DataBase.db"))
            {

            }
            else
            {
                if (!Directory.Exists(way)) Directory.CreateDirectory(way);
            }
        }

        private static void CreateBD()
        {
            
        }
    }
}
