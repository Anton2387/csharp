Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int N = 2;

while(N <= number)
{
    Console.Write(N);
    Console.Write(",");
    N = N + 2;
}