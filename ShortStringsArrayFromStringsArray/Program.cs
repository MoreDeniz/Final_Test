// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна
// 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении
// не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

Console.Clear();

int InputNumber(string message)
{
    while (true)
    {
        Console.Write(message);
        bool result = int.TryParse(Console.ReadLine() ?? "0", out int number);
        if (!result)
        {
            Console.WriteLine($"Ввод некорректный! Попробуйте ещё раз.");
            Thread.Sleep(1500);
            continue;
        }
        return number;
    }
}

string[] GetArray(int n)
{
    string[] result = new string[n];
    for (int i = 0; i < n; i++)
    {
        result[i] = Console.ReadLine();
    }
    return result;
}

void PrintArray(string[] array)
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"'{array[i]}' ");
    }
    Console.Write($"]");
}

void Resize(ref string[] array, int newSize)
{
    newSize = 1;
    string[] shortStrings = new string[0]; // массив для хранения коротких строк
    for (int i = 0; i < array.Length; i++)
    {
        string elem = array[i];
        if (elem.Length < 4)
        {
            Array.Resize(ref shortStrings, newSize); // изменяем размерр массива
            shortStrings[newSize - 1] = elem; // добавляем короткую строку в массив
            newSize++;
        }
    }
    array = shortStrings; // заменяем ссылку со старого на новый массив
}

int size = InputNumber("Введите количество строк в массиве: "); // Размер массива. 
Console.WriteLine("Введите строки: ");      // Строки. 
string[] strings = GetArray(size);
PrintArray(strings);
Console.WriteLine();
Resize(ref strings, 0);
PrintArray(strings);
Console.WriteLine();

