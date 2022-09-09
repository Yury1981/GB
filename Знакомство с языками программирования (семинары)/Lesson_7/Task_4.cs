// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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

int SumMainDiagonal(int[,] array)
{
    int sum = 0;
    int end = array.GetLength(0);
    if (array.GetLength(1) < array.GetLength(0)) end = array.GetLength(1);
    for (int i = 0; i < end; i++)
        sum = sum + array[i,i];
    return sum;
}

void Show2dArrray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for( int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10) Console.Write(" 0" + array[i,j] + " |");
            else Console.Write(" " + array[i,j] + " |");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArrray(myArray);
int sum = SumMainDiagonal(myArray);
Console.WriteLine($"Sum Main Diagonal =: {sum}");
