    using System;
    using System.Collections.Generic;

class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];
            List<string> sequence=new List<string>();
            int count;
            string check;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Console.ReadLine();

                }
            }
            check = matrix[0, 0];
            foreach (var s in matrix)
            {
                Console.WriteLine(s);
            }



        }
    }
