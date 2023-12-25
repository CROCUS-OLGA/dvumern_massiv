// // Задача 1: Напишите программу, которая на вход
// // принимает позиции элемента в двумерном массиве, и
// // возвращает значение этого элемента или же указание,
// // что такого элемента нет.
// // 4 3 1 (1,2) => 9
// // 2 6 9

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(0, 10);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t");
//         Console.WriteLine();
//     }
// }

// void PoiskChisla(int x, int y, int[,] matrix)
// {
//     if (x < matrix.GetLength(0) && y < matrix.GetLength(1))
//     {
//         int i = x; int j = y;
//         Console.WriteLine(matrix[i, j]);
//     }
//     else
//     {
//         Console.WriteLine("Такого элемента нет!");
//     }
// }

// Console.Clear();
// Console.WriteLine("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // [2, 5]
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// Console.Write("Введите x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// PoiskChisla(x, y, matrix);
// --------------------------------------------------------------------
// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива
// 4 3 1 => 4 6 2
// 2 6 9    2 6 9
// 4 6 2    4 3 1

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Создаем двумерный массив и инициализируем случайными значениями
//         int[,] array = InitializeArray(3, 3);

//         Console.WriteLine("Исходный массив:");
//         PrintArray(array);

//         // Меняем местами первую и последнюю строку
//         SwapFirstAndLastRow(array);

//         Console.WriteLine("\nМассив после замены:");
//         PrintArray(array);
//     }

//     static int[,] InitializeArray(int rows, int cols)
//     {
//         int[,] array = new int[rows, cols];
//         Random random = new Random();

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 array[i, j] = random.Next(1, 10); // Задаем диапазон случайных чисел от 1 до 10
//             }
//         }

//         return array;
//     }

//     static void SwapFirstAndLastRow(int[,] array)
//     {
//         int rowCount = array.GetLength(0);
//         int colCount = array.GetLength(1);

//         // Проверяем, что в массиве есть хотя бы две строки
//         if (rowCount < 2)
//         {
//             Console.WriteLine("Невозможно выполнить обмен: в массиве меньше двух строк.");
//             return;
//         }

//         // Меняем местами первую и последнюю строки
//         for (int i = 0; i < colCount; i++)
//         {
//             int temp = array[0, i];
//             array[0, i] = array[rowCount - 1, i];
//             array[rowCount - 1, i] = temp;
//         }
//     }

//     static void PrintArray(int[,] array)
//     {
//         int rowCount = array.GetLength(0);
//         int colCount = array.GetLength(1);

//         for (int i = 0; i < rowCount; i++)
//         {
//             for (int j = 0; j < colCount; j++)
//             {
//                 Console.Write(array[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }



// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2

// using System;

// class Program
// {
//     static void Main
    
//         int[,] array = InitializeArray(4, 5);

//         Console.WriteLine("Исходный массив:");
//         PrintArray(array);

//                 int minSumRowIndex = FindRowWithMinSum(array);

//         Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRowIndex + 1}"); // +1, так как индексы начинаются с 0
//     }

//     static int[,] InitializeArray(int rows, int cols)
//     {
//         int[,] array = new int[rows, cols];
//         Random random = new Random();

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 array[i, j] = random.Next(1, 10); // Задаем диапазон случайных чисел от 1 до 10
//             }
//         }

//         return array;
//     }

//     static int FindRowWithMinSum(int[,] array)
//     {
//         int rowCount = array.GetLength(0);
//         int colCount = array.GetLength(1);

        
//         if (rowCount < 1)
//         {
//             Console.WriteLine("Массив не содержит строк.");
//             return -1; // Возвращаем -1, чтобы обозначить ошибку
//         }

//         int minSum = int.MaxValue;
//         int minSumRowIndex = -1;

//         for (int i = 0; i < rowCount; i++)
//         {
//             int currentSum = 0;

//             for (int j = 0; j < colCount; j++)
//             {
//                 currentSum += array[i, j];
//             }

//             if (currentSum < minSum)
//             {
//                 minSum = currentSum;
//                 minSumRowIndex = i;
//             }
//         }

//         return minSumRowIndex;
//     }

//     static void PrintArray(int[,] array)
//     {
//         int rowCount = array.GetLength(0);
//         int colCount = array.GetLength(1);

//         for (int i = 0; i < rowCount; i++)
//         {
//             for (int j = 0; j < colCount; j++)
//             {
//                 Console.Write(array[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }
//
//------------------------------------------------------------------------