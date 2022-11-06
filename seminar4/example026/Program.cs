/* Задача 26: Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.
456 -> 3 78 -> 2 89126 -> 5 */

Console.WriteLine("Введите любое число");

bool isParsed = int.TryParse(Console.ReadLine(), out int a);

if(!isParsed)
{
    Console.WriteLine("Не правильно введены данные");
    return;
}
if(a < 1)
{
    Console.WriteLine("0");
    return;
}

int number = DetermineNumber(a);
Console.WriteLine(number);

int DetermineNumber(int a)
{
    int count = 1;

    for (int i = 9; i < a; i++)
    {
        a = a / 10;
        count += 1;
    }

    return count;
}