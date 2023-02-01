// Напишите программу которая принимает на вход число (A) b выдает сумму чисел от 1 до А
// 7->28
//4->10
//8->36

int SumFrom1toA(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}

// если перевести через формулу арифмитической прогресси summ n=n*(n+1)/2
int FastSumFrom1ToA(int a)
{
    return a * (a + 1) / 2;
}

Console.WriteLine(SumFrom1toA(4));
Console.WriteLine(FastSumFrom1ToA(4));

