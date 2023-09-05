
// Написать программу, которая из имеющегося массива строк формирует новый массив из 
// строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
void PrintArray(string[] input, string[] result)
{
    Console.Write("[");
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write("\"" + input[i] + "\"");
        if (i < input.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");

    Console.Write(" => ");

    Console.Write("[");
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write("\"" + result[i] + "\"");
        if (i < result.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

string[] FilterArray(string[] inputArray)
{
    string[] resultArray = new string[inputArray.Length];
    int resultCount = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[resultCount] = inputArray[i];
            resultCount++;
        }
    }

    string[] finalArray = new string[resultCount];
    for (int i = 0; i < resultCount; i++)
    {
        finalArray[i] = resultArray[i];
    }

    return finalArray;
}

string[] GetInputArray()
{
    Console.WriteLine("Введите элементы массива, разделяя их пробелами:");
    string input = Console.ReadLine();
    return input.Split(' ');
}

string[] inputArray = GetInputArray();
string[] filteredArray = FilterArray(inputArray);

PrintArray(inputArray, filteredArray);