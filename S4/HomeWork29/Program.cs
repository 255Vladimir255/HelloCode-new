// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


Console.Write("Введите длину массива: ");
int lenghtArr = int.Parse(Console.ReadLine()!);
int[] randomArr = new int[lenghtArr];
for (int i = 0; i < randomArr.Length; i++)
{
    randomArr[i] = new Random().Next(0, 2);
    Console.Write(randomArr[i] + " ");
}