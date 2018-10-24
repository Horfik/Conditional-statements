using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Type_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first side: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second side: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third side: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a == b & a == c & c == b)
                Console.WriteLine("triangle is Equilateral");
            else if (a == b || a == c || b == c)
                Console.WriteLine("triangle is Isosceles");
            else Console.WriteLine("triangle is Scalene");
            Console.ReadKey();
        }
    }
}
