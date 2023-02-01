// Напишите программу, которая Принимает на вход число N и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

int Product1ToN(int number)
{
    int product = 1;
    for (int i = 1; i <= number; i++)
    {
        product = product * i; // product *= i;
    }
    return product;
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write(Product1ToN(number));