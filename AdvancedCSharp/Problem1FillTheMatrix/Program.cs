using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Problem1FillTheMatrix
{
    class Program
    {
        
        static void Main()
        {
            Console.Write("Enter N for matrix NxN: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix=new int[n,n];
            PaternA(matrix, n);
            PaternB(matrix, n);
            
        }
        private static void PaternA(int[,] matrix,int n)
        {
            Console.WriteLine("PaternA");
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[j, i] = count;
                    count++;
                    
                }
                
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}".PadLeft(4), matrix[i, j]);
                }
                Console.WriteLine();
            }
            
        }
        private static void PaternB(int[,] matrix,int n)
        {
            Console.WriteLine("PaternB");
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                if (i%2==0)
                {
                    for (int j = 0; j < n; j++)
                  {
                    matrix[j, i] = count;
                      count++;

                  }
                }
                if(i%2==1)
                {
                    for (int j = n-1; j >= 0; j--)
                    {
                        matrix[j, i] = count;
                        count++;

                    }
                }
                
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}".PadLeft(4), matrix[i, j]);
                }
                Console.WriteLine();
            }

        }


        
    }
}
