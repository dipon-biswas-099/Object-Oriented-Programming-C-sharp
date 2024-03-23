using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] jaggedArr = new int[][,]
            {
                new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } },
                new int[,] { { 1, 2, 3 }, { 3, 5, 6 } },
                new int[,] { { 1, 2, 3, 4 } }
            };

            Console.WriteLine("Elements of jagged array: \n");
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.WriteLine($"Array {i + 1}:");
                for (int j = 0; j < jaggedArr[i].GetLength(0); j++)
                {
                    for (int k = 0; k < jaggedArr[i].GetLength(1); k++)
                    {
                        Console.WriteLine($"[{j},{k}] = {jaggedArr[i][j, k]}");
                    }
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
