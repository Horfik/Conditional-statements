using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ax^2+bx+c=result");
            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter result: ");
            double d = Convert.ToDouble(Console.ReadLine());
            if (b * b - 4 * a * (c - d) > 0)
                Console.WriteLine("x1 = {0} and x2 = {1}", ((-b + Math.Sqrt(b * b - 4 * a * (c - d))) / (2 * a)), ((-b - Math.Sqrt(b * b - 4 * a * (c - d))) / (2 * a)));
            else if (b * b - 4 * a * (c - d) == 0)
                Console.WriteLine("x1 = {0}", ((-b + Math.Sqrt(b * b - 4 * a * (c - d))) / (2 * a)));
            else Console.WriteLine("No roots");
            Console.ReadKey();
        }
    }
}
