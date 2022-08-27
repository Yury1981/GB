/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
Console.Write("Input first integer number : ");
int firstnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number : ");
int secondnum = Convert.ToInt32(Console.ReadLine());

if(firstnum == secondnum)
{
    Console.WriteLine("Еhe numbers are equal");
}
else
{
    if(firstnum < secondnum)
    {
        Console.WriteLine($"{secondnum} is largest number");
        Console.WriteLine($"{firstnum} is lowest number");
    }
    else
    {
        Console.WriteLine($"{firstnum} is largest number");
        Console.WriteLine($"{secondnum} is lowest number");
    }
}
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
Console.Write("Input first integer number : ");
int firstnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number : ");
int secondnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number : ");
int thirdnum = Convert.ToInt32(Console.ReadLine());

int maxnum = firstnum;

if(secondnum > maxnum)
{
    maxnum = secondnum;
}
if(thirdnum > maxnum)
{
    maxnum = thirdnum;
}

Console.WriteLine($"Maximum number is {maxnum}");
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
/*
Console.Write("Input integer number : ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.Write("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Input integer number : ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 2;

if(num > 1)
{
    while(current <= num)
    {
        Console.Write(current + " ");
        current += 2;
    }
}
else
{
    Console.WriteLine("ERROR");
}