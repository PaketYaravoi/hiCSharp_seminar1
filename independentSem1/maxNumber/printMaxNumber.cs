// Задача №4: Напишите программу , которая принимает 3 числа и выдает, какое число больше , а какое меньшее.

using System.Collections.Concurrent;
using System.ComponentModel.Design;

Console.WriteLine("Enter 3 integer numbers: ");

int num1;
int num2;
int num3;
int maxNumberPosition = 1; // first input number have position = 1

Console.Write("Enter first number: ");
while (!int.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("input eror! Please enter a valid value - integer numbeer ");
    Console.Write("Please enter a first number: ");
}


Console.Write("Enter second number: ");
while (!int.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("input eror! Please enter a valid value - integer numbeer ");
    Console.Write("Please enter a second number: ");
}

Console.Write("Enter third number: ");
while (!int.TryParse(Console.ReadLine(), out num3))
{
    Console.WriteLine("input eror! Please enter a valid value - integer numbeer ");
    Console.Write("Please enter a third number: ");
}


if (num1 == num2)
{
    if (num2 == num3)
    {
        Console.WriteLine($"All numbers are square: maximum = {num1} ");
    }
    else if (num1 > num3)
    {
        Console.WriteLine($"Maximum numbers, first:{num1} and second:{num2}");
    }
    else
    {
        Console.WriteLine($"Maximum number, therd:{num3}");
    }
}

else if (num2 == num3)
{
    if (num3 > num1)
    {
        Console.WriteLine($"Maximum numbers, second:{num2} and third:{num3}");
    }
    else
    {
        Console.WriteLine($"Maximum number, first:{num1}");
    }
}

else
{
    int max = num1;
    maxNumberPosition = 1;
    if (num2 > max)
    {
        max = num2;
        maxNumberPosition = 2;
    }
    if (num3 > max)
    {
        max = num3;
        maxNumberPosition = 3;
    }
    Console.WriteLine($"Maximum number entered is in position {maxNumberPosition}: {max}");
}