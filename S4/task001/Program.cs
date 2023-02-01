// напишите программу которая принимает на вход число и выдает количество цифр в числе
//456 -> 3
//78 -> 2
// 89126 -> 5


//Console.Write("Введите число А: ");
//int A = Convert.ToInt32(Console.ReadLine());
//int count = 0; //количество цифр в числе

//while (A > 0)
//{
// A /= 10; // A = A/10
// count++;
//}
//Console.WriteLine($"Количество цифр в числе = {count}");
// или как вариант перевод числа в строчный массив 

int SumCount(int count)
{
string str = count.ToString();
int lenght = str.Length;
return lenght;
}
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр в числе {SumCount (num)}");


