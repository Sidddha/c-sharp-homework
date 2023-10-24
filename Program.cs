// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

using System;
using System.Runtime.ExceptionServices;


int userInput()
{
    int value = 0;
    string? input = String.Empty;
First: Console.WriteLine($"Введите N");
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

void printNumbers(int n)
{
  if (n>=1) Console.Write($"{n} ");
  if (n == 0) 
  {
    Console.WriteLine();
    return;
  }
  printNumbers(n-1);
}

int value = userInput();

printNumbers(value);