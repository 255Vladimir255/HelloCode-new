// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// например
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("введите первое число");
double num1 = Convert.ToDouble(Console.ReadLine());   //Convert.ToInt32() (преобразует к типу int), Convert.ToDouble() (преобразует к типу double),
                                                      //Convert.ToDecimal() (преобразует к типу decimal)
Console.WriteLine("введите второе число");
double num2 = Convert.ToDouble(Console.ReadLine());
if (num1 > num2) 
{
Console.Write("первое число  больше второго ");
Console.Write(num1);
}
    else
    {
Console.Write("второе число больше первого ");
Console.Write(num2);

    }