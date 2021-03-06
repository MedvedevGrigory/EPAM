﻿using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter patronymic:");
            string patronymic = Console.ReadLine();

            Console.WriteLine("Enter birthdate in format \"dd.mm.yyyy\"");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime birthdate))
            {
                Console.WriteLine("Invalid expression.");
            }

            try
            {
                User user = new User(surname, name, patronymic, birthdate);

                Console.WriteLine($"\nSurname - {user.Surname}\n" +
                    $"Name - {user.Name}\n" +
                    $"Patronymic - {user.Patronymic}\n" +
                    $"Birthdate - {user.Birthdate.ToShortDateString()}\n" +
                    $"Age - {user.Age}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }
    }
}
