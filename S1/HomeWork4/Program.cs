// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//например:
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("введите первое число");
double num1 = Convert.ToDouble(Console.ReadLine());   
Console.WriteLine("введите второе число");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите третье число");
double num3 = Convert.ToDouble(Console.ReadLine());
double max = num1;
if (num2 > max) 
{
        max = num2;
        if (num3 > max)
        {
        max = num3;
        Console.Write("маскимальное число равно ");
        Console.Write(num3);
        }
          else
          {
            Console.Write("маскимальное число равно ");
            Console.Write(num2);
          }
}
    else
    {
        if (num3 > max)
        {
        max = num3;
        Console.Write("маскимальное число равно ");
        Console.Write(num3);
        }
          else
          {
            Console.Write("маскимальное число равно ");
            Console.Write(num1);
          }

    }