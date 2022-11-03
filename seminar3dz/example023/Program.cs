/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число N");
int x = Convert.ToInt32(Console.ReadLine());
int [] SquareNumber(int x)
{
    int [] array = new int [x];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = (i+1)*(i+1)*(i+1);
    }
    return array;
}

int [] result = SquareNumber(x);
PrintArray(result);
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
