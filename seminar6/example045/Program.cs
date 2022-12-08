/* Задача 45: Напишите программу, 
которая будет создавать копию заданного массива 
с помощью поэлементного копирования. */


int[] array = GenerateArray(); // возвращаем метод с рандомным массивом
PrintArray(array);  // печатаем ответ

Console.WriteLine();  // пробел

int[] copyArray = CopyArray(array); // возвращаем метод, со скопированным рандомным массивом
PrintArray(copyArray);  // печатаем ответ


int[] GenerateArray() // создаем метод, для рандомного создания массива
{
    int[] array = new int[8];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 10);
    }
    return array;
}


int[] CopyArray(int[] array)  // создаем метод, для копирования рандомного массива
{
    int[] сopyArray = new int[array.Length];
    for (var i = 0; i < array.Length; i++)
    {
        сopyArray[i] = array[i];
    }
    return сopyArray;
}


void PrintArray(int[] array) // создаем метод, для печати массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}