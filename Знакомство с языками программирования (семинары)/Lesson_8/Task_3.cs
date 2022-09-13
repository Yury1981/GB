// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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

int[,] DeleteCross(int[,] array)
{
    int[,] cutarray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int min = array[0, 0];
    int mini = 0;
    int minj = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 1; j < array.GetLength(1); j++)
            if (min > array[i, j])
            {
                min = array[i, j];
                mini = i;
                minj = j;
            }
    int x = 0;
    for (int m = 0; m < cutarray.GetLength(0); m++)
    {
        if (x == mini) x++;
        int y = 0;
        for (int n = 0; n < cutarray.GetLength(1); n++)
        {
            if (y == minj) y++;
            cutarray[m, n] = array[x, y];
            y++;
        }
        x++;
    }
    return cutarray;
}

int[,] myArray = CreateRandom2dArray();
Show2dArrray(myArray);
Show2dArrray(DeleteCross(myArray));
