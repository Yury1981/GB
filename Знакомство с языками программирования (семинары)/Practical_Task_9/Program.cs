/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
/*
void ShowNums(int m, int n)
{
    Console.Write(m + " ");
    if (m < n) ShowNums(m + 1, n);
    else if (m > n) ShowNums(m - 1, n);
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (m == n) Console.WriteLine(m);
else ShowNums(m, n);
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int SumNums(int x, int y)
{
    if (x <= y) return SumNums(x + 1, y) + x;
    else return 0;
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (m == n) Console.WriteLine(m);
else if (m < n) Console.WriteLine(SumNums(m, n));
else Console.WriteLine(SumNums(n, m));
*/

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

uint Akkerman(uint m, uint n)
{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0)) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Input M: ");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.Write("Input N: ");
uint n = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(Akkerman(m, n));
