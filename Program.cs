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

Console.Write("Введите количество строк M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[M,N];

void Array(int M, int N)
{
int i,j;
Random rand = new Random();
for (i = 0; i < M; i++)
{
for (j = 0; j < N; j++)
{
    arr[i,j] = rand.Next(1,5);
}
}
}

void PrintArray(int[,] array)
{
int i,j;
for (i = 0; i < array.GetLength(0); i++)
{
for (j = 0; j < array.GetLength(1); j++)
{
    Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}
}

Array(M,N);
PrintArray(arr);

// Функция, считающая сумму элементов в строке
int SumLine(int[,] array, int i)
{
int Array = array[i,0];
for (int j = 1; j < array.GetLength(1); j++)
{
    Array += array[i,j];
}
return Array;
}

int minSum = 1;
int sum = SumLine(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
if (sum > SumLine(arr, i))
{
    sum = SumLine(arr, i);
    minSum = i+1;
}
}
Console.WriteLine(minSum);