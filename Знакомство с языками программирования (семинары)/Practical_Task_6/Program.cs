/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/*
int[] EnterNumbers()
{
    string input = string.Empty;
    input = Console.ReadLine();
    int[] numbers = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    return numbers;
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Write("Enter the numbers cherez probel: ");
int[] array = EnterNumbers();

Console.WriteLine($"You entered {CountPositiveNumbers(array)} numbers > 0");
*/

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double Input(string m)
{
    Console.Write($"Input {m}: ");
    double n = Convert.ToInt32(Console.ReadLine());
    return n;
}

string RaschetCrossPoint(double b1, double k1, double b2, double k2)
{
    string res = string.Empty;
    if (k1 == k2 & b1 == b2) res = "The lines is match";
    else if (k1 == k2) res = "The lines are parallel";
    else
    {
        double x = (b2 - b1)/(k1 - k2);
        double y = k1 * x + b1;
        res = $"Cross point is:\nX = {x}; Y = {y}";
    }
    return res;
}

double b1 = Input("b1");
double k1 = Input("k1");
double b2 = Input("b2");
double k2 = Input("k2");

Console.WriteLine(RaschetCrossPoint(b1, k1, b2,k2));
