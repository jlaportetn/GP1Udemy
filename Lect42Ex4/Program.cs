using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect42Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the speed limit");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the current speed of your car");
            var speed = Convert.ToInt32(Console.ReadLine());

            if (speed < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                const int mphPerPoint = 5;
                var demeritPoints = ((speed - speedLimit) / mphPerPoint);
                if (demeritPoints > 12)
                {
                    Console.WriteLine("Your license has been suspended");
                }

                else
                {
                    Console.WriteLine("Your demerit points are " + demeritPoints);
                }
            }
            Console.ReadKey();
        }
    }
}
