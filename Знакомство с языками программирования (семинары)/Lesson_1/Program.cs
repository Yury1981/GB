/*
Console.WriteLine("Good evening!");
int number = 5;
Console.WriteLine("My number is " + number + " and its good!");
Console.WriteLine($"My number is {number} and its good!");
*/

// Задача 1.
/*
Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int kvadrat = number * number;
Console.WriteLine($"Quad of {number} is {kvadrat}");
*/

// Задача 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
{
    Console.WriteLine($"{num1} is a quad of {num2}");
}
else
{
    Console.WriteLine($"{num1} is not a quad of {num2}");
}
*/

// Задача 3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

// Задача 4. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Input positive integer number XXX: ");
int num = Convert.ToInt32(Console.ReadLine());

int lastnum = num % 10;

Console.WriteLine($"Last digit of {num} is: {lastnum}");