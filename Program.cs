// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// using System;
// using System.Runtime.ExceptionServices;


// int userInput()
// {
//     int value = 0;
//     string? input = String.Empty;
// First: Console.WriteLine($"Введите N");
//     input = Console.ReadLine();
//     try
//     {
//         value = Convert.ToInt32(input);
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
//     return value;
// }

// void printNumbers(int n)
// {
//   if (n>=1) Console.Write($"{n} ");
//   if (n == 0) 
//   {
//     Console.WriteLine();
//     return;
//   }
//   printNumbers(n-1);
// }

// int value = userInput();

// printNumbers(value);

//  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using System;
using System.Runtime.ExceptionServices;

int userInput(String num)
{
    int value = 0;
    string? input = String.Empty;
First: Console.WriteLine($"Введите {num}");
    input = Console.ReadLine();
    try
    {
        value = Convert.ToInt32(input);
    }
    catch (FormatException)
    {
        Console.WriteLine("Некорректный ввод. Введите целое число.");
        goto First;
    }
    catch (OverflowException)
    {
        Console.WriteLine("Введенное число выходит из диапазона значений Int32");
        goto First;
    }
    return value;
}

int sumMtoN(int m, int n)
{
  if (m <= n) return sumMtoN(m + 1, n) + m;
  return 0;
}

int m = userInput("M");
int n = userInput("N");

Console.WriteLine(sumMtoN(m, n));