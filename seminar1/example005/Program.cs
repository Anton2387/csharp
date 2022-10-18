Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());

int N = -number;

while(N <= number)
{
    Console.Write(N);
    Console.Write(",");
    N = N + 1;
}