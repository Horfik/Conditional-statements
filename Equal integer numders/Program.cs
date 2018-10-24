using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_integer_numders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
                Console.WriteLine($"{a} and {b} are equal ");
            else Console.WriteLine($"{a} and {b} are not equal ");
            Console.ReadKey();
        }
    }
}
