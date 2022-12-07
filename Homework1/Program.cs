// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

// Решение:

// Console.WriteLine("Введите первое число ");
// int numberA = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число ");
// int numberB = int.Parse(Console.ReadLine()!);
// int max = numberA;
// int min = numberB;
// if (numberA < numberB)
// {
//     max = numberB;
//     min = numberA;
// }
// Console.Write("Максимальное число ");
// Console.Write(max);


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Решение:

// Console.WriteLine("Введите первое число ");
// int numberA = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число ");
// int numberB = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите третье число ");
// int numberC = int.Parse(Console.ReadLine()!);
// int max = numberA;
// if (numberA < numberB)
// {
//     max = numberB;
// }
// if (numberB < numberC & numberA < numberC)
// {
//     max = numberC;
// }
// Console.Write("Максимальное число:  ");
// Console.Write(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4->да
// - 3->нет
// 7->нет

// Решение:

// Console.WriteLine("Введите число ");
// int numberA = int.Parse(Console.ReadLine()!);
// if (numberA % 2 == 0)
// {
//     Console.WriteLine("число четное ");
// }
// if (numberA % 2 != 0)
// {
//     Console.WriteLine("число является нечетным ");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Решение:

// Console.WriteLine("Введите число от 1");
// int N = int.Parse(Console.ReadLine()!);
// int i = 2;
// while (N >= i)
// {
//     Console.Write(i + ",");
//     i = i + 2;
// }

