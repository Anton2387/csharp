﻿/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

int [] array = GenerateArray();
PrintArray(array);

int [] GenerateArray()
{
    int [] array = new int [8];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array [i] = random.Next(0, 2);
    }
    return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array [i]} ");
    }
}