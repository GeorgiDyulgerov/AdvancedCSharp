using System;
using System.Linq;

namespace Problem2MaximalSum
{
    class Program
    {
        static void Main()
        {
            int[] nAndM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nAndM[0];
            int m = nAndM[1];
            int[,] matrix=new int[n,m];
            int[,] sumMatrix=new int[3,3];
            int[,] maxMatrix=new int[3,3];
            int sum = 0;
            int check = 0;
            int row;
            int colum;
            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }
            for (int i = 0; i <= n-3; i++)
            {
                row = i;
                for (int j = 0; j <= m-3; j++)
                {
                    row = i;
                    colum = j;
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            sumMatrix[k, l] = matrix[row, colum];
                            sum += matrix[row, colum];
                            colum++;
                        }
                        colum = j;
                        row++;
                    }
                    if (sum>check)
                    {
                        maxMatrix = sumMatrix;
                        check = sum;
                        
                    }
                    sum = 0;
                }
                
            }






            Console.WriteLine("Sum= "+check);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ",maxMatrix[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
}
