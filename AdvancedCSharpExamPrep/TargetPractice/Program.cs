    using System;
    using System.Collections.Generic;
    using System.Linq;

class Program
    {
        static void Main()
        {
            string[] nAndM = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(nAndM[0]);
            int m = int.Parse(nAndM[1]);
            string str = Console.ReadLine();
            int[] shot = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[,] matrix=new string[n,m];
            int count = 0;
            int index = 0;
            List<char> snake= str.ToList();
            
            for (int i = n - 1; i >= 0; i--)
            {
                if (count % 2 == 0)
                {
                    for (int j = m - 1; j >= 0; j--)
                    {
                        matrix[i, j] =String.Empty+ snake[index];
                        index++;
                        if (index==snake.Count)
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] =String.Empty+ snake[index];
                        index++;
                        if (index == snake.Count)
                        {
                            index = 0;
                        }
                    }
                }
                count++;

            }

            for (int x = shot[0] - shot[2]; x <= shot[0]; x++)
            {
                for (int y = shot[1] - shot[2]; y <= shot[1]; y++)
                {
                    // we don't have to take the square root, it's slow


                        if ((x - shot[0]) * (x - shot[0]) + (y - shot[1]) * (y - shot[1]) <= shot[2] * shot[2])
                    {       
                        int xSym = shot[0] - (x - shot[0]);
                       int  ySym = shot[1] - (y - shot[1]);
                        try
                        { 
                            matrix[x, y] = " ";
                        }
                        catch (IndexOutOfRangeException)
                        {}
                        try
                        {
                            matrix[x, ySym] = " ";
                        }
                        catch (IndexOutOfRangeException)
                        { }
                        try
                        {
                            matrix[xSym, y] = " ";
                        }
                        catch (IndexOutOfRangeException)
                        { }
                        try
                        {
                            matrix[xSym, ySym] = " ";
                        }
                        catch (IndexOutOfRangeException)
                        { }
                        // (x, y), (x, ySym), (xSym , y), (xSym, ySym) are in the circle
                    }

                    
   
                    
                }
            }
            for (int loop = 0; loop < 10; loop++)
            {
                for (int i = n-2; i >=0; i--)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] != " ")
                    {
                        if (matrix[i + 1, j] == " ")
                    {
                        matrix[i + 1, j] = matrix[i, j];
                        matrix[i, j] = " ";
                    }
                    }
                    
                }
                
            }
            }
            




            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }


        }
    }
