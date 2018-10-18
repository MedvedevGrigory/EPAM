using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCultureInfo("ru", "en");
            PrintCultureInfo("en", string.Empty);
            PrintCultureInfo("ru", string.Empty);

            Console.ReadKey();
        }

        private static void PrintCultureInfo(string culture1, string culture2)
        {
            CultureInfo myCI1 = new CultureInfo(culture1, false);
            CultureInfo myCI2 = new CultureInfo(culture2, false);

            if (culture2 == string.Empty)
            {
                culture2 = "invariant";
            }

            Console.WriteLine("{0,-30}{1,-35}{2,-25}", "PROPERTY", culture1, culture2);
            Console.WriteLine("{0,-30}{1,-35}{2,-25}", "DisplayName", myCI1.DisplayName, myCI2.DisplayName);
            Console.WriteLine("{0,-30}{1,-35}{2,-25}", "DateTimeFormat", myCI1.DateTimeFormat.FullDateTimePattern, myCI2.DateTimeFormat.FullDateTimePattern);
            Console.WriteLine("{0,-30}{1,-35}{2,-25}", "CurrencyDecimalDigits", myCI1.NumberFormat.CurrencyDecimalDigits, myCI2.NumberFormat.CurrencyDecimalDigits);
            Console.WriteLine("{0,-30}{1,-35}{2,-25}", "CurrencyDecimalSeparator", myCI1.NumberFormat.CurrencyDecimalSeparator, myCI2.NumberFormat.CurrencyDecimalSeparator);
            Console.WriteLine();
        }
    }
}
