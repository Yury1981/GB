int[,] CreateSpiral()
{
    Console.Write("Input numbers of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] newArray = new int[m, n];
    int number = 1;
    int countrows = 0;
    int countcolumns = 0;
    //Console.WriteLine(newArray.Length);
    for (int i = countrows; i < m - countrows; i++)
            for (int j = countcolumns; j < n - countcolumns; j++)
            {
                newArray[i, j] = number;
                number++;
                Console.WriteLine(i);
            }
            countrows++;
            for (int k = countrows ; k < m; k++)
            {
                newArray[k, n - 1] = number;
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
