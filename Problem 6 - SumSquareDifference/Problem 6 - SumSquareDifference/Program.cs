using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6___SumSquareDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            long answer = 0;
            long sumOfSquares = 0;
            long squareofSums = 0;

            for (int i = 0; i <= 100; i++)
                sumOfSquares += (i * i);

            for (int i = 0; i <= 100; i++)
            {
                squareofSums += i;
            }

            squareofSums *= squareofSums;

            answer = squareofSums - sumOfSquares;

            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
