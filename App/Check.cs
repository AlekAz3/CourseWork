using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Check
    {

        private string name; //Имя 
        private string surname; // Фамилия
        private string patronymic; //Отчество 
        private string passport;//Серия и Номер паспорта 
        private string login; //Логин
        private string post; //Должность


        //******************РЕГИСТРАЦИЯ***************************
        public Check(string name, //Проверка для добавления работника
                     string surname,
                     string patronymic,
                     string passport,
                     string post
                     )
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.passport = passport;
            this.post = post;
        }

        public bool AllCheck()//Запуск всех проверок валидации 
        {
            return FillBox() && Ru_Symbols() && Check_Passport();
        }

        //MessageBox.Show("Пароли не совпадают", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        

        //MessageBox.Show("Заполены не все поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        private bool FillBox()//Тут идёт проверка все ли поля заполнены 
        {
            if (name.Length == 0 || surname.Length == 0 || patronymic.Length == 0 || passport.Length == 0) return false;
            else return true;
        }

        //MessageBox.Show("Присутствуют недопустимые символы в Логин или Пароль ","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        

        //MessageBox.Show("ФИО содержит НЕ русские буквы", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        private bool Ru_Symbols()//ФИО должно содержать только символы русского алфавита
        {
            if (OnlyRussia(name) && OnlyRussia(surname) && OnlyRussia(patronymic)) return false;
            else return true;
        }

        //MessageBox.Show("Серия и Номер паспорта введены неккоректно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        private bool Check_Passport()//Проверка длинны серии и номера должно быть 10 и так же проверка всех символов чтоб были цифрами
        {
            if (passport.Length != 10 && OnlyNumber(passport)) return false;
            else return true;
        }

        //**************КОНЕЦ****************************

        private string password;

        public Check(string login, string password)
        {
            this.password = password;
            this.login = login;
        }

        public bool Check_LogIn()
        {
            return CBan_Symbols() && CFill_Box();
        }

        public bool CBan_Symbols()
        {
            if (!NoSpecialCharacters(login) || !NoSpecialCharacters(password)) return false;
            else return true;
        }

        public bool CFill_Box()
        {
            if (login.Length == 0 && password.Length == 0) return false;
            else return true;
        }

        //Метод возвращающий true если строка НЕ содержить спец символов
        private static bool NoSpecialCharacters(string str)
        {
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();

            int index = str.IndexOfAny(specialCharactersArray);
            if (index == -1) return true;
            else return false;
        }

        //Метод возвращающий true если строка НЕ содержит спец символов и НЕ содержит Букв англ алфавита  и НЕ содержит Числа
        private static bool OnlyRussia(string str)
        {
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"" + "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            char[] specialCharactersArray = specialCharacters.ToCharArray();

            int index = str.IndexOfAny(specialCharactersArray);
            if (index == -1) return false;
            else return true;
        }

        //Метод возвращающий true если строка НЕ содержит спец символов и НЕ содержит Букв англ алфавита
        private static bool OnlyNumber(string str)
        {
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"" + "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            char[] specialCharactersArray = specialCharacters.ToCharArray();

            int index = str.IndexOfAny(specialCharactersArray);
            if (index == -1) return true;
            else return false;
        }
    }
}
