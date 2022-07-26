// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int start, int end)
// // M - start, end - N
// {
//     // Базовый случай
//     if (start == end) return end;
//     // Рекурсивный случай
//     return (start + SumNumbers(start + 1, end));
// }

// System.Console.WriteLine(SumNumbers(M, N));

///////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int AkkermanFunction(int m, int n)
// {
//     if (m == 0) return (n + 1);
//     if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
//     if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
//     return AkkermanFunction(m,n);
// }
// System.Console.WriteLine(AkkermanFunction(m, n));