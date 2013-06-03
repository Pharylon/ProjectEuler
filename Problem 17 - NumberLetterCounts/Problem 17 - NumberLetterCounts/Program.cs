using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17___NumberLetterCounts
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCharacters = 0;

            for (int i = 1; i <= 1000; i++)
                totalCharacters += noOfLetters(i);

            int x = noOfLetters(115);

            Console.WriteLine(totalCharacters);
            Console.ReadKey();
        }



        static int noOfLetters(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (number == 1000)
                return "oneThousand".Length;
            else if (number >= 100 && number < 1000)
            {
                string s = number.ToString();
                stringBuilder.Append(nameThatNumber(s[0])).Append("hundred");
                if (number % 100 != 0)
                    stringBuilder.Append("and");
                number -= (int)Char.GetNumericValue(s[0]) * 100;
            }

            if (number >= 20 && number < 100)
            {
                if (number >= 90)
                    stringBuilder.Append("ninety");
                else if (number >= 80)
                    stringBuilder.Append("eighty");
                else if (number >= 70)
                    stringBuilder.Append("seventy");
                else if (number >= 60)
                    stringBuilder.Append("sixty");
                else if (number >= 50)
                    stringBuilder.Append("fifty");
                else if (number >= 40)
                    stringBuilder.Append("forty");
                else if (number >= 30)
                    stringBuilder.Append("thirty");
                else if (number >= 20)
                    stringBuilder.Append("twenty");

                string s = number.ToString();
                stringBuilder.Append(nameThatNumber(s[1]));
            }

            if (number >= 10 && number < 20)
            {
                switch (number)
                {
                    case 10: stringBuilder.Append("ten"); break;
                    case 11: stringBuilder.Append("eleven"); break;
                    case 12: stringBuilder.Append("twelve"); break;
                    case 13: stringBuilder.Append("thirteen"); break;
                    case 14: stringBuilder.Append("fourteen"); break;
                    case 15: stringBuilder.Append("fifteen"); break;
                    case 16: stringBuilder.Append("sixteen"); break;
                    case 17: stringBuilder.Append("seventeen"); break;
                    case 18: stringBuilder.Append("eighteen"); break;
                    case 19: stringBuilder.Append("nineteen"); break;
                }
            }
            else if (number < 10)
            {
                string s = number.ToString();
                stringBuilder.Append(nameThatNumber(s[0]));
            }

            return stringBuilder.Length;
        }

        private static string nameThatNumber(char p)
        {
            switch (p)
            {
                case '1': return "one";
                case '2': return "two";
                case '3': return "three";
                case '4': return "four";
                case '5': return "five";
                case '6': return "six";
                case '7': return "seven";
                case '8': return "eight";
                case '9': return "nine";
                default: return "";
            }
        }



    }
}
