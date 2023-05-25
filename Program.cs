// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] array = new int[3, 4];
// FillArray(array);
// PrintArray(array);
// Sort(array);
// Console.WriteLine();
// PrintArray(array);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void Sort (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

// Console.Write("Введите количество строк M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[,] arr = new int[M,N];

// void Array(int M, int N)
// {
// int i,j;
// Random rand = new Random();
// for (i = 0; i < M; i++)
// {
// for (j = 0; j < N; j++)
// {
//     arr[i,j] = rand.Next(1,5);
// }
// }
// }

// void PrintArray(int[,] array)
// {
// int i,j;
// for (i = 0; i < array.GetLength(0); i++)
// {
// for (j = 0; j < array.GetLength(1); j++)
// {
//     Console.Write($"{array[i,j]} ");
// }
// Console.WriteLine();
// }
// }

// Array(M,N);
// PrintArray(arr);

// // Функция, считающая сумму элементов в строке
// int SumLine(int[,] array, int i)
// {
// int Array = array[i,0];
// for (int j = 1; j < array.GetLength(1); j++)
// {
//     Array += array[i,j];
// }
// return Array;
// }

// int minSum = 1;
// int sum = SumLine(arr, 0);
// for (int i = 1; i < arr.GetLength(0); i++)
// {
// if (sum > SumLine(arr, i))
// {
//     sum = SumLine(arr, i);
//     minSum = i+1;
// }
// }
// Console.WriteLine(minSum);

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int m = InputNumbers("Число строк 1-й матрицы: ");
// int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
// int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

// int[,] martrix1 = new int[,]{{2,4},
//                              {3,2}};
// PrintArray(martrix1);
// Console.WriteLine("x");

// int[,] martrix2 = new int[,]{{3,4},
//                              {3,3}};
// PrintArray(martrix2);

// int[,] sum_matrix = new int[2,2];

// SumMatrix(martrix1, martrix2, sum_matrix);
// Console.WriteLine("______________________");
// PrintArray(sum_matrix);

// void SumMatrix(int[,] matrix1, int[,] martrix2, int[,] sum_matrix)
// {
//   for (int i = 0; i < sum_matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < sum_matrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < matrix1.GetLength(1); k++)
//       {
//         sum += martrix1[i,k] * martrix2[k,j];
//       }
//       sum_matrix[i,j] = sum;
//     }
//   }
// }

// void PrintArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("Введите размеры массива через пробел: ");
// string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]), }, 10, 99);
// PrintArray(array);

// int[,,] GetArray(int[] sizes, int min, int max)
// {
//     int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             int k = 0;
//             while (k < result.GetLength(2))
//             {
//                 int element = new Random().Next(min, max + 1);
//                 if (FindElement(result, element)) continue;
//                 result[i, j, k] = element;
//                 k++;
//             }
//         }
//     }
//     return result;
// }
// bool FindElement(int[,,] array, int element)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] == element) return true;
//             }
//         }
//     }
//     return false;
// }
// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
//             }
//             Console.WriteLine();

//             Console.ReadKey();
//         }
//     }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int a = 4;
int[,] arr = new int[a, a];
FillArray(arr, a);
PrintArray(arr);

void FillArray(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
  