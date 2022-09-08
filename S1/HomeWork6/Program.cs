//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//например:
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("введите  число");
double num = Convert.ToDouble(Console.ReadLine());   

if (num % 2 == 0) 
{
         Console.Write(num);
         Console.Write("  - число является четным ");
       
}
    else
    {
        Console.Write(num);
        Console.Write("  - число не является нечетным ");

    }