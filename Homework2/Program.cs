// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//Решение:

//int num = new Random().Next(100, 999); (Если лень вводить)
// Console.WriteLine("Введите трехзначное число ");
// int num = int.Parse(Console.ReadLine()!);
// if (num < 100 || num > 999)
// {
//     Console.WriteLine("Вы ввели число не соответствующее условию");
//     return;
// }
// int num2 = (num / 10) % 10;
// Console.WriteLine(num2);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//Решение:

// Console.WriteLine("Введите любо число");
// int num = int.Parse(Console.ReadLine()!);
// int index = 0;
// if (num < 100)
// {
//     Console.WriteLine("третьей цифры нет");
// }
// while (num > 999)
// {
//     num = num / 10;
//     index = index + 1;
//     if (num < 999)
//     {
//         num = num % 10;
//     }
// }
// Console.WriteLine(num);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// //Решение:


// Console.Write("Введите число от 1 до 7: ");
// int numberDay = int.Parse(Console.ReadLine()!);
// if (numberDay < 1 || numberDay > 7)
// {
//     Console.WriteLine("Введено не корректное число");
// }
// if (numberDay == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// if (numberDay == 2)
// {
//     Console.WriteLine("Вторник");
// }
// if (numberDay == 3)
// {
//     Console.WriteLine("Среда");
// }
// if (numberDay == 4)
// {
//     Console.WriteLine("Четверг");
// }
// if (numberDay == 5)
// {
//     Console.WriteLine("Пятница");
// }
// if (numberDay == 6)
// {
//     Console.WriteLine("Суббота");
// }
// if (numberDay == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// if (numberDay < 6 & numberDay > 1)
// {
//     Console.Write("не является выходным, т.к. является будничным днем");
// }
// if (numberDay == 6 || numberDay == 7)
// {
//     Console.Write("ура!!! выходной");
// }
