using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task 1
            //Random rnd = new Random();
            //int[] arr = new int[10]; 
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(0, 5); 
            //}

            //List<int> arr2 = new List<int>(); 
            //int count = 0, check = 0;

            //Console.Write("arr 1: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == 0)
            //    {
            //        count++; 
            //    }
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();


            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    if (arr[i] == 0)
            //    {
            //        check++;
            //    }
            //    else
            //    {
            //        arr2.Add(arr[i]);
            //    }
            //}
            //for(int i = 0; i < count; i++)
            //{
            //    arr2.Add(-1);
            //}

            //Console.Write("arr 2: ");
            //foreach (int num in arr2) 
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            #endregion

            #region Task 2
            //Console.Write("Введите размер матрицы N (нечётное число): ");
            //int N = int.Parse(Console.ReadLine());

            //if (N % 2 == 0)
            //{
            //    Console.WriteLine("Введите нечётное число.");
            //    return;
            //}

            //int[,] matrix = new int[N, N];

            //int x = N / 2; // h center
            //int y = N / 2; // v center

            //matrix[x, y] = 1; //  1

            //int value = 2; // next
            //int step = 1; 

            //while (value <= N * N)
            //{
            //    for (int i = 0; i < step && value <= N * N; i++)
            //    {
            //        x--;
            //        matrix[x, y] = value++;
            //    }

            //    for (int i = 0; i < step && value <= N * N; i++)
            //    {
            //        y--;
            //        matrix[x, y] = value++;
            //    }

            //    step++; 

            //    for (int i = 0; i < step && value <= N * N; i++)
            //    {
            //        x++;
            //        matrix[x, y] = value++;
            //    }

            //    for (int i = 0; i < step && value <= N * N; i++)
            //    {
            //        y++;
            //        matrix[x, y] = value++;
            //    }

            //    step++;
            //}

            //Console.WriteLine("Result:");
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        Console.Write(matrix[i, j].ToString().PadLeft(4)); 
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Task 3

            Random rnd = new Random();

            Console.Write("Введите количество строк N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов M: ");
            int M = int.Parse(Console.ReadLine());

            int[,] array = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    array[i, j] = rnd.Next(0, 101);
                }
            }

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            Console.Write("Введите направление сдвига (l/r): ");
            string direction = Console.ReadLine();
            Console.Write("Введите количество столбцов для сдвига: ");
            int shift = int.Parse(Console.ReadLine());

            ShiftArray(array, direction, shift);

            Console.WriteLine("Массив после циклического сдвига:");
            PrintArray(array);
        }

        static void ShiftArray(int[,] array, string direction, int shift)
        {
            int N = array.GetLength(0);
            int M = array.GetLength(1);

            shift %= M;

            if (shift < 0) 
            {
                shift += M;
            }

            for (int i = 0; i < N; i++)
            {
                if (direction == "r")
                {
                    for (int j = M - 1; j >= shift; j--)
                    {
                        array[i, j] = array[i, j - shift];
                    }

                    for (int j = 0; j < shift; j++)
                    {
                        array[i, j] = 0;
                    }
                }
                else if (direction == "l")
                {
                    for (int j = 0; j < M - shift; j++)
                    {
                        array[i, j] = array[i, j + shift];
                    }
                
                    for (int j = M - shift; j < M; j++)
                    {
                        array[i, j] = 0; 
                    }
                }
                else
                {
                    Console.WriteLine("Неверное направление");
                    return;
                }
            }
        }

        static void PrintArray(int[,] array)
        {
            int N = array.GetLength(0);
            int M = array.GetLength(1);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(4)); 
                }
                Console.WriteLine();
            }

        #endregion
    }
    }
}
