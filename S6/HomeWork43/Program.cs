// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



up:

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 > k2 | k1 < k2)
{
    double x = 0;
    double y = 0;
    x = (-b2 + b1) / (-k1 + k2);
    y = k2 * x + b2;
    Console.WriteLine($"точка пересечения двух прямых имеет координаты X: {x}, Y: {y}");
}
else
{
    Console.WriteLine("Значение k1 и k2 не должно быть равным повторите ввод");
    goto up;
}
