// Задача 19: Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Console.Write("Введите пятизначное число ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(number);
// if (number>9999 && number<100000)
// {
//     if (number.ToString()[0]==number.ToString()[4] && number.ToString()[1]==number.ToString()[3])
//     {
//         Console.WriteLine("Число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Число НЕ является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Число НЕ пятизначное");
// }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 21: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите число X1 ");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число Y1 ");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число Z1 ");
// int Z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число X2 ");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число Y2 ");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число Z2 ");
// int Z2 = Convert.ToInt32(Console.ReadLine());
// double d = Math.Round(Math.Sqrt(Math.Pow(X1-X2,2)+Math.Pow(Y1-Y2,2)+Math.Pow(Z1-Z2,2)));
// Console.WriteLine("Расстояние между точками равно " + d);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 23: Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 1, 8, 27, 64, 125

// int N = Convert.ToInt32(Console.ReadLine());
// for(int i = 1; i<=N; i++)
// {
//     Console.WriteLine($"Куб числа {i} равен {Math.Pow(i,3)}");
// }

