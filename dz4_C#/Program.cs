// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Task 25");

Console.WriteLine("Введите основание степени А");
int  baseOfDegree = int.Parse(Console.ReadLine());
Console.WriteLine("Введите показатель степени B");
int exponent = int.Parse(Console.ReadLine());
int res = 1;
for (int i = 1; i < exponent + 1; i++)
{
  res *=   baseOfDegree;
}
Console.WriteLine($"{baseOfDegree}^{exponent} = {res}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Task 27");

Console.WriteLine("Введите целое число");
int  number = int.Parse(Console.ReadLine());
int n = number;
int sumDigit = 0;
while (n > 0)
{
  sumDigit += n % 10;
  n /= 10;
}
Console.WriteLine($"Cумма цифр числа {number} = {sumDigit}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Task 29");
int size = 8;
int[] array = new int [size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(20);
}
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
