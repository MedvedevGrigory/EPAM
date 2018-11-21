using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public delegate void GreetEmployee(Employee employee, int nowHour);
        public static GreetEmployee greet;

        public delegate void GoodbyeEmployee(Employee employee);
        public static GoodbyeEmployee goodbye;

        static void Main(string[] args)
        {
            Employee john = new Employee("John");
            john.Came += EmployeeCame;
            john.Leave += EmployeeLeave;

            Employee mary = new Employee("Mary");
            mary.Came += EmployeeCame;
            mary.Leave += EmployeeLeave;

            Employee sherlok = new Employee("Sherlok");
            sherlok.Came += EmployeeCame;
            sherlok.Leave += EmployeeLeave;

            sherlok.PleaseGoToWork();
            john.PleaseGoToWork();
            mary.PleaseGoToWork();

            sherlok.PleaseGoToHome();
        }

        private static void EmployeeCame(object sender, EventArgs e)
        {
            Employee employee = (Employee)sender;
            Console.WriteLine($"\n[{employee.Name} came to work]");
            int nowHour = DateTime.Now.Hour;
            greet?.Invoke(employee, nowHour);
            greet += employee.Greeting;
            goodbye += employee.SayGoodbye;
        }

        private static void EmployeeLeave(object sender, EventArgs e)
        {
            Employee employee = (Employee)sender;
            Console.WriteLine($"\n[{employee.Name} leave from work]");
            greet -= employee.Greeting;
            goodbye -= employee.SayGoodbye;
            goodbye?.Invoke(employee);
        }
    }
}
