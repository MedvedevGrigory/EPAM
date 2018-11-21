using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Employee
    {
        public Employee(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Greeting(Employee employee, int nowHour)
        {
            if (nowHour < 12)
            {
                Console.WriteLine($"Good morning, {employee.Name}!, - said {Name}");
            }
            else if (nowHour < 17)
            {
                Console.WriteLine($"Good day, {employee.Name}!, - said {Name}");
            }
            else
            {
                Console.WriteLine($"Good evening, {employee.Name}!, - said {Name}");
            }
        }

        public void SayGoodbye(Employee employee)
        {
            Console.WriteLine($"Goodbye, {employee.Name}!, - said {Name}");
        }

        public void PleaseGoToWork()
        {
            OnCame();
        }

        private void OnCame()
        {
            Came?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler Came;

        public void PleaseGoToHome()
        {
            OnLeave();
        }

        private void OnLeave()
        {
            Leave?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler Leave;
    }
}
