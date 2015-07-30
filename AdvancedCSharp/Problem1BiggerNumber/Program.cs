using System;
using System.Dynamic;

class Program
    {
        
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int max = GetMax(firstNum, secondNum);
            Console.WriteLine(max);

        }
        static int GetMax(int a,int b)
        {
            if (a>b)
            {
                return a;
            }
            if (b>a)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }