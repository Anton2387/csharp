Console.WriteLine("Введите два числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if( numberA == numberB)
{
    Console.WriteLine("числа равны");
}

if( numberA < numberB )
{
    Console.Write("max = ");
    Console.Write(numberB);
}
else
{
    Console.Write("max = ");
    Console.Write(numberA);
}
