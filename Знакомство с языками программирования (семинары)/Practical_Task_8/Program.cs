/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Show2dArrray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write(" 0" + array[i, j] + " |");
            else Console.Write(" " + array[i, j] + " |");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] SortArray(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1) - 1; j++)
            for (int n = j + 1; n < array.GetLength(1); n++)
                if (array[i, n] > array[i, j])
                {
                    temp = array[i, n]; 
                    array[i, n] = array[i, j];
                    array[i, j] = temp;
                }
    return array;
}

int[,] myArray = CreateRandom2dArray();
Show2dArrray(myArray);
Show2dArrray(SortArray(myArray));
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Show2dArrray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write(" 0" + array[i, j] + " |");
            else Console.Write(" " + array[i, j] + " |");
        }
        Console.WriteLine($" - {i + 1}-я строка");
    }
    Console.WriteLine();
}
int MinSumRow(int[,] array)
{
    int sum = 0; 
    for (int j = 0; j < array.GetLength(1); j++)
        sum += array[0, j];
    int x = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempsum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            tempsum += array[i, j];
        if (tempsum < sum)
        {
            x = i;
            sum = tempsum;
        } 
    }
    Console.Write($"Minimal sum of elements: {sum}, ");
    return x;
}

int[,] myArray = CreateRandom2dArray();
Show2dArrray(myArray);

Console.WriteLine($"is in {MinSumRow(myArray) + 1} row");
*/

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void Show2dArrray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write(" 0" + array[i, j] + " |");
            else Console.Write(" " + array[i, j] + " |");
        }
        Console.WriteLine($" - {i}-я строка");
    }
    Console.WriteLine();
}
int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] resMatrix = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < resMatrix.GetLength(0); i++)
        for (int j = 0; j < resMatrix.GetLength(1); j++)
            for (int x = 0; x < array2.GetLength(0); x++)
                resMatrix[i, j] += array1[i, x] * array2[x, j];
    return resMatrix;
}

Console.Write("Input numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateRandom2dArray(rows, columns, minValue, maxValue);
int[,] matrix2 = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArrray(matrix1);
Show2dArrray(matrix2);

Console.WriteLine("Matrix A x Matrix B =");
Show2dArrray(MatrixMultiplication(matrix1, matrix2));
*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/*
int[,,] CreateRandom3dArray()
{
    Console.Write("Input numbers of rows: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of diagonal: ");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,,] newArray = new int[z, x, y];
    int number;
    int count = 0;
    for (int k = 0; k < z; k++)
        for (int i = 0; i < x; i++)
            for (int j = 0; j < y; j++)
            {
                number = new Random().Next(minValue, maxValue + 1);
                for (int o = 0; o < z; o++)
                    for (int m = 0; m < x; m++)
                        for (int n = 0; n < y; n++)
                            if (number != newArray[o, m, n]) count++;
                        if (count == newArray.Length)
                        {
                            newArray[k, i, j] = number;
                            count = 0;
                        }
                        else
                        {
                            count = 0;
                            j = (j - 1);
                            continue;
                        }
            }
    return newArray;
}

void Show3dArrray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("|");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0,4}", array[i, j, k]);
                Console.Write($"({i},{j},{k}) |");
            }
            Console.WriteLine();
        }
}

void Show3dArrray2(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        Console.WriteLine($"This is {k} layer");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("|");
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write("{0,4} |", array[i, j, k]);
            Console.WriteLine();
        }
         Console.WriteLine();
    }
}

int[,,] myArray = CreateRandom3dArray();
Show3dArrray(myArray);
Console.WriteLine();
Show3dArrray2(myArray);
*/

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] CreateSpiral()
{
    Console.Write("Input numbers of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] newArray = new int[m, n];
    int istart = 0, iend = m - 1, jstart = 0, jend = n - 1, number = 1, i = 0, j = 0;
    while (number <= newArray.Length)
    {
        newArray[i, j] = number;
        if (i == istart && j < jend) j++;
        else if (j == jend && i < iend) i++;
        else if (i == iend && j > jstart) j--;
        else if (j == jstart && i > istart) i--;
        if (i == istart && j == jstart)
        {
            istart++;
            jstart++;
            i++;
            j++;
            iend--;
            jend--;
        }
        number++;
    }
    return newArray;
}

void Show2dArrray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write(" 0" + array[i, j] + " |");
            else Console.Write(" " + array[i, j] + " |");
        }
        Console.WriteLine($" - {i}-я строка");
    }
    Console.WriteLine();
}

int[,] myArray = CreateSpiral();
Show2dArrray(myArray);
