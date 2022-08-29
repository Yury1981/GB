// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

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