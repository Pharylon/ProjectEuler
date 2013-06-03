using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Problem_14___LargestCollatzSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            long startsBiggestChain = 1;
            long biggestCount = 1;

            for (long i = 1; i < 1000000; i++)
            {
                long thisCount = countCollatz(i);
                if (thisCount > biggestCount)
                {
                    startsBiggestChain = i;
                    biggestCount = thisCount;
                }
            }

            Console.WriteLine(startsBiggestChain);
            sw.Stop();
            Console.WriteLine("Solved in {0}", sw.Elapsed);
            Console.ReadKey();
        }

        private static long countCollatz(long startingNumber)
        {
            int chainCount = 1;
            while (startingNumber != 1)
            {
                if (startingNumber % 2 == 0)
                    startingNumber /= 2;
                else
                    startingNumber = ((startingNumber * 3) + 1);        
                chainCount++;
            }
            return chainCount;
        }
    }
}
