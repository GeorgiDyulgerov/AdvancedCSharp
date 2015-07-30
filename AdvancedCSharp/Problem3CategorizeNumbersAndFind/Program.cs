using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Problem3CategorizeNumbersAndFind
{
    class Program
    {
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            decimal[] numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            List<decimal> roundNums = new List<decimal>();
            List<decimal> floatNums = new List<decimal>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] % 1) == 0)
                {
                    roundNums.Add(numbers[i]);
                }
                else
                {
                    floatNums.Add(numbers[i]);
                }
            }

            Console.WriteLine("[" + string.Join(", ", floatNums) + "] -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}",
                                floatNums.Min(), floatNums.Max(), floatNums.Sum(), floatNums.Average());

            Console.WriteLine("[" + string.Join(", ", roundNums) + "] -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}",
                                roundNums.Min(), roundNums.Max(), (int)roundNums.Sum(), roundNums.Average());

        }
    }
}
