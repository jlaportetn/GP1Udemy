using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect48Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 0;
            {
                Console.WriteLine("Please enter a number");
                var userInput = Console.ReadLine();
                number = Convert.ToInt32(userInput);
            }
            int ifactor = 1;
            for (var factor = number; factor >= 1; factor--)
                ifactor = factor * ifactor;
            {
                Console.WriteLine(number + "! = " + ifactor);
                Console.ReadKey();
            }
        }
    }
}
