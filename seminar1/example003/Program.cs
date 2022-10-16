Console.WriteLine("Введите число от 1 до 7, чтобы узнать какой сегодня день недели");
int number = Convert.ToInt32(Console.ReadLine());
int square = number;

if (square == 1)
{
    Console.WriteLine("Понедельник");
}
if (square == 2)
{
    Console.WriteLine("Вторник");
}
if (square == 3)
{
    Console.WriteLine("Среда");
}
if (square == 4)
{
    Console.WriteLine("Четверг");
}
if (square == 5)
{
    Console.WriteLine("Пятница");
}
if (square == 6)
{
    Console.WriteLine("Суббота");
}
if (square == 7)
{
    Console.WriteLine("Воскресенье");
}