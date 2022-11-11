/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число");

bool isParsed = int.TryParse(Console.ReadLine(), out int N);

if(!isParsed)
{
    Console.WriteLine("Ошибка, не правильно введены данные");
    return;
}
if(N < 1)
{
    Console.WriteLine("0");
    return;
}

int number = DetermineNumber(N);
Console.WriteLine($"Сумма цифр в числе равна {number}");

int DetermineNumber(int N)
{
    int sum = 0;
    int num = N;
    int first = N;
    
    for (int i = 0; i <= N; i++)
    {
        N = N/10;
        num = first%10;
        first = first/10;
        sum = sum + num;
    }
    
    return sum;
}
