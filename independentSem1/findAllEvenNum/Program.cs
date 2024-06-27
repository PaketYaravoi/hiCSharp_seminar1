// Задача №8: Напишите программу , которая принимает число (N) а на выходе показывает все четные числа от 1 до N. 

Console.WriteLine();

int n = 0;


Console.Write("Enter a valid integer: ");
while (!int.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("input eror!");
    Console.Write("Please enter integer: ");
}
for (int showEvenNum = 2; showEvenNum < n; showEvenNum += 1)
{
    if (showEvenNum % 2 == 0)
    {
        Console.Write(showEvenNum + " ");
    }
}    