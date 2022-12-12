// Оформляем задачи в методы(функции)
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

// Console.WriteLine("Введите число A ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число B ");
// int B = int.Parse(Console.ReadLine()!);
// Exponentiation(A, B);
// void Exponentiation(int A, int B)
// {
//     int i = 1;
//     int result = 1;
//     while (i <= B) // for (int i = 1; i <= B; i++)
//     {
//         result = result * A;
//         i++;
//     }
//     Console.WriteLine(result);
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// int SumNumber(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum = num % 10 + sum;
//         num = num / 10;
//     }
//     return sum;
// }
// Console.WriteLine(SumNumber(num));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

// Console.WriteLine("Введите количество элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// int[] CreateArr(int[] number)
// {
//     for (int i = 0; i < number.Length; i++)
//     {
//         number[i] = new Random().Next(0, 100); // можно задать 1, 2, 5, 7, 19 как по условию задачи
//         Console.Write($"{number[i]}, ");
//     }
//     return number;
// }
// CreateArr(array);
