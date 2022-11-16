/* Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет 3; массив [6, 7, 19, 345, 3] -> да */
Console.WriteLine("Введите любое число");
int a = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[12];

FillArray(numbers);
PrintArray(numbers);

Console.WriteLine(FindNumberInArray(numbers,a));

bool FindNumberInArray(int[] array, int a)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == a)
        {
            return true;
        }
    }
    return false;
}

(int, int) sum = GetSumNegativeAndPositiveNumbers(numbers);

Console.WriteLine($"Negative = {sum.Item1}, Positive = {sum.Item2}");

(int, int) GetSumNegativeAndPositiveNumbers(int[] array)
{
    int sumNegative = 0;
    int sumPositive = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNegative += array[i];
        }
        else
        {
            sumPositive += array[i];
        }
    }
    return (sumNegative, sumPositive);
}


int GetSumNegativeNumbers(int[] numbers)
{
    int sum = 0;

    for (var i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
        {
            sum += numbers[i];
        }
    }

    return sum;
}

int GetSumPositivNumbers(int[] numbers)
{
    int sum = 0;

    for (var i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            sum += numbers[i];
        }
    }

    return sum;
}



void PrintArray(int[] array)
{
    Console.WriteLine();
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
}

