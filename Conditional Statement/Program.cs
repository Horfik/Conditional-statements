using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime date = new DateTime(year,1,1);
            if (DateTime.IsLeapYear(date.Year))
                Console.WriteLine("{0} is a leap year", date.Year);
            else Console.WriteLine("{0} is't a leap year", date.Year);
            Console.ReadKey();
        }
    }
}
