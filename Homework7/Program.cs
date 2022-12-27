Console.Clear();
// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

// double[,] GetArray(int m, int n, double minValue, double maxValue)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Random rand = new Random();
//             double number = rand.NextDouble() * (maxValue - minValue);
//             result[i, j] = Math.Round(number, 2);
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($" {inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int colums = int.Parse(Console.ReadLine());

// double[,] array = GetArray(rows, colums, -10, 10);
// PrintArray(array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int ReturnElArr(int[,] array)
{
    Console.WriteLine("Введите позицию элемента в строке двумерного массива: ");
    int rowNum = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите позицию элемента в столбце двумерного массива: ");
    int tableNum = int.Parse(Console.ReadLine()!);
    int[,] number = new int[rowNum, tableNum];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (rowNum == i && tableNum == j)
            {
                Console.WriteLine($"Элемент с индексом {rowNum},{tableNum} существует");
                Console.WriteLine($"Значение элемента {array[i, j]}");// выводит значение элемента
                if (rowNum != i || tableNum != j)
                { Console.WriteLine($"Элемент с индексом {rowNum},{tableNum} не существует"); }
            }
            // break;
            // if (rowNum != i || tableNum != j && j >= array.GetLength(1))
            // {
            //     Console.WriteLine($"Элемент с индексом {rowNum},{tableNum} не существует");
            // }

        }
        // незнаю что нужно сделать для того чтобы он при каждом прохождении цикла эта надпись не выходила в консоль, подскажите плз
    }
    return array[rowNum, tableNum];
}
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, colums, -10, 10);
PrintArray(array);
ReturnElArr(array);

// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

// double[] MeanArithmetic(int[,] array)
// {
//     double[] result = new double[array.GetLength(1)];
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i, j];
//         }
//         result[j] = Math.Round(sum / array.GetLength(0), 2);
//     }
//     return result;
// }


// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int colums = int.Parse(Console.ReadLine());
// int[,] array = GetArray(rows, colums, -10, 10);
// PrintArray(array);
// double[] averageColums = MeanArithmetic(array);
// Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ", averageColums)}");
