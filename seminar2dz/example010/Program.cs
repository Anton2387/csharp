// Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.
//456-> 5
//782-> 8
//918-> 1
//22->Ошибка.
//1234->Ошибка.
// Выполнять задание не используя string.

Console.WriteLine("Введите любое трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int result = Search(number);

int Search(int number)
{
    int last = number % 100;
    int result = last / 10;
    if(number > 99& number < 1000)
    {
        Console.WriteLine($"Вторая цифра введенного числа {result}");
    }
    else
    {
        Console.WriteLine("Ошибка");
    }
    return result;
}