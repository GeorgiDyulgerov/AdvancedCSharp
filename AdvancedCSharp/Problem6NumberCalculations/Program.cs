    using System;
    using System.Linq;
    using System.Runtime.InteropServices;

class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            GetMinimum(numbers);
            GetMaximum(numbers);
            GetAvarage(numbers);
            GetSum(numbers);
            
        }

        private static void GetSum(double[] numbers)
        {
            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;

            }
            Console.WriteLine("Sum: " + sum);

        }

    private static void GetAvarage(double[] numbers)
    {
        double sum = 0;
        foreach (var number in numbers)
        {
            sum += number;

        }
        Console.WriteLine("Avarage: {0:##.##}" ,(sum/numbers.Length));
    }

    private static void GetMaximum(double[] numbers)
        {
            double max = (double)numbers[0];
            foreach (var number in numbers)
            {
                if (max < number)
                {
                    max = number;
                }

            }
            Console.WriteLine("Max: " + max);


        }

        private static void GetMinimum(double[] numbers)
        {
            double min = numbers[0];
            foreach (var number in numbers)
            {
                if (min > number)
                {
                    min = number;
                }

            }
            Console.WriteLine("Min: " + min);

        }
    }
