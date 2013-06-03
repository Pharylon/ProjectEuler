using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_20___FactorialDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger product = 1;
            int answer = 0;

            for (int i = 1; i <= 100; i++)
                product *= i;

            foreach (char c in product.ToString())
                answer += (int)Char.GetNumericValue(c);

            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
