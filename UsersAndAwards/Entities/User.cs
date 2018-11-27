using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Entities
{
    public class User
    {
        private const int MaxAge = 150;

        public int ID;

        private string firstName;

        private string lastName;

        private DateTime birthdate;

        private int age;

        public List<Award> Awards;


        public User(string firstName, string lastName, DateTime birthdate, int iD = 0)
        {
            ID = iD;
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Birthdate = birthdate;
            Awards = new List<Award>();
        }

        private bool IsValid(string value)
        {
            string pattern = "\\W|\\d";
            if (Regex.IsMatch(value, pattern))
            {
                return false;
            }

            return true;
        }

        private int GetAge(DateTime birthdate)
        {
            age = DateTime.Now.Year - birthdate.Year;
            if (DateTime.Now.Month < birthdate.Month)
            {
                age--;
            }
            else if (DateTime.Now.Month == birthdate.Month)
            {
                if (DateTime.Now.Day < birthdate.Day)
                {
                    age--;
                }
            }

            return age;
        }

        private void ThrowException(string nameOfError)
        {
            throw new Exception($"Invalid {nameOfError}. {nameOfError} cannot contain special symbols or spaces.");
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (!IsValid(value))
                {
                    ThrowException("First name");
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                if (!IsValid(value))
                {
                    ThrowException("Last name");
                }

                lastName = value;
            }
        }

        public DateTime Birthdate
        {
            get => birthdate;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new Exception("Error. Birthdate cannot be greater than thе current date.");
                }

                if (GetAge(value) > MaxAge)
                {
                    throw new Exception($"Error. Birthdate cannot be greater than {MaxAge}.");
                }

                birthdate = value;
            }
        }

        public int Age { get => GetAge(birthdate); private set => age = value; }

        public string AwardList => string.Join(", ", Awards);
    }
}
