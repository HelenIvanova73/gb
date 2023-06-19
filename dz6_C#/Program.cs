// // Урок 6. Одномерные массивы. Продолжение
// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Task41");

// int m = int.Parse(Console.ReadLine());
// int count = 0;


// for (int i = 0; i < m; i++)
// {
//     int number = int.Parse(Console.ReadLine());
//     if (number == 0)
//     {
//         count ++;
//     }

// }
// Console.WriteLine($"Пользователь ввёл {count} положительных чисел");

// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Task43");
// Console.WriteLine("Введите k1");
// int k1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите b1");
// int b1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите k2");
// int k2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите b2");
// int b2 = int.Parse(Console.ReadLine());

// double x = (b2 - b1) / (k1 -k2);
// double y = k1 * x + b1;

// Console.WriteLine($"Координаты точки пересечения прямых : ({x}; {y})");

//Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Двумерный массив

// метод для создания массива 
// Двумерный массив = matrix
// m - кол-во строчек, n - столбцов

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resMatrix = GetMatrix(rows, columns, 0, 10);
// rows=3, columns=4 => таблица из 3 строк и 4 столбцов, элемент: число от 0 до 10 включительно
PrintMatrix(resMatrix); // PrintMatrix(матрица)

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n]; // Таблица из m строк и n столбцов 
    for (int i = 0; i < matrix.GetLength(0); i++) // Цикл по строчкам , i < m
    {
        // i,j,m,k 
        for (int j = 0; j < matrix.GetLength(1); j++)// Цикл по стобцам , j < n
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

// Метод, который печатает массив 
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {
            Console.Write(array[i,j] + "\t"); // "\t" = Tab = 4 пробела между элементами
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
for (int i = 0; i < resMatrix.GetLength(0); i += 2)
{
    for (int j = 0; j < resMatrix.GetLength(1); j +=2)
    {
        resMatrix[i, j] = resMatrix[i, j] * resMatrix[i,j];
    }
}

PrintMatrix(resMatrix);