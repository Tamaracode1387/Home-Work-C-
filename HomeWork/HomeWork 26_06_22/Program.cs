// Задача 10: Напишите программу, которая принимает на 
// вход трёхзначное число и на выходе показывает вторую 
// цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);

// int SearchNumber(int number)
// {
//     return number / 10 - number/100*10;
// }
// Console.WriteLine(SearchNumber(number));

///////////////////////////////////////////////////////////////////////

// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей 
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Способ 1
// int number = new Random().Next();
// Console.WriteLine(number);
//  if (number>99)
// {
//     Console.WriteLine(number.ToString()[2]);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }
        
// Способ 2 (не получился...:()
// string Number = Console.ReadLine();
// int count = Number.Length;
// if (count>2)
// {
//     Console.WriteLine(Number[2]);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

///////////////////////////////////////////////////////////////////////////////

// Задача 15: Напишите программу, которая принимает на 
// вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

// int number = new Random().Next(1, 8);
// Console.WriteLine(number);
// if (number==6 || number==7)
// {
//     Console.Write("Выходной");
// }
// else
// {
//     Console.Write("Будний день");
// }
