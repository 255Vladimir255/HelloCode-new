// Напишите программу, которая принимает на вход координаты точки (Х и У), причем Х и У не равны 0 и выдает
// номер четверти плоскости, в которрой находится эта точка

int GetNumberofQuater(int x, int y) // пропишем функцию которая будет выдавать номер четверти плоскости
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    else if (x < 0 && y > 0)
    {
        return 2;
    }
    else if (x < 0 && y < 0)
    {
        return 3;
    }
    else if (x > 0 && y < 0)
    {
        return 4;
    }
    else
    {
        return -1;
    }
}
void PrintNumberofQuater(int x, int y) // пропишем функцию которая будет выводить на печать номер четверти плоскости
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine($"номер четверти координаты ({x}, {y}) равен {1}");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine($"номер четверти координаты ({x}, {y}) равен {2}");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine($"номер четверти координаты ({x}, {y}) равен {3}");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine($"номер четверти координаты ({x}, {y}) равен {4}");
    }
    else
    {

        Console.Write(" координаты находятся на границах осей");
    }
}
Console.Write("Введите координату Х ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y ");
int y = int.Parse(Console.ReadLine()!);
int numberofQuater = GetNumberofQuater(x, y);
if (numberofQuater == -1)
{
    Console.Write("координаты находятся на границах осей");
}
else
{
    Console.WriteLine($"координаты находятся в {numberofQuater} четверти");
}
PrintNumberofQuater(x, y);


