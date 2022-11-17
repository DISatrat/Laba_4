//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Laba_4
//{
//    class Program
//    {
//        //начало 4!!
//        static void Main(string[] args)
//        {
//            N32();

//            Console.ReadLine();
//        }
//        public static void N4()
//        {
//            int[,] mas = new int[6, 3] { {1,2,3},
//                                        {4,5,6},
//                                        {7,8,9},
//                                        {1,-5,3},
//                                        {4,5,6},
//                                        {7,8,9} };

//            for (int i = 0; i < 6; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {

//                    Console.Write($"{mas[i, j]} ");

//                }
//                Console.WriteLine();
//            }

//            int min = mas[0, 0];
//            int n = 0;
//            int m = 0;
//            for (int i = 0; i < mas.GetLength(0); i++)
//            {
//                for (int j = 0; j < mas.GetLength(1); j++)
//                {
//                    if (mas[i, j] < min)
//                    {
//                        min = mas[i, j];
//                        n = i;
//                        m = j;
//                    }
//                }
//            }
//            Console.WriteLine();
//            Console.WriteLine(min + " " + n + " " + m);
//            Console.ReadLine();
//        }

//        public static void N8()
//        {
//            double[,] mas = new double[6, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 }, { 18, 19, 20, 21 }, { 22, 23, 24, 25 } };


//            double sum = 0;
//            for (int i = 0; i < mas.GetLength(0); i++)
//            {
//                for (int j = 0; j < mas.GetLength(1); j++)
//                {
//                    sum += mas[i, j];
//                }
//            }
//            double sred = sum / mas.Length;
//            for (int i = 0; i < mas.GetLength(0); i++)
//            {
//                for (int j = 0; j < mas.GetLength(1); j++)
//                {
//                    mas[i, j] = sred;
//                }
//            }
//            for (int i = 0; i < mas.GetLength(0); i++)
//            {
//                for (int j = 0; j < mas.GetLength(1); j++)
//                {
//                    Console.Write($"{mas[i, j]:f2} ");
//                }
//                Console.WriteLine();
//            }
//        }
//        public static void N12()
//        {
//            int[,] mas = new int[7, 6] {    {1,2,3,4,5,6},
//                                            { 1,2,3,40,5,6},
//                                            { 1,2,3,4,5,6},
//                                            { 1,2,3,4,5,6},
//                                            { 1,2,3,4,5,6},
//                                            { 1,2,3,4,5,6},
//                                            { 1,2,3,4,5,6} };

//            Print(mas);

//            int max = mas[0, 0];
//            int n = 0;
//            int m = 0;
//            for (int i = 0; i < mas.GetLength(0); i++)
//            {
//                for (int j = 0; j < mas.GetLength(1); j++)
//                {
//                    if (mas[i, j] > max)
//                    {
//                        max = mas[i, j];
//                        n = i;
//                        m = j;
//                    }
//                }
//            }

//            DeleteColumn(ref mas, m);
//            DeleteRow(ref mas, n);
//            Print(mas);

//        }
//        public static void N16()
//        {
//            int[,] mas = Rand(5, 5, 0, 11);
//            int k = 0;
//            Print(mas);
//            int c = 0;
//            for (int i = 0; i < mas.GetLength(0); i++)
//            {
//                int max = mas[0, 0];
//                for (int j = 0; j < mas.GetLength(1); j++)
//                {
//                    if (mas[i, j] > max)
//                    {
//                        max = mas[i, j];
//                        k = j;

//                    }
//                }
//                c = mas[i, mas.GetLength(1) - 1];
//                mas[i, mas.GetLength(1) - 1] = max;
//                mas[i, k] = c;
//            }




//            Print(mas);

//        }
//        public static void N20()
//        {
//            double[,] mas = RandDouble(5, 5, -10, 11);
//            PrintDouble(mas);
//            for (int i = 0; i < mas.GetLength(0); i++)
//            {
//                double polSum = 0;
//                bool t = false;
//                int k = 0;
//                double min2 = 0;
//                double min1 = 0;
//                double max = mas[i, 0];
//                for (int j = 0; j < mas.GetLength(1); j++)
//                {
//                    if (mas[i, j] > max)
//                    {
//                        max = mas[i, j];
//                        k = j;
//                    }
//                    if (mas[i, j] < 0 && !t)
//                    {
//                        min1 = mas[i, j];
//                        t = true;
//                    }
//                    if (mas[i, j] < 0)
//                    {
//                        min2 = mas[i, j];
//                    }
//                }
//                polSum = (min1 + min2) / 2;
//                mas[i, k] = polSum;
//            }
//            PrintDouble(mas);
//        }

//        public static void N24()
//        {
//            double[,] mas = RandDouble(5, 6, -10, 11);
//            PrintDouble(mas);

//            for (int i = 0; i < mas.GetLength(0); i++)
//            {
//                double max = mas[i, 0];
//                double sred = 0;
//                int cMax = 0;
//                int k = 0;
//                double sum = 0;
//                for (int j = 0; j < mas.GetLength(1); j++)
//                {
//                    if (mas[i, j] > max)
//                    {
//                        max = mas[i, j];
//                        k = j;
//                    }

//                }
//                for (int f = k + 1; f < mas.GetLength(1); f++)
//                {
//                    if (mas[i, f] >= 0)
//                    {

//                        cMax++;
//                        sum += mas[i, f];
//                    }
//                    sred = sum / cMax;


//                }
//                for (int t = 0; t < k; t++)
//                {

//                    if (mas[i, t] < 0)
//                    {
//                        if (cMax == 0)
//                        {
//                            mas[i, t] = 0;
//                        }
//                        else
//                        {

//                            mas[i, t] = sred;
//                        }
//                    }
//                }
//            }
//            PrintDouble(mas);
//        }

//        public static void N28()
//        {
//            int max = 0;
//            int n = 0;
//            int k = 0;
//            int n1 = 0;
//            int[,] mas = Rand(5, 7, -10, 11);
//            Print(mas);
//            for (int i = 0; i < mas.GetLength(0); i++)
//            {
//                int sum = 0;
//                for (int j = 0; j < mas.GetLength(1); j++)
//                {
//                    sum += mas[i, j];

//                    n1 = i;
//                }
//                if (sum > max)
//                {
//                    max = sum;
//                    n = n1;
//                }
                
//            }
//                DeleteRow(ref mas, n);
//                Print(mas);
//        }

//        public static void N32()
//        {
//            double[,] mas = RandDouble(7, 5, -10, 11);
//            PrintDouble(mas);

//            for (int i = 0; i < mas.GetLength(0); i++)
//            {
//                double sred = 0;
//                double max = -10000;
//                double sum = 0;
//                int k = 0;
//                int c = 0;
//                for (int j = 0; j < mas.GetLength(1); j++)
//                {
//                    if (mas[i, j] > max)
//                    {
//                        max = mas[i, j];
//                        k = j;
//                    }
//                    if (mas[i, j] >= 0)
//                    {
//                        sum += mas[i, j];
//                        c++;
//                    }
//                    sred = sum / c;
//                }
//                mas[i, k] = sred;
//            }
//            PrintDouble(mas);
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

