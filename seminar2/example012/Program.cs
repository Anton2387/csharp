Console.WriteLine("Введите два любых числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int dif = Check(number1, number2);

if(dif == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {dif}");
}

int Check(int number1, int number2)
{
    int dif = number1 % number2;
    return dif;
}
