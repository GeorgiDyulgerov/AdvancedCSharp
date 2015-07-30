    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Threading;

class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double reversed =GetReversedNumber(double.Parse(Console.ReadLine()));
            Console.WriteLine(reversed);
        }

        private static double GetReversedNumber(double number)
        {
            string numberInString = number.ToString();
            string result="";
            foreach (char c in numberInString.Reverse())
            {
                result += c;
            }
            
            return double.Parse(result);


        }
    }
