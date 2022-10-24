// Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
// выполнять задание не используя string.

Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
Search(number);

void Search(int ert)
{
    if (ert > 99)
    {
        int count = -3;
        int last = ert;

        while (last > 0)
        {
            last = last / 10;
            count = count + 1;
        }

        int magic = 1;

        while(count > 0)
        {
            magic = magic * 10;
            count = count - 1;
        }

        ert = ert / magic % 10;
        
        Console.WriteLine($"Третья цифра заданного числа: {ert}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
