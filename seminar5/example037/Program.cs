/* Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. 
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

Console.WriteLine("Введите количество элементов в массиве");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
FillArray(array);
PrintArray(array);
int count2 = count/2;
if (count%2!=0)
{
    count2++;
}

int [] array2 = new int [count2];
int result = ProductNumberArray(array);
Console.WriteLine($"Произведения пар чисел = {result}");

int ProductNumberArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array2[i]=array[i]*array[array.Length-1-i];
    }
    return array;
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
        array[i] = random.Next(1, 100);
    }
}
