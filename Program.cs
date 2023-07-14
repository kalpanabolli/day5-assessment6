using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_assessment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] studentScores = new int[3][];
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write($"Enter the number of scores for student {i + 1}: ");
                int numScores = int.Parse(Console.ReadLine());
                studentScores[i] = new int[numScores];
                for (int j = 0; j < numScores; j++)
                {
                    Console.Write($"Enter score {j + 1} for student {i + 1}: ");
                    studentScores[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.WriteLine($"Scores for student {i + 1}:");

                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.WriteLine($"Score {j + 1}: {studentScores[i][j]}");
                }

                Console.WriteLine();
            }
            for (int i = 0; i < studentScores.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }

                double average = (double)sum / studentScores[i].Length;

                Console.WriteLine($"Average score for student {i + 1}: {average:F2}");
            }
            int totalSum = 0;
            int totalCount = 0;

            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalCount++;
                }
            }

            double totalAverage = (double)totalSum / totalCount;

            Console.WriteLine($"Average score for all students combined: {totalAverage:F2}");
            Console.ReadKey();
        }
    }
}
