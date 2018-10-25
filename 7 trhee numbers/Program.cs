using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_trhee_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third number: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if ((a > b & a > c))
                Console.WriteLine("The 1st Number is the greatest among three");
            else if (a != b & a != c & c != a)
                Console.WriteLine(b > c ? "The 2nd Number is the greatest among three " : "The 3rd Number is the greatest among three");
            else Console.WriteLine();

            Console.ReadKey();
        }
    }
}
