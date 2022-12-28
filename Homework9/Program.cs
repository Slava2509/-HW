Console.Clear();

// Урок 9.Рекурсия
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


// Console.WriteLine("Введите число N:");
// int n = int.Parse(Console.ReadLine()!);
// int Recurssion(int value, int start)
// {
//     if (value == start)
//     {
//         Console.Write(start);
//         return start;
//     }
//     else
//     {
//         Console.Write($"{start}, ");
//         start += 2;
//         return Recurssion(value, start);
//     }
// }
// Recurssion(n, 2);


// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30


// Console.WriteLine("Введите число N:");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число M:");
// int n = int.Parse(Console.ReadLine());
// void Recurssion(int value, int start, int count)
// {
//     if (value > start)
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от N до M: {count}");
//         return;
//     }
//     count = count + (value++);
//     Recurssion(value, start, count);

// }
// Recurssion(m, n, 0);



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29


// Console.WriteLine("Введите число N:");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число M:");
// int n = int.Parse(Console.ReadLine());

// int Akkerman(int value, int start)
// {
//     if (start == 0) return value + 1;
//     else
//     if (value == 0) return Akkerman(value - 1, 1);
//     return Akkerman(value - 1, Akkerman(value, start - 1));
// }

// int akk = Akkerman(m, n);
// Console.WriteLine(akk);
