//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Laba_4
//{
//    class Leve_2
//    {
//        static void Main(string[] args)
//        {
//            N8();
//            Console.ReadLine();
//        }

//        public static void N4()
//        {
//            int[,] mat = Rand(7, 5, -10, 11);
//            int[] masB = new int[5] { 11, 11, 11, 11, 11 };
//            int maxMas = 0;
//            Print(mat);
//            int k = 0;
//            for (int i = 0; i < mat.GetLength(1); i++)
//            {

//                int maxMat = 0;
//                for (int j = 0; j < mat.GetLength(0); j++)
//                {
//                    if (mat[j, i] > maxMat)
//                    {
//                        maxMat = mat[j, i];
//                        k = j;
//                    }

//                }

//                if (masB[i] > maxMat)
//                {
//                    mat[k, i] = masB[i];
//                }
//                Console.WriteLine(maxMat);
//            }
//            Print(mat);
//        }
//        public static void N8()
//        {
//            int[,] mas = Rand(6, 6, -10, 11);
//            Print(mas);
//            int max1 = 0;
//            int max2 = 0;
//            int max3 = 0;
//            int max4 = 0;
//            int max5 = 0;
//            int max6 = 0;
//            int k1 = 0;
//            int k2 = 0;
//            int k3 = 0;
//            int k4 = 0;
//            int k5 = 0;
//            int k6 = 0;

//            for (int i = 0; i < mas.GetLength(0); i++)
//            {
//                for (int j = 0; j < mas.GetLength(1); j++)
//                {
//                    if (mas[i, j] > max1&&j==0)
//                    {
//                        max1 = mas[i, j];
//                        k1 = j;
//                    }
//                    if (mas[i, j] > max1&&j==1)
//                    {
//                        max2 = mas[i, j];
//                        k2 = j;
//                    }
//                    if (mas[i, j] > max1&&j==2)
//                    {
//                        max3 = mas[i, j];
//                        k3 = j;
//                    }
//                    if (mas[i, j] > max1&&j==3)
//                    {
//                        max4 = mas[i, j];
//                        k4 = j;
//                    }
//                    if (mas[i, j] > max1&&j==4)
//                    {
//                        max5 = mas[i, j];
//                        k5 = j;
//                    }
//                    if (mas[i, j] > max1&&j==5)
//                    {
//                        max6 = mas[i, j];
//                        k6 = j;
//                    }
//                }
//                mas[i, k1] = max2;
//                mas[i, k2] = max1;
//                mas[i, k3] = max4;
//                mas[i, k4] = max3;
//                mas[i, k5] = max6;
//                mas[i, k6] = max5;
//            }


//        }
        
//        static int[,] Rand(int n, int m, int min, int max)
//        {
//            Random random = new Random();

//            int[,] mas = new int[n, m];
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < m; j++)
//                {
//                    mas[i, j] = random.Next(min, max);
//                }
//            }
//            return mas;
//        }
//        static double[,] RandDouble(int n, int m, int min, int max)
//        {
//            Random random = new Random();

//            double[,] mas = new double[n, m];
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < m; j++)
//                {
//                    mas[i, j] = random.Next(min, max);
//                }
//            }
//            return mas;
//        }
//        static void Print(int[,] mas)
//        {
//            for (int i = 0; i < mas.GetLength(0); i++)
//            {
//                for (int j = 0; j < mas.GetLength(1); j++)
//                {
//                    Console.Write($"{mas[i, j]} ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//        }
//        static void PrintDouble(double[,] mas)
//        {
//            for (int i = 0; i < mas.GetLength(0); i++)
//            {
//                for (int j = 0; j < mas.GetLength(1); j++)
//                {
//                    Console.Write($"{mas[i, j]} ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//        }
//        static void DeleteColumn(ref int[,] mas, int column)
//        {

//            int[,] mass = new int[mas.GetLength(0), mas.GetLength(1) - 1];


//            for (int i = 0; i < mas.GetLength(0); i++)
//            {
//                int k = 0;
//                for (int j = 0; j < mas.GetLength(1); j++)
//                {
//                    if (j == column)
//                    {
//                        continue;
//                    }
//                    mass[i, k] = mas[i, j];
//                    k++;

//                }
//            }

//            mas = mass;
//        }
//        static void DeleteRow(ref int[,] mas, int row)
//        {

//            int[,] mass = new int[mas.GetLength(0) - 1, mas.GetLength(1)];


//            int k = 0;
//            for (int i = 0; i < mas.GetLength(0); i++)
//            {
//                if (i == row)
//                {
//                    continue;
//                }
//                for (int j = 0; j < mas.GetLength(1); j++)
//                {
//                    mass[k, j] = mas[i, j];
//                }
//                k++;
//            }

//            mas = mass;
//        }
//    }
//}

