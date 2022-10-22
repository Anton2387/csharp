Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
int dif = Check(number);

int Check(int number)
{
    int dif = number % 7;
    int dif2 = number % 23;
    if(dif == 0& dif2 == 0)
    {
        Console.WriteLine("Кратно двум числам 7 и 23");
    }
    else
    {
        Console.WriteLine("Не кратно двум числам 7 и 23");
    }
    return dif;
}
