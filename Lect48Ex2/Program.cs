using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect48Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("Please enter a number, or ok to exit");
            var input = Console.ReadLine();

            while (input != "ok")
            {
                var number = Convert.ToInt32(input);
                sum += number;
                Console.WriteLine("The sum is " + sum);
            }
        }
    }
}
