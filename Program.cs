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

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int value = 0;
First: Console.WriteLine("Введите число.");
string? input = Console.ReadLine();

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

if((value % 2) == 0)
{
    Console.WriteLine("Четное.");
} else {
    Console.WriteLine("Нечетное.");
}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;
using System.Runtime.ExceptionServices;

int value = 0;

First: Console.WriteLine("Введите число.");
string? input = Console.ReadLine();

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

if(value > 1)
{
    int[] evens = new int[value / 2];
    int j = 2;
    for(int i = 0; i < value / 2; i++)
    {
        evens[i] = j;
        j += 2;
    }

    for(int i = 0; i < evens.Length; i++)
    {
        Console.WriteLine(evens[i]);
    }
} else {
    Console.WriteLine("Нет четных чисел.");
}


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using System;
using System.Runtime.ExceptionServices;

int value = 0;

First: Console.WriteLine("Введите трехзначное число.");
string? input = Console.ReadLine();

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

value = (value/10)%10;
Console.WriteLine(value);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

using System;
using System.Runtime.ExceptionServices;

int value = 0;

First: Console.WriteLine("Введите трехзначное число.");
string? input = Console.ReadLine();

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

if(value < 100)
{
    Console.WriteLine("Это двухзначное число.");
} else 
{
    value = (value % 100) % 10;
    Console.WriteLine(value);
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

using System;
using System.Runtime.ExceptionServices;

int value = 0;

First: Console.WriteLine("Введите цифру от 1 до 7.");
string? input = Console.ReadLine();

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
if(value < 1 || value > 7)
{
    Console.WriteLine("Некорректный ввод. Введите число от 1 до 7.");
    goto First;
}
if(value == 6 || value == 7)
{
    Console.WriteLine("Выходной.");
} else 
{
    Console.WriteLine("Рабочий.");
}
