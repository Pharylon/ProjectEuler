using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_19___CountingSundays
{
    class Program
    {
        static void Main(string[] args)
        {
            int sundays = 0;

            for (int y = 1901; y <= 2000; y++)
                for (int m = 1; m <= 12; m++)
                {
                    DateTime x = new DateTime(y, m, 1);
                    if (x.DayOfWeek == DayOfWeek.Sunday)
                        sundays++;
                }

            Console.WriteLine(sundays);
            Console.ReadKey();

        }
    }
}
