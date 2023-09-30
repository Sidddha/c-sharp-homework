// //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// using System;
// using System.Runtime.ExceptionServices;

// int value1 = 0, value2 = 0;

// First: Console.WriteLine("Введите первое число.");
// string? a = Console.ReadLine();

// try
// {
//     value1 = Convert.ToInt32(a);
// }
// catch (FormatException)
// {
//     Console.WriteLine("Некорректный ввод. Введите целое число.");
//     goto First;
// }
// catch (OverflowException)
// {
//     Console.WriteLine("Введенное число выходит из диапазона значений Int32");
//     goto First;    
// }

// Second: Console.WriteLine("Введите второе число.");
// string? b = Console.ReadLine();

// try
// {
//     value2 = Convert.ToInt32(b);
// }
// catch (FormatException)
// {
//     Console.WriteLine("Некорректный ввод. Введите целое число.");
//     goto Second;
// }
// catch (OverflowException)
// {
//     Console.WriteLine("Введенное число выходит из диапазона значений Int32.");
//     goto Second;
// }


// if(value1 < value2)
// {
//     Console.WriteLine($"{value1} < {value2}");
// } else if(value1 > value2)
// {
//     Console.WriteLine($"{value1} > {value2}");
// } else {
//     Console.WriteLine($"{value1} = {value2}");
// }

// //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// using System;
// using System.Runtime.ExceptionServices;

// int[] values = new int[3];

// for(int i = 0; i < values.Length; i++)
// {
//     First: Console.WriteLine($"Введите число № {i+1}.");
//     string? input = Console.ReadLine();

//     try
//     {
//         values[i] = Convert.ToInt32(input);
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Некорректный ввод. Введите целое число.");
//         goto First;
//     }
//     catch (OverflowException)
//     {
//         Console.WriteLine("Введенное число выходит из диапазона значений Int32");
//         goto First;    
//     }
// }

// int max = values.Max();
// Console.WriteLine($"Максимальное число {max}");

// //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// int value = 0;
// First: Console.WriteLine("Введите число.");
// string? input = Console.ReadLine();

// try
// {
//     value = Convert.ToInt32(input);
// }
// catch (FormatException)
// {
//     Console.WriteLine("Некорректный ввод. Введите целое число.");
//     goto First;
// }
// catch (OverflowException)
// {
//     Console.WriteLine("Введенное число выходит из диапазона значений Int32");
//     goto First;    
// }

// if((value % 2) == 0)
// {
//     Console.WriteLine("Четное.");
// } else {
//     Console.WriteLine("Нечетное.");
// }

// //Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// using System;
// using System.Runtime.ExceptionServices;

// int value = 0;

// First: Console.WriteLine("Введите число.");
// string? input = Console.ReadLine();

// try
// {
//     value = Convert.ToInt32(input);
// }
// catch (FormatException)
// {
//     Console.WriteLine("Некорректный ввод. Введите целое число.");
//     goto First;
// }
// catch (OverflowException)
// {
//     Console.WriteLine("Введенное число выходит из диапазона значений Int32");
//     goto First;    
// }

// if(value > 1)
// {
//     int[] evens = new int[value / 2];
//     int j = 2;
//     for(int i = 0; i < value / 2; i++)
//     {
//         evens[i] = j;
//         j += 2;
//     }

//     for(int i = 0; i < evens.Length; i++)
//     {
//         Console.WriteLine(evens[i]);
//     }
// } else {
//     Console.WriteLine("Нет четных чисел.");
// }


// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// using System;
// using System.Runtime.ExceptionServices;

// int value = 0;

// First: Console.WriteLine("Введите трехзначное число.");
// string? input = Console.ReadLine();

// try
// {
//     value = Convert.ToInt32(input);
// }
// catch (FormatException)
// {
//     Console.WriteLine("Некорректный ввод. Введите целое число.");
//     goto First;
// }
// catch (OverflowException)
// {
//     Console.WriteLine("Введенное число выходит из диапазона значений Int32");
//     goto First;    
// }

// value = (value/10)%10;
// Console.WriteLine(value);

// //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// using System;
// using System.Runtime.ExceptionServices;

// int value = 0;

// First: Console.WriteLine("Введите трехзначное число.");
// string? input = Console.ReadLine();

// try
// {
//     value = Convert.ToInt32(input);
// }
// catch (FormatException)
// {
//     Console.WriteLine("Некорректный ввод. Введите целое число.");
//     goto First;
// }
// catch (OverflowException)
// {
//     Console.WriteLine("Введенное число выходит из диапазона значений Int32");
//     goto First;    
// }

// if(value < 100)
// {
//     Console.WriteLine("Это двухзначное число.");
// } else 
// {
//     value = (value % 100) % 10;
//     Console.WriteLine(value);
// }

// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// using System;
// using System.Runtime.ExceptionServices;

// int value = 0;

// First: Console.WriteLine("Введите цифру от 1 до 7.");
// string? input = Console.ReadLine();

// try
// {
//     value = Convert.ToInt32(input);
// }
// catch (FormatException)
// {
//     Console.WriteLine("Некорректный ввод. Введите целое число.");
//     goto First;
// }
// catch (OverflowException)
// {
//     Console.WriteLine("Введенное число выходит из диапазона значений Int32");
//     goto First;    
// }
// if(value < 1 || value > 7)
// {
//     Console.WriteLine("Некорректный ввод. Введите число от 1 до 7.");
//     goto First;
// }
// if(value == 6 || value == 7)
// {
//     Console.WriteLine("Выходной.");
// } else 
// {
//     Console.WriteLine("Рабочий.");
// }
// using System.Drawing;
// using System.Net;
// using System.Windows;
// int[] arrayOfInts = new int[5];
//         for(int i = 0, j = arrayOfInts.Length - 1; i < arrayOfInts.Length / 2; i++, j--)
//         {
//           if(arrayOfInts[i] == arrayOfInts[j]) continue;
//           else
//           {
//             return False;
//           }
//         }
//         return 1;

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// using System;
// using System.Runtime.ExceptionServices;

// double value = 0;
// double power = 0;

// for(int i = 0; i <= 1; i++)
// {
//     First: if(i == 0) 
//     {
//         Console.WriteLine("Введите число.");
//         string? input = Console.ReadLine();
//         try
//         {
//             value = Convert.ToDouble(input);
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Некорректный ввод. Введите целое число.");
//             goto First;
//         }
//         catch (OverflowException)
//         {
//             Console.WriteLine("Введенное число выходит из диапазона значений Int32");
//             goto First;    
//         }
//     } else {
//         Console.WriteLine("Введите степень.");
//         string? input = Console.ReadLine();
//         try
//         {
//             power = Convert.ToDouble(input);
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Некорректный ввод. Введите целое число.");
//             goto First;
//         }
//         catch (OverflowException)
//         {
//             Console.WriteLine("Введенное число выходит из диапазона значений Int32");
//             goto First;    
//         }        
//     }
// }

// double result = Math.Pow(value, power);
// Console.WriteLine(result);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// using System;
// using System.Runtime.ExceptionServices;

// int value = 0;

// First: Console.WriteLine("Введите число.");
// string? input = Console.ReadLine();

// try
// {
//     value = Convert.ToInt32(input);
// }
// catch (FormatException)
// {
//     Console.WriteLine("Некорректный ввод. Введите целое число.");
//     goto First;
// }
// catch (OverflowException)
// {
//     Console.WriteLine("Введенное число выходит из диапазона значений Int32");
//     goto First;    
// }

// int result = 0;
// if((value / 10) == 0)
// {
//     Console.WriteLine(value);
// } else {
//     while((value / 10) > 0)
//     {
//         result += value % 10;
//         value = value / 10;
//     }
//     result += value;
// }

// Console.WriteLine(result);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
Random random = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = random.Next();
}
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}