using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Problem5LongestIncreasingSequence
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> increasingNumbers=new List<int>();
            List<int> longest = new List<int>(){input[0]};
            for (int i = 0,j=1; i < input.Length; i++,j++)
            {
                increasingNumbers.Add(input[i]);
                if ((j < input.Length) && (input[i]<input[j]))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(string.Join(" ", increasingNumbers));
                    if (longest.Count<increasingNumbers.Count)
                    {
                        longest.Clear();
                        longest.AddRange(increasingNumbers);
                    }
                    increasingNumbers.Clear();
                }
                
            }

            Console.WriteLine("Longest: {0}",string.Join(" ",longest));

        }
    }
}
