// See https://aka.ms/new-console-template for more information
// Урок 5. Функции и одномерные массивы
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных 
// чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int [] resultArray = new int[size];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

Console.WriteLine("Введите размерность массива");
int size = int.Parse(Console.ReadLine());
int[] array = GetArray(size, 100, 999);
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
int count = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] % 2 == 0)
    {
       count += 1; 
    }
}
Console.WriteLine($"Количество четных элементов = {count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray36(int size, int minValue, int maxValue)
{
    int [] resultArray = new int[size];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

Console.WriteLine("Введите размерность массива");
int Size = int.Parse(Console.ReadLine());
int[] array36 = GetArray36(Size, -100, 100);
Console.WriteLine($"Массив: [{String.Join("; ", array36)}]");
int sumOddIndex = 0;
for (int i = 1; i < Size; i += 2)
{
       sumOddIndex +=  array36[i]; 
}
Console.WriteLine($"Сумма элементов c нечётными индексами = {sumOddIndex}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
Console.WriteLine("Task38");

double[] GetArray38(int size38, double minValue38, double maxValue38)
{
    double [] resultArray38 = new double[size38];
    for (int i = 0; i < resultArray38.Length; i++)
    {
        //Random rnd = new Random();
        resultArray38[i] = Math.Round(new Random().NextDouble() * (maxValue38 - minValue38) + minValue38, 2);
    }
    return resultArray38;
}

Console.WriteLine("Введите размерность массива");
int size38 = int.Parse(Console.ReadLine());
double[] array38 = GetArray38(size38, -100, 100);
Console.WriteLine($"Массив: [{String.Join("; ", array38)}]");
double maxElement = -100;
double minElement = 100;
for (int i = 0; i < size38; i++)
{
     if (array38[i] > maxElement)
     {
        maxElement = array38[i]; 
     }
     if (array38[i] < minElement)
     {
        minElement = array38[i]; 
     }
}
Console.WriteLine($"Разность между макмимальным и минимальным = {maxElement - minElement}");