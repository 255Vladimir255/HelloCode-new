// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


Console.Write("Введите длину массива: ");
int lenghtArr = int.Parse(Console.ReadLine()!);
int[] randomArr = new int[lenghtArr];
for (int i = 0; i < randomArr.Length; i++)
{
    randomArr[i] = new Random().Next(0, 2);  // выставляется набор случайных чисел в диапазоне от 0 до 1
    Console.Write($"{randomArr[i]}");
    if (i < randomArr [0])
    {
        Console.Write("["); // не понимаю как поставить квадратную скобку перед 0 индексом массива
    } 
    if (i < randomArr.Length - 1)
    {
        Console.Write(",");
    }
    else
    {
        Console.Write("]");
    }
   
}
