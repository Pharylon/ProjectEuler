using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Problem_12___HighlyDivisibleTriangularNum
{

    class Program
    {
        static List<long> primeList;

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            bool answerFound = false;
            //List<long> triangleList = new List<long>();
            primeList = new List<long>();
            long triangleNumber = 0;
            //triangleList.Add(1);
            //triangleList.Add(3);
            long currentNaturalNumber = 1;

            //create a loop that finds every triangle number
            while (!answerFound)
            {
                triangleNumber += currentNaturalNumber;
                //Console.WriteLine(triangleNumber);
                

                //Factor the number
                List<long> factors = factor(triangleNumber, primeList);

                if (triangleNumber >= 6)
                { }
                //Calculate the number of divisors
                if (divisorNumber(factors) >= 500)
                    answerFound = true;

                Console.WriteLine(triangleNumber);
                currentNaturalNumber++;
            }

            Console.WriteLine(triangleNumber);
            sw.Stop();
            Console.WriteLine("Solved in {0}", sw.Elapsed);
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
                    int timesOccuring = factors.Count(p=> p == factors[i]);
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

        private static List<long> factor(long unfactoredPortion, List<long> primeList)
        {
            List<long> factors = new List<long>();

            foreach (long prime in nextPrime(primeList))
            {
                if (isPrime(unfactoredPortion, primeList))
                    break;
                while (unfactoredPortion % prime == 0)
                {
                    unfactoredPortion /= prime;
                    factors.Add(prime);
                }
            }

            factors.Add(unfactoredPortion);
            return factors;
        }

        private static IEnumerable<long> nextPrime(List<long> primeList)
        {
            //Manually add 2 and 3 if passed an empty/small prime List

            if (!primeList.Contains(2))
                primeList.Add(2);

            if (!primeList.Contains(3))
                primeList.Add(3);

            //primeList.Sort();

            foreach (long prime in primeList)
                yield return prime;


            long lastPrime = primeList.Last();

            while (true)
            {
                while (!isPrime(lastPrime, primeList))
                    lastPrime += 2;
                primeList.Add(lastPrime);
                yield return lastPrime;
            }
        }

        private static bool isPrime(long lastPrime, List<long> primeList)
        {
            foreach (long prime in primeList)
                if (lastPrime % prime == 0)
                    return false;
            return true;
        }
    }
}

            