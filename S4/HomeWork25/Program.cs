// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int NaturDegr(int A, int B)
{
    
    int res = 1;
    for (int i = 0; i < B; i++)
    {
        res = res * A;
    }
    return res;
}
Console.Write("Введите число А ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число В ");
int B = int.Parse(Console.ReadLine()!);
NaturDegr(A, B);
Console.Write($"число A в степени B = {NaturDegr(A, B)}");