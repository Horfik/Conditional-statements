using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positive_or_negative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a >= 0)
                Console.WriteLine($"{a} is a positive number");
            else Console.WriteLine($"{a} is a negative number");
            Console.ReadKey();
        }
    }
}
