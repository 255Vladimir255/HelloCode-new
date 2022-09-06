// Напишите программу, которая на вход принимает два 
//числа и проверяет, является ли первое число квадратом второго.
//например:
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

Console.WriteLine("введите первое число");
double num1 = Convert.ToDouble(Console.ReadLine());   //Convert.ToInt32() (преобразует к типу int), Convert.ToDouble() (преобразует к типу double),
                                                      //Convert.ToDecimal() (преобразует к типу decimal)
Console.WriteLine("введите второе число");
double num2 = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt(num1);
if (result == +- num2) // ковырялся забыл поставить значение равенства ==, вместо = присвоить)))
{
Console.Write("первое число  является квадратом второго ");
}
    else
    {
Console.Write("первое число  не является квадратом второго ");
    }