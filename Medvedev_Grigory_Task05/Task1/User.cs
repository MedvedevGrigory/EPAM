using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class User
    {
        public User(string surname, string name, string patronymic, DateTime birthdate)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Birthdate = birthdate;
        }

        private string surname;

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                string pattern = "\\W|\\d";
                if (Regex.IsMatch(value, pattern))
                {
                    throw new Exception("Invalid expression.");
                }
                surname = value;
            }
        }

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                string pattern = "\\W|\\d";
                if (Regex.IsMatch(value, pattern))
                {
                    throw new Exception("Invalid expression.");
                }
                name = value;
            }
        }

        private string patronymic;

        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                string pattern = "\\W|\\d";
                if (Regex.IsMatch(value, pattern))
                {
                    throw new Exception("Invalid expression.");
                }
                patronymic = value;
            }
        }

        private DateTime birthdate;

        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }
            set
            {
                if (birthdate > DateTime.Now)
                {
                    throw new Exception("Error. Birthdate cannot be greater than thе current date.");
                }
                birthdate = value;
            }
        }

        private int age;

        public int Age
        {
            get
            {
                age = DateTime.Now.Year - birthdate.Year;
                if (DateTime.Now.Month < birthdate.Month)
                {
                    age--;
                }
                if (DateTime.Now.Month == birthdate.Month)
                {
                    if (DateTime.Now.Day < birthdate.Day)
                    {
                        age--;
                    }
                }
                return age;
            }
        }
    }
}
