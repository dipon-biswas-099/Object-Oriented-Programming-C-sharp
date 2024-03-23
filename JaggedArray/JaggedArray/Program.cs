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
            int[][] jaggerArr = new int[][]
            {
                new int[] {1,2,3,4},
                new int[] {5,6,7},
                new int[] {8,9}
            };

            for (int i = 0; i < jaggerArr.Length; i++)
            {
                Console.Write("Jagged Array [" + i + "] = ");
                for (int j = 0; j < jaggerArr[i].Length; j++)
                {
                    Console.Write(jaggerArr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
