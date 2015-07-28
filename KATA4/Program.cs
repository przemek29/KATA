using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KATA1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double s,d;
            Console.Write("How much Shilling you want to change for?: ");

            
            if (!double.TryParse(Console.ReadLine(), out s))
            {
                Console.WriteLine("Invalid amount!");
                Console.ReadKey();
                return;
            }
           
            Console.Write("How much Pence you want to change for?: ");
            if (!double.TryParse(Console.ReadLine(), out d))
            {
                Console.WriteLine("Invalid amount!");
                Console.ReadKey();
                return;
            }


            var calculator = new ChangeCalculator();
            var changeGiven = calculator.Calculate(s, d);

            PrintResult(changeGiven);

            Console.ReadKey();
        }

        private static void PrintResult(IDictionary<string, int> changeGiven)
        {
            if (changeGiven == null)
                return;

            foreach (var item in changeGiven)
            {
                Console.WriteLine("Was paid: " + item.Value + " x " + item.Key);
            }
        }
    }
}
