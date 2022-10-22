int number = GetRandomNumber(100, 1000);
int result = DeleteSecondNumber(number);
Console.WriteLine(number);
Console.WriteLine(result);

int DeleteSecondNumber(int number)
{
    int lastValue = number % 10;
    number = number / 100;
    int result = number * 10 + lastValue;
    return result;
}

int GetRandomNumber(int minValue, int maxValue)
{
    Random random = new Random();
    int randomNumber = random.Next(minValue, maxValue);
    return randomNumber;
}