using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_16___PowerDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            BigInteger n = 2;
            for (int i = 1; i < 1000; i++)
                n *= 2;
            string s = n.ToString();
            char[] cArray = s.ToCharArray();
            foreach (char c in cArray)
            {
                sum += Char.GetNumericValue(c);
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
