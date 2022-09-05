Console.Clear();

string[] inputArray = new string[15] { "Мама,", "так", "тебя", "люблю,", "что", "не", "знаю", "прямо.",
                                       "Я","большому", "кораблю", "дам", "названье:", "Мама", "..." };
string[] outArray = new string[inputArray.Length];

ArrayOfStringsOfThreeSymbols(inputArray, outArray);
Console.WriteLine("Исходный массив:");
PrintIntArray(inputArray);
Console.WriteLine("Конечный массив:");
PrintIntArray(outArray);

// Метод сверяет размер элементов исходного массива с заданной величиной
// и формирует новый массив элементов с заданной размерностью.

void ArrayOfStringsOfThreeSymbols(string[] inputArray, string[] outArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            outArray[count] = inputArray[i];
            count++;
        }
    }
}

//Метод выводит массив на печать.

void PrintIntArray(string[] inputArray)
{
    int i = 0;
    while (i < inputArray.Length - 1)
    {
        Console.Write(inputArray[i] + " ");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}


Console.ReadLine();
