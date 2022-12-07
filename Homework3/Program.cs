// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Решение:

// Console.WriteLine("Введите пятизначное число");
// int number = int.Parse(Console.ReadLine()!);
// int extremeNumber = 0;
// int generateNumber = 0;
// int temp = number;
// while (number > 0)
// {
//     extremeNumber = number % 10;
//     generateNumber = generateNumber * 10 + extremeNumber;
//     number = number / 10;
// }
// if (temp == generateNumber) Console.WriteLine("Да является");

// else
// {
//     Console.WriteLine("Не является");
// }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B(2, 1, -7), -> 15.84

// A(7, -5, 0); B(1, -1, 9)-> 11.53

// Console.Write("Введите координаты x1:");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты y1:");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты z1:");
// int z1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты x2:");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты y2:");
// int y2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты z2:");
// int z2 = int.Parse(Console.ReadLine());
// double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.Write(d);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
//     int result = i * i * i;
//     if (i < n) Console.Write(result + ", ");
//     else
//         Console.Write(result + " ");
// }
//))))


