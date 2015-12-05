using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect42Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            var number1AsString = Console.ReadLine();
            var number1 = Convert.ToInt32(number1AsString);

            Console.WriteLine("Please enter a second number");
            var number2AsString = Console.ReadLine();
            var number2 = Convert.ToInt32(number2AsString);

            if (number1 > number2)
            {
                Console.WriteLine("Max is " + number1);
            }
            else
            {
                Console.WriteLine("max is " + number2);
            }
            Console.ReadKey();
        }

    }
}
