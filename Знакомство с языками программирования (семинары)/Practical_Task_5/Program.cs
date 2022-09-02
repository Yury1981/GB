/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 1000);
    return newArray;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1] + "]");    
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size);
PrintArray(newArray);
Console.WriteLine($"Quantity of even numbers: {CountEvenNumbers(newArray)}");
*/

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(-99, 100);
    return newArray;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1] + "]");    
}

int SumNotEvenIndex(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i++)
        if (i % 2 > 0) sum += array[i];
    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size);
PrintArray(newArray);
Console.WriteLine($"Sum of not even index elements = {SumNotEvenIndex(newArray)}");
*/

/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] CreateRandomArray(int size)
{
    double[] newArray = new double[size];
    for (int i = 0; i < size; i++)
        newArray[i] = Math.Round(new Random().Next(0, 100) + new Random().NextDouble(), 2);
    return newArray;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + " | ");
    Console.WriteLine(array[array.Length - 1] + "]");    
}

double DiffMinMax(double[] array)
{
    double min = array[0];
    double max = array[1];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return Math.Round(max - min,2);
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomArray(size);
PrintArray(newArray);
Console.WriteLine($"Difference of minimum and maximum = {DiffMinMax(newArray)}");