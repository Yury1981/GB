/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*
int ShowDigit(int number)
{
    int result = (number / 10) % 10;
    return result;
}

Console.Write("Input XXX integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 & num < 1000)
{
    int res = ShowDigit(num);
    Console.WriteLine($"Вторая цифра числа {num} - это {res}");
}
else Console.WriteLine("Ошибка ввода");
*/

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
int ShowDigit(int number)
{
    while (number > 1000) number = number / 10;
    int result = (number % 10);
    return result;
}

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    int res = ShowDigit(num);
    Console.WriteLine($"Третья цифра числа {num} - это {res}");
}
else Console.WriteLine("Третьей цифры нет");
*/

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

bool Weekend(int number)
{
    return (number == 6 ^ number == 7);
}

Console.Write("Input day of week: ");
int num = Convert.ToInt32(Console.ReadLine());
bool dd = false;
if (num > 0 & num < 8)
{
    dd = Weekend(num);
    if (dd == true) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
else Console.WriteLine("Ошибка ввода");