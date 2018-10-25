using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Month_day
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In {0} month {1} days",month, DateTime.DaysInMonth(2018, month));
            Console.ReadKey();
        }
    }
}
