// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// int[] array = new int[5];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-999, 1000);
// }
// Console.WriteLine($"Исходные числа: [{String.Join(",", array)}]");
// int sumPositive = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         sumPositive += 1;
//     }
//     else
//     {
//         sumPositive += 0;
//     }
// }
// Console.WriteLine($"Количество положительных чисел: {sumPositive}");

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 43. Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * 
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2
// x = (b2-b1)/(k1-k2) =(4-2)/(5-9)=(-0,5)
// y = k1 * (b2-b1)/(k1-k2) + b1

// Console.Write("Введите число b1 ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число k1 ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число b2 ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число k2 ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// double x = (b2-b1)/(k1-k2);
// double y = k1 * (b2-b1)/(k1-k2) + b1;
// Console.Write($"Точка пересечения прямых: ({x}, {y})");




