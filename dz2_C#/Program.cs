// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Task 10");
Console.WriteLine("Get tree-digit number");
int number = int.Parse(Console.ReadLine());
if (number > 999 || number < 100)
{
   Console.WriteLine("Please, get tree-digit number!");
}
else
{
    Console.WriteLine($"Вторая цифрра - {number / 10 % 10}");
}

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Task 13");
Console.WriteLine("Get number");
int number1 = int.Parse(Console.ReadLine());

if (number1 < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine($"третья цифра - {(number1 / 100) % 10}");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Task 8");
Console.WriteLine("Get digit - day of the week");
int dayOfTheWeek = int.Parse(Console.ReadLine());
if (1 < dayOfTheWeek && dayOfTheWeek< 6)
{
    Console.WriteLine("weekend");
} 
else if ((dayOfTheWeek > 7 )|| (dayOfTheWeek < 1))
{
    Console.WriteLine("Sorry, but 7 days in a week");
}
else
{
    Console.WriteLine("weekday");
}