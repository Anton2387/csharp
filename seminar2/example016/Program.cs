Console.WriteLine("Введите два любых числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
bool plc = check(number1, number2);

bool check (int number1, int number2)
{
    int dif = number1 * number1;
    int dif2 = number2 * number2;
    
    return dif == number2 | dif2 == number1;
}

if(plc)
{
    Console.WriteLine("Одно из чисел является квадратом другого числа");
}
else
{
    Console.WriteLine("Не я вляется квадратом другого числа");
}