    using System;
    using System.Linq;
    using System.Net;

internal class Program
{
    private static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(LargerThanNeighbours(numbers, i));
        }
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeigbors(numbers));


    }

    private static string GetIndexOfFirstElementLargerThanNeigbors(int[] numbers)
    {
        string result="-1";
        for (int i = 0; i < numbers.Length; i++)
        {
            string check = LargerThanNeighbours(numbers, i);
            if (check=="True")
            {
                result = numbers[i].ToString();
                break;
            }
        }
        return result;
    }

    private static string LargerThanNeighbours(int[] numbers, int i)
    {
        if (i==0 || i==numbers.Length-1)
        {
          if (i == 0)
        {
            if (numbers[i] > numbers[i + 1])
            {
                return "True";
            }
            else
            {
                return "False";
            }
        }

        if (i == numbers.Length-1)
        {
            if (numbers[i] > numbers[i - 1])
            {
                return "True";
                
            }
            else
            {
                return "False";
            }
        }  
        }
        else
        {
            if (numbers[i]>numbers[i-1]&&numbers[i]>numbers[i+1])
            {
                return "True";
            }
            else
            {
                return "False";
            }
        }

        return "Error!";

    }
}
