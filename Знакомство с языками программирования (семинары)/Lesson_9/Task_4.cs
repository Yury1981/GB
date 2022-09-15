// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int StepenNum(int a, int b)
{
    if (b > 0) return StepenNum(a, b - 1) * a;
    else return 1;
}

Console.WriteLine(StepenNum(2, 3));



int x = 1;
while (x < 5) Console.Write(x++);
Console.WriteLine();
x = 1;
while (x < 5) Console.Write(++x);
