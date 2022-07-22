// РЕШЕНО! Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int rows = 3;
// int columns = 3;
// int[,] matrix = new int[rows, columns];

// // заполнение массива
// void FillArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(10);
//         }
//     }
// }

// // печать массива
// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// // упорядочивание строк массива
// void SelectionSort(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             int minPosition = j;
//             for (int k = j + 1; k < matrix.GetLength(1); k++)
//             {
//                 if (matrix[i, k] > matrix[i, minPosition]) minPosition = k;
//             }
//             int temp = matrix[i, j];
//             matrix[i, j] = matrix[i, minPosition];
//             matrix[i, minPosition] = temp;
//         }
//     }
// }

// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// SelectionSort(matrix);
// PrintArray(matrix);


//////////////////////////////////////////////////////////////////////////////////////////////////////////

// РЕШЕНО! Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с нименьшей суммой элементов.

// int[,] matrix = {   { 5 , 9 , 8 , 7 },
//                     { 1 , 2 , 2 , 3 },
//                     { 8 , 4 , 2 , 4 } };
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// int minSum = int.MaxValue; //Значение минимальной суммы
// int minIndexRows = 0;      //Задание индекса строчки минимальной суммы элементов
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     int summ = 0;

//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         summ += matrix[i, j];
//     }
//     Console.WriteLine($"Сумма элементов строки {i + 1} равно {summ}");
//     if (minSum > summ)
//     {
//         minSum = summ;
//         minIndexRows = i;
//     }
// }
// Console.WriteLine($"Строка с минимальной суммой элементов: { minIndexRows + 1}");

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// int rows = 3;
// int columns = 3;
// int[,] matrixFirst = new int[rows, columns];
// int[,] matrixSecond = new int[rows, columns];
// int[,] matrixResult = new int[rows, columns];
// Console.WriteLine("Матрица №1:");
// for (int i = 0; i < matrixFirst.GetLength(0); i++)
// {
//     for (int j = 0; j < matrixFirst.GetLength(1); j++)
//     {
//         matrixFirst[i, j] = new Random().Next(10);
//         Console.Write(matrixFirst[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// Console.WriteLine("Матрица №2:");
// for (int i = 0; i < matrixSecond.GetLength(0); i++)
// {
//     for (int j = 0; j < matrixSecond.GetLength(1); j++)
//     {
//         matrixSecond[i, j] = new Random().Next(10);
//         Console.Write(matrixSecond[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// Console.WriteLine("Матрица ИТОГОВАЯ (произведение матриц):");
// for (int i = 0; i < matrixResult.GetLength(0); i++)
// {
//     for (int j = 0; j < matrixResult.GetLength(1); j++)
//     {
//         matrixResult[i, j] = matrixFirst[i, j] * matrixSecond[i, j];
//         Console.Write(matrixResult[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// РЕШЕНО! Задача 60: Сформируйте трехмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.


// int[,,] matrix = new int[2, 2, 2];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         for (int k = 0; k < matrix.GetLength(2); k++)
//         {
//             matrix[i, j, k] = new Random().Next(10, 100);
//             Console.Write($"{matrix[i, j, k]} {(i, j, k)} ");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 62: Заполните спирально массив 4 на 4. 
