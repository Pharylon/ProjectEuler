using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Problem_10___AllPrimesBelow2Million
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<long> primeList = new List<long>();
            primeList.Add(2);

            while (primeList[primeList.Count - 1] < 2000000)
            {
                primeList.Add(findNextPrime(primeList));
            }
            primeList.Remove(primeList[primeList.Count - 1]);

            long sum = 0;
            foreach (long i in primeList)
                sum += i;

            Console.WriteLine(sum);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }

        private static int divisorNumber(List<long> factors)
        {
            ////Now add each unique prime facotr +1 together.
            long numberofDivisors = 1;

            for (int i = 0; i < factors.Count; i++)
            {
                if (i == 0)
                {
                    int timesOccuring = factors.Count(p => p == factors[i]);
                    numberofDivisors *= (timesOccuring + 1);
                }
                else if (factors[i] > factors[i - 1])
                {
                    int timesOccuring = factors.Count(p => p == factors[i]);
                    numberofDivisors *= (timesOccuring + 1);
                }
            }
            return (int)numberofDivisors;
        }

        private static long findNextPrime(List<long> primeList)
        {
            if (primeList.Count == 0)
                primeList.Add(2);

            if (primeList.Count == 1)
                primeList.Add(3);

            long i = primeList[primeList.Count - 1];
            bool foundPrime = false;
            while (!foundPrime)
            {
                i += 2;
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
            Console.WriteLine(i);
            return i;
        }
    }
}

        //private static long findNextPrime(List<long> primeList)
        //{
        //    long i = primeList[primeList.Count - 1];
        //    bool foundPrime = false;
        //    while (!foundPrime)
        //    {
        //        i++;
        //        foundPrime = true;
        //        foreach (long prime in primeList)
        //        {
        //            if (i % prime == 0)
        //            {
        //                foundPrime = false;
        //                break;
        //            }
        //        }
        //    }
        //    Console.WriteLine(i);
        //    return i;
        //}
