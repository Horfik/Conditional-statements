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
            Console.Write("Enter first side: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second side: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third side: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("triangle can be formed");
            else Console.WriteLine("triangle can't be formed");
            Console.ReadKey();
        }
    }
}
