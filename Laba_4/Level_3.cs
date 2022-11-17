using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    class Level_3
    {
        static void Main(string[] args)
        {
            N10();
            Console.ReadLine();
        }
        public static void N10()
        {
            int[,] mas = Rand(4, 4, -10, 11);
            Print(mas);
            double half = mas.GetLength(0) / 2;
            int c = 0;

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        for (int t = j+1; t < mas.GetLength(1); t++)
                        {
                            if (mas[i, j] > mas[i, t])
                            {
                                int k = mas[i, j];
                                mas[i, j] = mas[i, t];
                                mas[i, t] = k;
                            }
                        }
                    }
                    else
                    {
                        for (int t = j+1; t < mas.GetLength(1); t++)
                        {
                            if (mas[i, j] < mas[i, t])
                            {
                                int k = mas[i,j];
                                mas[i, j] = mas[i, t];
                                mas[i, t] = k;
                            }
                        }
                    }
                }
            }
            Print(mas);
            Console.WriteLine(half);
        }
        public static void N9()
        {
            int[,] mas = Rand(5, 5, -10, 11);
            Print(mas);
        }
        static int[,] Rand(int n, int m, int min, int max)
        {
            Random random = new Random();

            int[,] mas = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = random.Next(min, max);
                }
            }
            return mas;
        }
        static double[,] RandDouble(int n, int m, int min, int max)
        {
            Random random = new Random();

            double[,] mas = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = random.Next(min, max);
                }
            }
            return mas;
        }
        static void Print(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void PrintDouble(double[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void DeleteColumn(ref int[,] mas, int column)
        {

            int[,] mass = new int[mas.GetLength(0), mas.GetLength(1) - 1];


            for (int i = 0; i < mas.GetLength(0); i++)
            {
                int k = 0;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (j == column)
                    {
                        continue;
                    }
                    mass[i, k] = mas[i, j];
                    k++;

                }
            }

            mas = mass;
        }
        static void DeleteRow(ref int[,] mas, int row)
        {

            int[,] mass = new int[mas.GetLength(0) - 1, mas.GetLength(1)];


            int k = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                if (i == row)
                {
                    continue;
                }
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mass[k, j] = mas[i, j];
                }
                k++;
            }

            mas = mass;
        }
    }
}


