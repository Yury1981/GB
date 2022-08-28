// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool Kradrat(int first, int second)
{
    bool result = false;
    if (first > second)
    {
        if (second * second == first) result = true;
    }
    else
    {
        if (first * first == second) result = true;
    }
    return(result);
}
Console.Write("Input first integer number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int second = Convert.ToInt32(Console.ReadLine());
bool res = Kradrat(first, second);

if (second > first & res == true) Console.WriteLine("Второе число - квадрат первого");
else
{
    if (first > second & res == true) Console.WriteLine("Первое число - квадрат второго");
    else Console.WriteLine("Числа не являются квадратами друг друга");
}