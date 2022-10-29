/*Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/

int number = Convert.ToInt32(Console.ReadLine());

string CoordinateRange = DetermineCoordinateRange(number);
Console.WriteLine(CoordinateRange);

string DetermineCoordinateRange(int number)
{
    if(number == 1)
    {
        return "x>0 y>0";
    }
    
    if(number == 2)
    {
        return "x>0 y<0";
    }

    if(number == 3)
    {
        return "x<0 y<0";
    }
    
    if(number == 4)
    {
        return "x<0 y>0";
    }
    
    else
    {
        return "Ошибка! Не правильно задана четверть";
    }
}