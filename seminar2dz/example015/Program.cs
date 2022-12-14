// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да 7 -> да 1 -> нет
// сделать это задание в методе. 
//В методе будет находиться логика определения выходной ли день или нет. 
//Метод принимает как параметр число(int) и возвращает bool. 
//В методе не должно быть считывания(ReadLine) и вывода в консоль (WriteLine). 
//Вывод и считывание должно быть в месте где метод вызывается.

Console.WriteLine("Введите цифру, обозначающую день недели");
int number = Convert.ToInt32(Console.ReadLine());

if(DayOfWeek(number))
{
    Console.WriteLine("Сегодня выходной день");
}
else
{
    Console.WriteLine("Сегодня будний день");
}

bool DayOfWeek(int number)
{
    return number == 6 | number == 7;
}
