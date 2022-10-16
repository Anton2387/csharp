int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

int square = numberA / (numberB * numberB);

if (square == 1)
{
    Console.WriteLine("Первое число, является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число, не является квадратом второго числа");
}