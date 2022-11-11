/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран. Задание должно быть выполнено в методах.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.WriteLine("Введите массив из 8 элементов");
int a =Convert.ToInt32(Console.ReadLine());
int b =Convert.ToInt32(Console.ReadLine());
int c =Convert.ToInt32(Console.ReadLine());
int d =Convert.ToInt32(Console.ReadLine());
int e =Convert.ToInt32(Console.ReadLine());
int f =Convert.ToInt32(Console.ReadLine());
int g =Convert.ToInt32(Console.ReadLine());
int h =Convert.ToInt32(Console.ReadLine());
Console.Write("[");
int [] array = GenerateArray(a, b, c, d, e, f, g, h);
PrintArray(array);

int [] GenerateArray(int a, int b, int c, int d, int e, int f, int g, int h)
{
    int [] array = new int [8] {a, b, c, d, e, f, g, h};
    return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array [i]}, ");
    }
}
Console.Write("]");