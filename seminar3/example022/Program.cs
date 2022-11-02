/*Задача 22: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25. 2 -> 1,4*/

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int [] SquareNumber(int x)
{
    int [] array = new int [x];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = (i + 1) * (i + 1);
    }
    return array;
}

int [] result = SquareNumber(x);
PrintArray(result);
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array [i]} ");
    }
}