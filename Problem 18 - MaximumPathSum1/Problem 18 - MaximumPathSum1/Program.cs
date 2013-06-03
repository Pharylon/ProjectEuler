using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Problem_18___MaximumPathSum1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> importedArrays = new List<int[]>();
            importedArrays.Add(new int[] { 75 });
            importedArrays.Add(new int[] { 95, 64 });
            importedArrays.Add(new int[] { 17, 47, 82 });
            importedArrays.Add(new int[] { 18, 35, 87, 10 });
            importedArrays.Add(new int[] { 20, 04, 82, 47, 65 });
            importedArrays.Add(new int[] { 19, 01, 23, 75, 03, 34 });
            importedArrays.Add(new int[] { 88, 02, 77, 73, 07, 63, 67 });
            importedArrays.Add(new int[] { 99, 65, 04, 28, 06, 16, 70, 92 });
            importedArrays.Add(new int[] { 41, 41, 26, 56, 83, 40, 80, 70, 33 });
            importedArrays.Add(new int[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 });
            importedArrays.Add(new int[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 });
            importedArrays.Add(new int[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 });
            importedArrays.Add(new int[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 });
            importedArrays.Add(new int[] { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 });
            importedArrays.Add(new int[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 });

            int[] startingArray = importedArrays[0];
            NodeCollection nodeCollection = new NodeCollection(0, 0, startingArray[0]);

            int newRowStartPoint = -1;
            for (int i = 1; i < importedArrays.Count; i++)
            {
                int currentColumn = newRowStartPoint;
                for (int n = 0; n <= importedArrays[i].Length - 1; n++)
                {
                    int[] placeholderArray = importedArrays[i];
                    nodeCollection.Add(new NodeCollection(currentColumn, i, placeholderArray[n]));
                    currentColumn += 2;
                }
                newRowStartPoint--;
            }

            int sum = nodeCollection.PathValue;

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
