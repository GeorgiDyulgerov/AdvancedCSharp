using System;
using System.Collections.Generic;
using System.Data;
using System.Security;

namespace ClearingCommands
{
    class Program
    {
        private const string specialSymbols = "<>v^";
        static void Main()
        {
            List<char[]> matrix=new List<char[]>();
            FillMatrix(matrix);
            ClearMatrix(matrix);
            PrintMatrix(matrix);


        }

        private static void ClearMatrix(List<char[]> matrix)
        {
            for (int row = 0; row < matrix.Count; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    switch (matrix[row][col])
                    {
                        case '<':
                            ClearCells(matrix, row, col - 1, 0, -1);
                            break;
                        case '>':
                            ClearCells(matrix, row, col + 1, 0, 1);
                            break;
                        case 'v':
                            ClearCells(matrix, row + 1, col, 1, 0);
                            break;
                        case '^':
                            ClearCells(matrix, row - 1, col, -1, 0);
                            break;
                    }
                }
            }
        }

        private static void ClearCells(List<char[]> matrix, int row, int col , int rowUpdate,int colUpdate)
        {
            while (OutOfRangeCheck(matrix,row,col)&&!specialSymbols.Contains(matrix[row][col].ToString()))
            {
                matrix[row][col] = ' ';
                col += colUpdate;
                row += rowUpdate;
            }

        }

        private static bool OutOfRangeCheck(List<char[]> matrix,int row, int col )
        {
            try
            {
                matrix[row][col].GetType();
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                return false;

            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }

        private static void FillMatrix(List<char[]> matrix)
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (line=="END")
                {
                    break;;
                }
                matrix.Add(line.ToCharArray());
            }

        }

        private static void PrintMatrix(List<char[]> matrix)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                Console.WriteLine("<p>{0}</p>",SecurityElement.Escape(new string(matrix[i])));

            }


        }

    }
}
