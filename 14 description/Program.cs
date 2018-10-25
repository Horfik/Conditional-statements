using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_description
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a grade:");
            string grade = Console.ReadLine();
            switch (grade)
            {
                case "e":
                case "E":
                    Console.WriteLine("Excellent");
                    break;
                case "v":
                case "V":
                    Console.WriteLine("Very good");
                    break;
                case "g":
                case "G":
                    Console.WriteLine("Good");
                    break;
                case "a":
                case "A":
                    Console.WriteLine("Average");
                    break;
                case "f":
                case "F":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.ReadKey();
        }
    }
}
