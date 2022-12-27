Console.Clear();

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void SortOrder(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j <= array.GetLength(1); j++)
//         {
//             for (int max = 0; max < array.GetLength(1) - 1; max++)
//             {
//                 if (array[i, max] < array[i, max + 1])
//                 {
//                     int temp = array[i, max + 1];
//                     array[i, max + 1] = array[i, max];
//                     array[i, max] = temp;
//                 }
//             }
//         }
//     }
// }
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int colums = int.Parse(Console.ReadLine());
// int[,] array = GetArray(rows, colums, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// SortOrder(array);
// PrintArray(array);




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int SumLineElements(int[,] array)
// {
//     int sumLineRow = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sumLine = array[i, 0];
//         for (int j = 1; j < array.GetLength(1); j++)
//         {
//             sumLine += array[i, j];
//         }
//         Console.WriteLine(sumLine);
//         sumLine = sumLineRow;
//     }
//     return sumLineRow;

// }

// void MinSumLine(int[,] array, int sumLineRow)
// {
//     int minLine = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (minLine < sumLineRow)
//         {
//             minLine = array[i, 0];
//         }

//     }
//     Console.WriteLine(minLine);
// }

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов массива: ");
// int colums = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, colums, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// int sumLineRow = SumLineElements(array);
// Console.WriteLine();
// MinSumLine(array, sumLineRow);
// // не получается вывести минимальную строку, что не так не пойму(((



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
// {
//     int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(0); j++)
//         {
//             for (int k = 0; k < matrix2.GetLength(1); k++)
//             {
//                 matrix3[i, j] += (matrix1[i, j] * matrix2[i, j]);
//             }
//         }
//     }
//     return matrix3;
// }

// Console.Write("Введите количество строк Матрицы1: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов Матрицы1: ");
// int colums = int.Parse(Console.ReadLine());
// int[,] matrix1 = GetArray(rows, colums, 1, 10);
// int[,] matrix2 = GetArray(rows, colums, 1, 10);
// PrintArray(matrix1);
// Console.WriteLine();
// PrintArray(matrix2);
// Console.WriteLine();
// PrintArray(MultiMatrix(matrix1, matrix2));



// Здесь не уверен что правильный результат выводит





// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)

// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({j},{k},{i})\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }
// void CreateArray(int[,,] array)
// {
//     int[] temp = new int[array.Length];
//     int number;
//     for (int i = 0; i < temp.GetLength(0); i++)
//     {
//         temp[i] = new Random().Next(10, 100);
//         number = temp[i];
//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 while (temp[i] == temp[j])
//                 {
//                     temp[i] = new Random().Next(10, 100);
//                     j = 0;
//                     number = temp[i];
//                 }
//                 number = temp[i];
//             }
//         }
//     }
//     int count = 0;
//     for (int x = 0; x < array.GetLength(0); x++)
//     {
//         for (int y = 0; y < array.GetLength(0); y++)
//         {
//             for (int z = 0; z < array.GetLength(0); z++)
//             {
//                 array[x, y, z] = temp[count];
//                 count++;
//             }
//         }
//     }
// }
// int[,,] array = new int[2, 2, 2];
// CreateArray(array);
// PrintArray(array);


// Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int size = 6;
// int[,] array = new int[size, size];
// SpiralFillArray(array, size);
// PrintArray(array, size);

// void SpiralFillArray(int[,] array, int size)
// {
//     int value = 1; // значение первого элемента [0,0]
//     int i = 0;
//     int j = 0;
//     while (value <= size * size)
//     {
//         array[i, j] = value;
//         if (i <= j + 1 && i + j < size - 1)
//         {
//             ++j;
//         }
//         else if (i < j && i + j >= size - 1)
//         {
//             ++i;
//         }
//         else if (i >= j && i + j > size - 1)
//         {
//             --j;
//         }
//         else
//         {
//             --i;
//             ++value;
//         }
//     }
// }

// void PrintArray(int[,] array, int size)
// {
//     Console.WriteLine($"Массив, имеющий размер {size} x {size}, заполнен по спирали");
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10)
//             {
//                 Console.Write("0" + array[i, j]);
//                 Console.Write(" ");
//             }
//             else Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
