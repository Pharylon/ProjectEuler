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
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            bool answerFound = false;
            //List<long> triangleList = new List<long>();
            List<long> primeList = new List<long>();
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
                List<long> factors = factor(triangleNumber, ref primeList);

                if (triangleNumber >= 28)
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

        private static List<long> factor(long unfactoredPortion, ref List<long> primeList)
        {
            List<long> factors = new List<long>();

            //Manually add 2 and 3 if passed an empty/small prime List

            if (primeList.Count == 0)
                primeList.Add(2);

            if (primeList.Count == 1)
                primeList.Add(3);

            //Check already discovered primes.
            foreach (long prime in primeList)
            {
                while (unfactoredPortion % prime == 0)
                {
                    unfactoredPortion /= prime;
                    factors.Add(prime);
                }
            }

            //Code to execute when we need more primes.

            while (primeList[primeList.Count - 1] < unfactoredPortion)
            {
                if (unfactoredPortion % primeList[primeList.Count - 1] == 0) //Check to see if remainder is a prime.
                {
                    unfactoredPortion /= primeList[primeList.Count - 1];
                    factors.Add(primeList[primeList.Count - 1]);
                }
                else //Get the next prime, add it to the list.
                {
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
                    primeList.Add(i);
                }
            }
            factors.Add(unfactoredPortion);
            return factors;
        }
    }
}

            