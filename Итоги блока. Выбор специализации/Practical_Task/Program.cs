/* Написать программу, которая из имеющегося массива строк формирует массив строк, длинна которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string[] FindRows(string[] array, int k) // Метод формирования массива из строк требуемой длинны на основе пользовательского массива.
{
    int i = 0; // Счетчик строк, вошедших в сформированный массив.
    string[] res_array = new string[i]; // Объявление сформированного массива.

    foreach(string temp in array) // Перебор строк пользовательского массива.
    {
        if(temp.Length > k) // Если длинна текущей строки больше требуемой - переход к следующей строке.
            continue;

        else // Если длинна текущей строки удовлетворяет условию задачи - добавление её в формируемый массив.
        {
            Array.Resize(ref res_array, res_array.Length +1); // Увеличение размера формируемого мвссива на 1.
            res_array[i] = temp; // Добавление строки в формируемый массив.
            i++; // Увеличение счётчика найденных строк на 1.
        }
    }
    return res_array; // Возврат сформированного массива.
}

void ShowArray(string[] array) // Метод вывода массива на экран.
{
    Console.WriteLine(); // Наведение красоты.
    Console.Write("[");

    for(int i = 0; i < array.Length - 1; i++) // Перебор и вывод на экран всех элементов массива, кроме последнего.
        Console.Write('"' + array[i] + '"' + ", ");

    Console.WriteLine('"' + array[array.Length - 1] + '"' + "]"); // Вывод последнего элемента массива и наведение красоты.
}

string[] user_array = {"Cat", "Lion", "Dog", "Pig", "Puma", "Hippopotamus"}; // Пользовательский массив строк.
ShowArray(user_array); // Вызов метода вывода массива на экран.
int k = 3; // Длинна требуемых строк
string[] res_array = FindRows(user_array, k); // Вызов метода создания нового массива.

if(res_array.Length > 0) // Проверка сформированного массива на наличие элементов.
    ShowArray(res_array); // Вызов метода вывода массива на экран.

else
{
    Console.WriteLine();
    Console.WriteLine("[]" ); // Вывод сообщения, что сформированный массив пустой.

}
Console.WriteLine(); // Ещё немного красоты.
