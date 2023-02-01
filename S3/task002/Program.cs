// напишите прграмму, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// А(3,6); В(2,1) -> 5,09
// А(7,-5); В(1,-1) -> 7,21

void LengthSegment(double x1, double y1, double x2, double y2) // пропишем функцию для вычисления расстояния между точками
{
    Console.WriteLine($"отрезок равен {Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))}"); //:f2 добавив это значение выражение округлим до 2 знаков после запятой
}

Console.Write("Введите координату х1 точки А ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату y1 точки А ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату x2 точки В ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату y2 точки В ");
double y2 = double.Parse(Console.ReadLine()!);

LengthSegment(x1, y1, x2, y2);



