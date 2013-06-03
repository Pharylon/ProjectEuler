using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_22___NamesScores
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameArray = new string[0];
            List<string> nameList = new List<string>();
            string fileLocation = @"names.txt";

            using (StreamReader reader = new StreamReader(fileLocation))
                while (!reader.EndOfStream)
                    nameArray = reader.ReadLine().Split(',');


            for (int i = 0; i < nameArray.Length; i++)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(nameArray[i]);
                builder.Replace("\"", "");
                nameList.Add(builder.ToString());
            }

            nameList.Sort();
            long product = 0;

            for (int i = 0; i < nameList.Count; i++)
            {
                if (nameList[i] == "COLIN")
                { }
                int value = 0;
                int sum = 0;
                foreach (char c in nameList[i])
                {
                    sum += getCharValue(c);
                }
                value = sum * (i + 1);
                product += value;
            }

            Console.WriteLine(product);
            Console.ReadKey();
        }

        private static int getCharValue(char c)
        {
            switch (c)
            {
                case 'A': return 1;
                case 'B': return 2;
                case 'C': return 3;
                case 'D': return 4;
                case 'E': return 5;
                case 'F': return 6;
                case 'G': return 7;
                case 'H': return 8;
                case 'I': return 9;
                case 'J': return 10;
                case 'K': return 11;
                case 'L': return 12;
                case 'M': return 13;
                case 'N': return 14;
                case 'O': return 15;
                case 'P': return 16;
                case 'Q': return 17;
                case 'R': return 18;
                case 'S': return 19;
                case 'T': return 20;
                case 'U': return 21;
                case 'V': return 22;
                case 'W': return 23;
                case 'X': return 24;
                case 'Y': return 25;
                case 'Z': return 26;
                default: return 1;
            }
        }
    }
}