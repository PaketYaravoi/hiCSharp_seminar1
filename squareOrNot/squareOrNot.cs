// Является ли 1-е число , квадратом 2-го:
// 25 и 5 --> yes


Console.Write("Введите число которое на ваш взгляд является квадратом: ");
int squareNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число которое на ваш взгляд является производным квадрата: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == squareNum / number)
{
    Console.WriteLine($"Число: {squareNum}, является квадратом числа: {number}.");
}
else
{
    Console.WriteLine($"Число: {squareNum}, не является квадратом числа: {number}.");
}
