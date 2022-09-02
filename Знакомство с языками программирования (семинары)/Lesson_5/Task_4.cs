// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(0, 11);
    }
    return newArray;
}

int[] DevElements(int[] array)
{
    int[] devArray = new int[array.Length / 2 + array.Length % 2];
    for(int i = 0; i < devArray.Length; i++)
        devArray[i] = array[i] * array[array.Length - i - 1];
    return devArray;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(size);
Console.WriteLine("[{0}]", string.Join(", ", newArray));

Console.WriteLine("[{0}]", string.Join(", ", DevElements(newArray)));