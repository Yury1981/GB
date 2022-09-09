/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
double[,] CreateRandom2dDoubleArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] newArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for( int j = 0; j < columns; j++)
            newArray[i,j] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 1);
    return newArray;
}

void Show2dArrray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0,5} |", array[i,j]);
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandom2dDoubleArray();
Show2dArrray(myArray);
*/

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for( int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
    return newArray;
}

void Show2dArrray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0,4} |", array[i,j]);
        Console.WriteLine();
    }
Console.WriteLine();
}

void FindElement(int[,] array, int i, int j)
{
    if (i <= array.GetLength(0) && j <= array.GetLength(1)) Console.WriteLine($"Your element is: {array[i - 1,j - 1]}");
    else Console.WriteLine("Element in not found!");
}

int[,] myArray = CreateRandom2dArray();

Show2dArrray(myArray);

Console.Write("Input row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column: ");
int column = Convert.ToInt32(Console.ReadLine());
FindElement(myArray, row, column);

*/

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for( int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
    return newArray;
}

double[] CalculateMean(int[,] array)
{
    double[] mean = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double res = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            res += array[i,j];
        res /=  array.GetLength(0);
        mean[j] = res; 
    }
    return mean;
}

void Show2dArrray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0,4} |", array[i,j]);
        Console.WriteLine();
    }
Console.WriteLine();
}

void ShowArrray(double[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
        Console.Write("{0,4} |", array[i]);
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();

Show2dArrray(myArray);

double[] mean = CalculateMean(myArray);

ShowArrray(mean);
