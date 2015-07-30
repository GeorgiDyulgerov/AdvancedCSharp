    using System;
    using System.Linq;

class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[,] matrix=new string[n,m];
            int x1, x2, y1, y2;
            string swapper;
            string[] comand=new string[5];
            bool end = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Console.ReadLine();

                }
            }
            while (end==false)
            {
                comand = Console.ReadLine().Split(' ').ToArray();
                switch (comand[0])
                {
                    case "swap":
                        try
                        {
                            x1 = int.Parse(comand[1]);
                            y1 = int.Parse(comand[2]);
                            x2 = int.Parse(comand[3]);
                            y2 = int.Parse(comand[4]);
                            Console.WriteLine("(after swapping {0} and {1}):", matrix[x1, y1], matrix[x2, y2]);
                            swapper = matrix[x1, y1];
                            matrix[x1, y1] = matrix[x2, y2];
                            matrix[x2, y2] = swapper;
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < m; j++)
                                {
                                    Console.Write("{0} ", matrix[i, j]);
                                }
                                Console.WriteLine();
                            }

                        }
                        catch (IndexOutOfRangeException)
                        {

                            Console.WriteLine("Invalid input!");
                            
                        }
                        break;
                    case "END":
                        end = true;
                        break;


                }


            }


        }
    }
