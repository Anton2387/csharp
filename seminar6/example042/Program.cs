/*Задача 42: Напишите программу, которая будет 
преобразовывать десятичное число в двоичное. 
45 -> 101101
3 -> 11
2 -> 10*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Conversation(number));

int Conversation(int number)
{
    int binaryNumber = 0;
    while (number > 0)
    {
        binaryNumber = binaryNumber + number % 2;
        number = number / 2;
        binaryNumber = binaryNumber * 10;
    }
    binaryNumber = binaryNumber / 10;
    return binaryNumber;
}