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
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter equally: ");
            int d = Convert.ToInt32(Console.ReadLine());
            if (b * b - 4 * a * (c - d) > 0)
                Console.WriteLine("x1 = {0} and x2 = {1}", ((-b + Math.Sqrt(b * b - 4 * a * (c - d))) / (2 * a)), ((-b - Math.Sqrt(b * b - 4 * a * (c - d))) / (2 * a)));
            else if (b * b - 4 * a * (c - d) == 0)
                Console.WriteLine("x1 = {0}", ((-b + Math.Sqrt(b * b - 4 * a * (c - d))) / (2 * a)));
            else Console.WriteLine("No roots");
            Console.ReadKey();
        }
    }
}
