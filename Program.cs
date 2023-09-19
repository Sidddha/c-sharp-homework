//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using System;
using System.Runtime.ExceptionServices;

int value1 = 0, value2 = 0;

First: Console.WriteLine("Введите первое число.");
string? a = Console.ReadLine();

try
{
    value1 = Convert.ToInt32(a);
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

Second: Console.WriteLine("Введите второе число.");
string? b = Console.ReadLine();

try
{
    value2 = Convert.ToInt32(b);
}
catch (FormatException)
{
    Console.WriteLine("Некорректный ввод. Введите целое число.");
    goto Second;
}
catch (OverflowException)
{
    Console.WriteLine("Введенное число выходит из диапазона значений Int32.");
    goto Second;
}


if(value1 < value2)
{
    Console.WriteLine($"{value1} < {value2}");
} else if(value1 > value2)
{
    Console.WriteLine($"{value1} > {value2}");
} else {
    Console.WriteLine($"{value1} = {value2}");
}