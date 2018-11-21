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

        void matchPattern(string value, string error)
        {
            string pattern = "\\W|\\d";
            if (Regex.IsMatch(value, pattern))
            {
                throw new Exception($"Invalid {error}.");
            }
        }

        string surname;

        public string Surname
        {
            get => surname;
            set
            {
                matchPattern(value, "surname");
                surname = value;
            }
        }

        string name;

        public string Name
        {
            get => name;
            set
            {
                matchPattern(value, "name");
                name = value;
            }
        }

        string patronymic;

        public string Patronymic
        {
            get => patronymic;
            set
            {
                matchPattern(value, "patronymic");
                patronymic = value;
            }
        }

        DateTime birthdate;

        public DateTime Birthdate
        {
            get => birthdate;
            set
            {
                if (birthdate > DateTime.Now)
                {
                    throw new Exception("Error. Birthdate cannot be greater than thе current date.");
                }
                birthdate = value;
            }
        }

        int age;

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
