// Урок 3. Базовые алгоритмы. Продолжение
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Task 19");
Console.WriteLine("Get five-digit number");
int number;
string stringNumber = Console.ReadLine();
bool isNumber = int.TryParse(stringNumber, out number);
int  n = stringNumber.Length;
if (n != 5)
{
   Console.WriteLine("Get five-digit number, please");
}
else if (isNumber == false)
{
    Console.WriteLine("Number consists aus digits");
} 
else if (stringNumber[0] == stringNumber[4] && stringNumber[1] == stringNumber[3])
{
    Console.WriteLine("palindrom");
} 
else
{
    Console.WriteLine("no");
}


// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Task 21");

Console.WriteLine("Введите абсциссу точки А");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ординату точки А");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите аппликату точки А");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите абсциссу точки B");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ординату точки B");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите аппликату точки B");
int z2 = int.Parse(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow(x1 - x2, 2 ) + Math.Pow(y1 - y2, 2 ) + Math.Pow(z1 - z2, 2 ));
Console.WriteLine($"АB = {Math.Round(AB, 2)}");

// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Task 23");

Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i < N + 1; i++)
{
  Console.Write($"{Math.Pow(i, 3)}  ");
}
