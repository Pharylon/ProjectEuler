using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_23___NonAbundantSums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeList = sieve(30000);
            List<int> abundantNumbers = new List<int>();

            for (int i = 2; i < 30000; i++)
            {
                if (i == 18)
                { }
                List<int> factors = getDivisors(i, primeList);
                int sum = 0;
                foreach (int f in factors)
                    sum += f;
                if (sum > i)
                    abundantNumbers.Add(i);
            }

            List<int> noAbundants = new List<int>();
            for (int i = 0; i < 28124; i++)
                noAbundants.Add(i);

            foreach (int a in abundantNumbers)
                foreach (int b in abundantNumbers)
                    noAbundants.Remove(a + b);

            int finalSum = 0;
            foreach (int i in noAbundants)
                finalSum += i;

            Console.WriteLine(finalSum);


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
