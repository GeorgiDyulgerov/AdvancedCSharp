using System;
using System.Data;
using System.Threading;

    class Program
    {
        static void Main()
        {
            bool start = true;
            while (start==true)
            {
                string comand = Console.ReadLine();
                if (comand=="end")
                {
                    start = false;
                    break;
                }
                else
                {
                    int number = int.Parse(comand);
                    Console.WriteLine(GetLastDigitAsWord(number));
                    number=new int();
                }
            }


        }

        static string GetLastDigitAsWord(int number)
        {
            int last = number%10;
            switch (last)
            {
                case 1:
                    return "one";
                    break;
                case 2:
                    return "two";
                    break;
                case 3:
                    return "tree";
                    break;
                case 4:
                    return "four";
                    break;
                case 5:
                    return "five";
                    break;
                case 6:
                    return "six";
                    break;
                case 7:
                    return "seven";
                    break;
                case 8:
                    return "eight";
                    break;
                case 9:
                    return "nine";
                    break;
                case 0:
                    return "zero";
                    break;
            }
            return "no number";
        }
    }
