using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Largest_Palindrome_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            //Build a list of all numbers that are the product of two 3 digit numbers.
            //Check if it's a palindrome. 
            //Done!


            List<int> products = new List<int>();
            for (int i = 100; i < 1000; i++)
                for (int n = 100; n < 1000; n++)
                    products.Add(n*i);

            products.Sort();

            for (int i = products.Count -1; i >= 0; i--)
            {
                string intToString = products[i].ToString();
                char[] placeholder = intToString.ToCharArray();
                Array.Reverse(placeholder);
                string intToStringReversed = new string(placeholder);
                if (intToString.Equals(intToStringReversed))
                {
                    Console.WriteLine(products[i]);
                    break;
                }
            }
            Console.ReadKey();

          
        }
    }
}
