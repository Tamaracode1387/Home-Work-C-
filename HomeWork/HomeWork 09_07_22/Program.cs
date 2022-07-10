// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] array = new int[6];
// int sumEvenNumbers = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
// }
// Console.WriteLine($"[{String.Join(", ", array)}]");

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         sumEvenNumbers += 1;
//     }
//     else
//     {
//         sumEvenNumbers += 0;
//     }
// }
// Console.WriteLine($"Количество четных чисел в массиве: {sumEvenNumbers}");

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[8];
// int sumElements = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10, 10);
// }
// Console.WriteLine($"[{String.Join(", ", array)}]");

// for (int i = 1; i < array.Length; i += 2)
// {
//     sumElements += array[i];
// }
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumElements}");

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int[] array = new int[] { 1, 23, 3, 6, 55, 5, 12, 6, 42, 9 };
// int maxElement = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > maxElement)
//     {
//         maxElement = array[i];
//     }
// }
// Console.WriteLine($"Максимальный элемент массива: {maxElement}");
// int minElement = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < minElement)
//     {
//         minElement = array[i];
//     }
// }
// Console.WriteLine($"Минимальный элемент массива: {minElement}");
// Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {maxElement-minElement}");


