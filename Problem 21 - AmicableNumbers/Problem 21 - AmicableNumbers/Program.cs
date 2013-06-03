using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_21___AmicableNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeList = sieve(10000);
            List<int> amicableNumbers = new List<int>();
            int answer = 0;

            for (int i = 1; i <= 10000; i++)
            {
                List<int> divisors = getDivisors(i, primeList);
                int sumOfDivisors = 0;
                foreach (int d in divisors)
                    sumOfDivisors += d;

                int otherSumOfDivisors = 0;
                List<int> otherDivisors = getDivisors(sumOfDivisors, primeList);
                foreach (int d in otherDivisors)
                    otherSumOfDivisors += d;

                if (otherSumOfDivisors == i && i != sumOfDivisors)
                {
                    if (!amicableNumbers.Contains(i))
                        amicableNumbers.Add(i);
                    if (!amicableNumbers.Contains(sumOfDivisors))
                        amicableNumbers.Add(sumOfDivisors);
                }
            }


            foreach (int a in amicableNumbers)
                answer += a;

            Console.WriteLine(answer);
            Console.ReadKey();
        }

        private static List<int> getDivisors(int numberToFactor, List<int> primeList)
        {
            List<int> divisors = new List<int>();
            divisors.Add(1);

            int unfactoredPortion = numberToFactor;

            foreach (int prime in primeList)
            {
                while (unfactoredPortion % prime == 0)
                {
                    unfactoredPortion /= prime;
                    if (!divisors.Contains(prime) && prime != numberToFactor)
                        divisors.Add(prime);
                }
            }

            bool foundAllMultiples = false;
            while (!foundAllMultiples)
            {
                int product = 0;
                foundAllMultiples = true;
                for (int a = 0; a < divisors.Count; a++)
                    for (int b = 0; b < divisors.Count; b++)
                        if (((double)numberToFactor / ((double)divisors[a] * (double)divisors[b])) % 1 == 0 && !divisors.Contains(divisors[a] * divisors[b]) && divisors[a] * divisors[b] != numberToFactor)
                        {
                            divisors.Add(divisors[a] * divisors[b]);
                            foundAllMultiples = false;
                        }
            }

            if (unfactoredPortion != numberToFactor && unfactoredPortion != 1)
                divisors.Add(unfactoredPortion);
            if (divisors.Contains(numberToFactor) && numberToFactor != 1)
                divisors.Remove(numberToFactor);
            return divisors;
        }

        static List<int> sieve(int max)
        {
            var vals = new List<int>((int)(max / (Math.Log(max) - 1.08366)));
            var maxSquareRoot = Math.Sqrt(max);
            var eliminated = new System.Collections.BitArray(max + 1);

            vals.Add(2);

            for (int i = 3; i <= max; i += 2)
            {
                if (!eliminated[i])
                {
                    if (i < maxSquareRoot)
                    {
                        for (int j = i * i; j <= max; j += 2 * i)
                            eliminated[j] = true;
                    }
                    vals.Add(i);
                }
            }
            return vals;
        }
    }
}
