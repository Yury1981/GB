// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
/*
void PrintArray(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(0, 2);
        Console.Write($"{arr[i]}, ");
    }
}

Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
PrintArray(num);
*/

int [] CreateRandomArray(int n, int minval, int maxval)
{
    int [] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(minval, maxval + 1);
    }
    return arr;
}

void PrintArray(int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine("\b\b]");
}

PrintArray(CreateRandomArray(8, 0, 1));
PrintArray(CreateRandomArray(8, 0, 1));

int [] newArr = CreateRandomArray(8, 0, 1);
PrintArray(newArr);
PrintArray(newArr);