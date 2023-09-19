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

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using System;
using System.Runtime.ExceptionServices;

int[] values = new int[3];

for(int i = 0; i < values.Length; i++)
{
    First: Console.WriteLine($"Введите число № {i+1}.");
    string? input = Console.ReadLine();

    try
    {
        values[i] = Convert.ToInt32(input);
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
}

int max = values.Max();
Console.WriteLine($"Максимальное число {max}");