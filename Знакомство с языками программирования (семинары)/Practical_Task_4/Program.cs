/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
int Sqrt(int A, int B)
{
    int result = 1;
    for (int current = 1; current <= B; current++)
    {
        result *= A;
    }
    return result;
}

Console.Write("Input A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B: ");
int B = Convert.ToInt32(Console.ReadLine());
int res = Sqrt(A, B);
Console.WriteLine(res);
if (res == Math.Pow(A,B))
{
    Console.WriteLine("Всё верно!");
}
else Console.WriteLine("ERROR!");
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*
int DigitSum(int num)
{
    int count = 1;
    int temp = num;
    int result = 0;
    while (temp / 10 > 0)
    {
        temp = temp / 10;
        count++;
    }
    temp = num;
    for (int i = 1; i <= count; i++)
    {
        result += temp % 10;
        temp = temp / 10;
    }
    return result;
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Sum digits is: {DigitSum(num)}");
*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] CreateArray(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(num);
Console.WriteLine("[{0}]", string.Join(", ", arr));