using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_24___LexicographicPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lp = new List<int>();
            List<int> used = new List<int>();
            int count = 0;

            for (int a = 0; a < 10; a++)
            {
                used.Add(a);
                for (int b = 0; b < 10; b++)
                {
                    if (used.Contains(b))
                        continue;
                    used.Add(b);
                    for (int c = 0; c < 10; c++)
                    {
                        if (used.Contains(c))
                            continue;
                        used.Add(c);
                        for (int d = 0; d < 10; d++)
                        {
                            if (used.Contains(d))
                                continue;
                            used.Add(d);
                            for (int e = 0; e < 10; e++)
                            {
                                if (used.Contains(e))
                                    continue;
                                used.Add(e);
                                for (int f = 0; f < 10; f++)
                                {
                                    if (used.Contains(f))
                                        continue;
                                    used.Add(f);
                                    for (int g = 0; g < 10; g++)
                                    {
                                        if (used.Contains(g))
                                            continue;
                                        used.Add(g);
                                        for (int h = 0; h < 10; h++)
                                        {
                                            if (used.Contains(h))
                                                continue;
                                            used.Add(h);
                                            for (int i = 0; i < 10; i++)
                                            {
                                                if (used.Contains(i))
                                                    continue;
                                                used.Add(i);
                                                for (int j = 0; j < 10; j++)
                                                {
                                                    if (used.Contains(j))
                                                        continue;
                                                    used.Add(j);
                                                    StringBuilder sb = new StringBuilder();
                                                    sb.Append(a);
                                                    sb.Append(b);
                                                    sb.Append(c);
                                                    sb.Append(d);
                                                    sb.Append(e);
                                                    sb.Append(f);
                                                    sb.Append(g);
                                                    sb.Append(h);
                                                    sb.Append(i);
                                                    sb.Append(j);
                                                    count++;
                                                    if (count == 1000000)
                                                        Console.WriteLine(sb);
                                                    used.Remove(j);
                                                }
                                                used.Remove(i);
                                            }
                                            used.Remove(h);
                                        }
                                        used.Remove(g);
                                    }
                                    used.Remove(f);
                                }
                                used.Remove(e);
                            }
                            used.Remove(d);
                        }
                        used.Remove(c);
                    }
                    used.Remove(b);
                }
                used.Remove(a);
            }

        }
    }
}
