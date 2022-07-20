// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// 1 способ:
// int rows = 3;
// int columns = 4;
// double[,] matrix = new double[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = Math.Round((new Random().NextDouble() * 10), 1);
//         // [0;11) -> [0;10]
//         Console.Write(matrix[i, j] + "\t"); // Литералы
//     }
//     Console.WriteLine();
// }

// 2 способ (отрицательные и положительные числа):
// int rows = 3;
// int columns = 4;
// double[,] matrix = new double[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = (new Random().Next(-10,10)) * 0.01;
//         Console.Write(matrix[i, j] + "\t"); // Литералы
//     }
//     Console.WriteLine();
// }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7->такого числа в массиве нет

// int rows = 3;
// int columns = 4;
// int[,] matrix = new int[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(10);
//         // [0;11) -> [0;10]
//         Console.Write(matrix[i, j] + "\t"); // Литералы
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите номер строки ");
// int rowsNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца ");
// int columnsNumber = Convert.ToInt32(Console.ReadLine());
// if (rowsNumber < matrix.GetLength(0) && columnsNumber < matrix.GetLength(1))
// {
//     Console.WriteLine(matrix[rowsNumber, columnsNumber]);
// }
// else
// {
//     Console.WriteLine($" {rowsNumber}, {columnsNumber} - такого числа в матрице НЕТ");
// }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

// int[,] matrix = {   { 1 , 4 , 7 , 2 },
//                     { 5 , 9 , 2 , 3 },
//                     { 8 , 4 , 2 , 4 } };

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// for (int i = 0; i < matrix.GetLength(1); i++)
// {
//     double summ = 0;
//     for (int j = 0; j < matrix.GetLength(0); j++)
//     {
//         summ += matrix[j, i];
//     }
//     Console.WriteLine($"Среднее арифмитическое {i + 1} столбца равно {Math.Round((summ / matrix.GetLength(0)), 1)}");
// }








