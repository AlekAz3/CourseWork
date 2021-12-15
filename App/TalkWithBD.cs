using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    /// <summary>
    /// Этот класс меняется в зависимости от бд, но методы класса которые исспользуются
    /// в коде не меняются 
    /// </summary>
    static class TalkWithBD
    {
        private static string way = $@"C:\Users\{Environment.UserName}\AppData\Local\Course\DataBase.db";
        
        public static void First_Check()
        {

        }
    
    }
}
