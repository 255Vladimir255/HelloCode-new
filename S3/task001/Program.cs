﻿// напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y)


void PrintCoordinateRange(int number) // пропишем функцию которая будет выводить на печать номер четверти плоскости
{
    if (number == 1)
    {
        Console.WriteLine("диапазон возможных координат точек в этой четверти равен  (x > 0 и у > 0) ");
    }
    else if (number == 2)
    {
        Console.WriteLine("диапазон возможных координат точек в этой четверти равен  (x < 0 и у > 0) "); ;
    }
    else if (number == 3)
    {
        Console.WriteLine("диапазон возможных координат точек в этой четверти равен  (x < 0 и у < 0) ");
    }
    else if (number == 4)
    {
        Console.WriteLine("диапазон возможных координат точек в этой четверти равен  (x > 0 и у > 0) ");
    }
    else
    {

        Console.Write(" вы не ввели номера четвертей плоскостей от 1 до 4, повторите ввод");
    }
}
Console.Write("номер четверти ");
int num = int.Parse(Console.ReadLine()!);
PrintCoordinateRange(num);