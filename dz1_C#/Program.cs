//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Task 2");
Console.WriteLine("Get first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Get second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber + ">, " + secondNumber + "<");
}
else
{
    Console.WriteLine(secondNumber+ ">, " + firstNumber + "<");

}


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Task 4");
Console.WriteLine("Get first number");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Get second number");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Get third number");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber)
{
    Console.WriteLine("Greater number is first: " + FirstNumber);
}
else if (SecondNumber > ThirdNumber)
{
    Console.WriteLine("Greater number is second: " + SecondNumber);
}
else
{
    Console.WriteLine("Greater number is third: " + ThirdNumber);
}

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Task 6");
Console.WriteLine("Get number");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number % 2 == 0)
{
    Console.WriteLine("Number is even");
}
else
{
    Console.WriteLine("Number is odd");
}


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Task 8");
Console.WriteLine("Get number");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < number; i += 2)
{
    Console.WriteLine(i);
}




