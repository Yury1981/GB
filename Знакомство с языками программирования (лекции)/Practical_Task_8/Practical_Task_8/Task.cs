int[,] 
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