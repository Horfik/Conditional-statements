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
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a>b & a>c)? "The 1st Number is the greatest among three " : b > c ? "The 2nd Number is the greatest among three " : "The 3rd Number is the greatest among three");

            Console.ReadKey();
        }
    }
}
