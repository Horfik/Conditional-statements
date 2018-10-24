using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature: ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            switch (a/10)
            {
                case 0:
                    Console.WriteLine("Very Cold weather");
                    break;
                case 1:
                    Console.WriteLine("Cold weather");
                    break;
                case 2:
                    Console.WriteLine("Normal weather");
                    break;
                case 3:
                    Console.WriteLine("Hot weather");
                    break;
                default:
                    Console.WriteLine(a<0 ? "Freezing weather" : "Very Hot weather");
                    break;
            }
            Console.ReadKey();
        }
    }
}
