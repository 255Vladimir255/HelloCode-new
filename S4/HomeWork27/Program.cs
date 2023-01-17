// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int SumDigitsNumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
       sum = sum +number % 10;
       number /= 10;
    }
    return sum;
}

Console.Write("Введите число  ");
int num = int.Parse(Console.ReadLine()!);
SumDigitsNumber(num);
Console.Write($"сумма цифр в числе {num} равна {SumDigitsNumber(num)}");