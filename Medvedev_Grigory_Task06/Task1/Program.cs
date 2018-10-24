using System;

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

            Console.WriteLine("Enter experience:");
            if (!int.TryParse(Console.ReadLine(), out int experience))
            {
                Console.WriteLine("Invalid value. Expected positive integer.");
            }

            Console.WriteLine("Enter position:");
            string position = Console.ReadLine();

            try
            {
                Employee employee = new Employee(surname, name, patronymic, birthdate, experience, position);

                Console.WriteLine($"\nSurname - {employee.Surname}\n" +
                    $"Name - {employee.Name}\n" +
                    $"Patronymic - {employee.Patronymic}\n" +
                    $"Birthdate - {employee.Birthdate.ToShortDateString()}\n" +
                    $"Age - {employee.Age}\n" +
                    $"Experience - {employee.Experience}\n" +
                    $"Position - {employee.Position}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }
    }
}
