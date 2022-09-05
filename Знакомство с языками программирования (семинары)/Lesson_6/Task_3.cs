// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник сo сторонами такой длины.

bool Proverka(int a, int b, int c)
{
    return a + b > c & a + c > b & b + c > a;
}

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (Proverka(a, b, c) == true) Console.WriteLine("This is triangle");
else Console.WriteLine("This is'nt triangle");