// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int DelDigit(int number)
{
    int therdNumber = number % 10;
    int firstNumber = number / 100;
    int result = firstNumber * 10 + therdNumber;
    return result;
}
int randNumber = new Random().Next(100, 1000);
int delDigit = DelDigit(randNumber);
Console.WriteLine(randNumber);
Console.WriteLine(delDigit);