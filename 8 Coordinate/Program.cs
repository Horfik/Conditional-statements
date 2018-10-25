using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Coordinate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            string n = a > 0 ? "+" : "-";
            if (a > 0 & b != 0)
                Console.WriteLine(b > 0 ? "The coordinate point ({0}, {1}) lies in the First quadrant" : "The coordinate point ({0}, {1}) lies in the Second quadrant", a, b);
            else if (a < 0 & b != 0)
                Console.WriteLine(b > 0 ? "The coordinate point ({0}, {1}) lies in the Fourth quadrant" : "The coordinate point ({0}, {1}) lies in the Third quadrant", a, b);
            else if (a == 0 & b != 0)
                Console.WriteLine(b > 0 ? "The coordinate point ({0}, {1}) lies between First and Fourth quadrants" : "The coordinate point ({0}, {1}) lies between Third and Second quadrants", a, b);
            else if (b == 0 & a != 0)
                Console.WriteLine(a > 0 ? "The coordinate point ({0}, {1}) lies between First and Second quadrants" : "The coordinate point ({0}, {1}) lies between Third and Fourth quadrants", a, b);
            else Console.WriteLine("The coordinate point({0}, {1}) lies in the center", a, b);
            
            Console.ReadKey();
        }
    }
}
