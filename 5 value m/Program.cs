using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_value_m
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int n;
            if (m == 0)
                Console.WriteLine("The value of n ={0}", n = 0);
            else Console.WriteLine("The value of n ={0}", n = m > 0 ? 1 : -1);
            Console.ReadKey();
        }
    }
}
