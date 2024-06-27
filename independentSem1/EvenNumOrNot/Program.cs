// Задача №6: Напишите программу , которая принимает число и выдает, является ли число четным (делиться ли оно на 2 без остатка).

int input = 0;
Console.WriteLine("");

Console.Write("Enter a valid integer: ");
while (!int.TryParse(Console.ReadLine()!,out input))
{
    Console.WriteLine("input eror! Please enter a valid integer");
    Console.Write("Enter a valid integer: ");
}

Console.WriteLine("");
if (input % 2 == 0)
{
    Console.WriteLine($"Entered integer:{input} - Even numbers");
}
else
{
    Console.WriteLine($"Entered integer:{input} - Not an even number");
}
Console.WriteLine("");