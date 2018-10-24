using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_height
{
    
    class Program
    {
        public static void Print(string category)
        {
            Console.WriteLine("The person is {0}", category);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            string cat;
            if (170 <= height & height <= 180)
                Print("normal");
            else if (height < 170)
                Print(cat = height < 150 ? "Dwarf" : "Low");
            else Print(cat = height > 200 ? "Giant" : "Tall");

            Console.ReadKey();
        }
    }
}
