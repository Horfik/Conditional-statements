using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first angles: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second angles: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third angles: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a+b+c == 180)
                Console.WriteLine("triangle can be formed");
            else Console.WriteLine("triangle can't be formed");
            Console.ReadKey();
        }
    }
}
