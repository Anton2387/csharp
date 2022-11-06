/* Задача 28: Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
4->24 5->120 */

Console.WriteLine("Введите число N");

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

int productofnumbers = DetermineProduct(N);
Console.WriteLine(productofnumbers);

int DetermineProduct(int N)
{
    int product = 1;

    for (int i = 1; i <= N; i++)
    {
        product = product * i;
    }

    return product;
}

