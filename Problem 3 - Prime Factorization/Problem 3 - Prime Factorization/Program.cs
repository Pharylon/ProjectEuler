using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            List<long> factors = factor(600851475143);
            //Console.WriteLine(factors[factors.Count - 1]);
            //List<long> factors = factor(8);
            foreach (long f in factors)
                Console.WriteLine(f);
            Console.ReadKey();
        }

        static List<long> factor(long unfactoredPortion)
        {
            List<long> factors = new List<long>();
            List<long> primeList = new List<long>();
            primeList.Add(2);

            while (primeList[primeList.Count - 1] != unfactoredPortion)
            {
                if (unfactoredPortion % primeList[primeList.Count - 1] == 0)
                {
                    unfactoredPortion /= primeList[primeList.Count - 1];
                    factors.Add(primeList[primeList.Count - 1]);
                }
                else //Here we find the next Prime and add it to the pimeList for future checking.
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
                    primeList.Add(i);
                }
            }
            factors.Add(unfactoredPortion);
            return factors;
        }
    }
}

