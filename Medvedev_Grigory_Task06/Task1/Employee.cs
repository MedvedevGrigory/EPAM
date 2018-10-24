using System;

namespace Task1
{
    class Employee : User
    {
        public Employee(string surname, string name, string patronymic, DateTime birthdate, int experience, string position) : base(surname, name, patronymic, birthdate)
        {
            Experience = experience;
            Position = position;
        }

        int experience;

        public int Experience
        {
            get => experience;
            set
            {
                if (value < 0) 
                {
                    throw new Exception("Experience must be nonnegative.");
                }
                experience = value;
            }
        }

        public string Position { get; set; }

        int salary;

        public int Salary
        {
            get => salary;
            set
            {
                if (value <= 0) 
                {
                    throw new Exception("Salary must be positive.");
                }
                salary = value;
            }
        }
    }
}
