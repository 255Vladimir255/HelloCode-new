//Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.
// 11 -> 2, 3, 5 , 7, 11


Console.Write("Введите число: ");
int lenghtArr = int.Parse(Console.ReadLine()!);
int[] randomArr = new int[lenghtArr];
for (int i = 0; i < randomArr.Length; i++)
{
    randomArr[i] = new Random().Next(0, 2);  // выставляется набор случайных чисел в диапазоне от 0 до 1
    Console.Write(randomArr[i] + " ");
}