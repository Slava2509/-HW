// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] GetArray(int size)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(100, 999 + 1);
//     }
//     return res;
// }
// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }
// int[] array = GetArray(4);
// PrintArray(array);
// Console.WriteLine();
// int EvNumbers(int[] array)
// {
//     int eventNumbers = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             eventNumbers = eventNumbers + 1;
//         }
//     }
//     return eventNumbers;
// }
// Console.WriteLine(EvNumbers(array));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }
// int[] array = GetArray(4, 10, 100);
// PrintArray(array);
// Console.WriteLine();
// int SumOddEl(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i = i + 2)
//     {
//         sum = sum + array[i];
//     }
//     return sum;
// }
// Console.WriteLine(SumOddEl(array));

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] GetArray(int size, double minValue, double maxValue)
// {
//     double[] res = new double[size];
//     for (int i = 0; i < size; i++)
//     {

//         Random rand = new Random();
//         double number = rand.NextDouble() * (maxValue - minValue) + minValue;
//         res[i] = number;
//     }
//     return res;
// }
// void PrintArray(double[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }
// Console.WriteLine("Задайте длину массива ");
// int size = int.Parse(Console.ReadLine()!);
// double[] array = GetArray(size, 10, 100);
// PrintArray(array);
// Console.WriteLine();

// double maxValue = array[0];
// double minValue = array[1];
// for (int i = 0; i < array.Length; i++)
// {
//     if (maxValue < array[i])
//     {
//         maxValue = array[i];
//     }
//     if (minValue > array[i])
//     {
//         minValue = array[i];
//     }
// }
// double result = maxValue - minValue;
// Console.WriteLine($"разница между максимальным ({maxValue}) и минимальным ({minValue}) элементами массива = {result}");

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21
