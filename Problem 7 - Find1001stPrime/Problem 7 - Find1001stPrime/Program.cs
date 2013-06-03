using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7___Find1001stPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> primeList = new List<long>();
            primeList.Add(2);

            while (primeList.Count < 10001)
            {
                primeList.Add(findNextPrime(primeList));
            }

            Console.WriteLine(primeList[10000]);
            Console.ReadLine();
        }

        private static long findNextPrime(List<long> primeList)
        {
            long i = primeList[primeList.Count - 1];
            bool foundPrime = false;
            while (!foundPrime)
            {
                i++;
                foundPrime = true;
                foreach (long prime in primeList)
                {
                    if (i % prime == 0)
                    {
                        foundPrime = false;
                        break;
                    }
                }
            }
            return i;
        }
    }
}
