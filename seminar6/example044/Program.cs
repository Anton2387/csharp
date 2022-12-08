/* Задача 44: Не используя рекурсию, выведите первые
N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

Console.WriteLine("Введите число");  // просим ввести число в терминал
int number = Convert.ToInt32(Console.ReadLine()); // вводим число в терминал
double[] arrayFibonacci = Fibonacci(number); // возвращаем метод
PrintArray(arrayFibonacci); // печатаем ответ

double[] Fibonacci(int number) // создаем метод, для решения данной задачи
{
    double[] array = new double[number];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(double[] array) // создаем метод, для печати массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}