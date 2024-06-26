// Задача №3 Напишите программу , которая будет выдавать название для недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// 1 -> Понедельник и тд

Console.Write("Ведите номер дня: ");
int input = int.Parse(Console.ReadLine()!);

if (input == 1)
{
    Console.WriteLine("Сегодня - Понедельник!");
}
else if (input == 2)
{
    Console.WriteLine("Сегодня - Вторник!");
}
else if (input == 3)
{
    Console.WriteLine("Сегодня - Среда!");
}
else if (input == 4)
{
    Console.WriteLine("Сегодня - Четверг!");
}
else if (input == 5)
{
    Console.WriteLine("Сегодня - Пяница(Танцуем)!");
}
else if (input == 6)
{
    Console.WriteLine("Сегодня - Суббота");
}
else if (input == 7)
{
    Console.WriteLine("Сегодня Воскресенье(");
}
else
{
    Console.WriteLine("введите корректное значение, номер дня недели от 1 до 7 и  повторите ввод");
}