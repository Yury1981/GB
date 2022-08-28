/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
bool Palindrom(int num)
{
    int count = 1;
    int temp = num;
    while (temp / 10 > 0)
    {
        temp = temp / 10;
        count++;
    }
    int i = 1;
    bool x = true;
    while (i <= count / 2 & x == true)
    {
        x = num % Convert.ToInt32(Math.Pow(10,i)) / Convert.ToInt32(Math.Pow(10,(i-1))) == (num / Convert.ToInt32(Math.Pow(10,(count - i)))) % 10;
        i++;
    }
    return (x);
}

Console.WriteLine("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9)
{
    bool y = Palindrom(num);
    if (y == true) Console.WriteLine($"Введенное число является палиндромом! {y}");
    else Console.WriteLine($"Введенное число не является палиндромом! {y}");
}
else Console.WriteLine("ERROR");
*/

/* Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
void Distance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    Console.WriteLine(Math.Sqrt(Math.Pow(Math.Abs(xB-xA),2) + Math.Pow(Math.Abs(yB-yA),2) + Math.Pow(Math.Abs(zB-zA),2)));
}
Console.Write("Input XA coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input YA coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input ZA coordinate: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input XB coordinate: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input YB coordinate: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input ZB coordinate: ");
double zB = Convert.ToDouble(Console.ReadLine());
Distance(xA,yA,zA,xB,yB,zB);
*/

/* Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void Cube(int N)
{
    for (int i = 1; i <= N; i++)
    Console.WriteLine($"{i} ^ 3 = {Math.Pow(i,3)}");
}

Console.Write("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
Cube(N);