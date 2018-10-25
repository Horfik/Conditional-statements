using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Electriciti_bill
{
    class Program
    {
        class Bill
        {
            public int ID;
            public string Name;
            public double Unit;
            public Bill(int id, string name, double unit)
            {
                ID = id;
                Name = name;
                Unit = unit;
            }

            public void electriciti(double charge)
            {
                double surcharge = charge >= 1.8 ? Unit * charge * 0.15 : 0;
                Console.WriteLine("Customer IDNO : {0}", ID);
                Console.WriteLine("Customer Name: {0}", Name);
                Console.WriteLine("unit Consumed: {0}", Unit);
                Console.WriteLine("Amount Charges @Rs. {0} per unit: {1}", charge, Unit * charge);
                Console.WriteLine("Surchage Amount: {0}", surcharge);
                Console.WriteLine("Net Amount Paid By the Customer: {0}", Unit*charge+surcharge);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("enter customer id: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter customer name: ");
            String name = Console.ReadLine();
            Console.Write("enter customer unit: ");
            double unit = Convert.ToDouble(Console.ReadLine());
            Bill bill = new Bill(Id, name, unit);
            double Charge;
            switch (unit / 200)
            {
                case 0:
                    Charge = 1.2;
                    break;
                case 1:
                    Charge = 1.5;
                    break;
                case 2:
                    Charge = 1.8;
                    break;
                default:
                    Charge = 2.0;
                    break;
            }
            bill.electriciti(Charge);
            Console.ReadKey();
        }
    }
}
