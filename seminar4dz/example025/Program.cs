/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B. 
Задание должно быть выполнено в методе. 
В методе не должно быть вывода в консоль.
3, 5 -> 243 (3⁵)
2, 4 -> 16  */

Console.WriteLine("Введите два числа А и Б");

bool isParsed = int.TryParse(Console.ReadLine(), out int a);
bool isParsedd = int.TryParse(Console.ReadLine(), out int b);

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

if(!isParsedd)
{
    Console.WriteLine("Не правильно введены данные");
    return;
}
if(b < 1)
{
    Console.WriteLine("0");
    return;
}

int degree = DetermineDegree(a, b);
Console.WriteLine($"Число А в натуральной степени Б равно {degree} ");

int DetermineDegree(int a, int b)
{
    int number = 1;
    while (b>0)
    {
        b-=1;
        number = number * a;
    }
    return number;
}

