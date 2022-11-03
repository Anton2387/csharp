/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число и проверьте является и оно полиндромом");
bool isParsed = int.TryParse(Console.ReadLine(), out int x);
if(!isParsed)
{
    Console.WriteLine("Не правильно введены данные");
    return;
}

int polindrom = DeterminePolindrom(x);
if(polindrom == 1)
{
    Console.WriteLine("Является полиндромом");
}
else
{
    Console.WriteLine("Не является полиндромом");
}

int DeterminePolindrom(int x)
{
    int number1 = x;
    number1 = number1 / 10000;
    int number2 = x;
    number2 = number2 / 1000 % 10;
    int number4 = x;
    number4 = number4 / 10 % 10;
    int number5 = x;
    number5 = number5 % 10;

    if(number1 == number5& number2 == number4 )
    {
        x = 1;
    }
    else
    {
        x = 2;
    }

    return x;
}