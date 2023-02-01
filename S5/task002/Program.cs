// задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве
// 4; [6, 7, 19, 345, -3] -> нет
// -3; [6, 7, 19, 345, -3] -> да

int[] CreateArray(int Length, int minValue = 0, int maxValue = 100)
{
    int[] array = new int[Length];
    var rnd = new Random();  // создаем переменную rnd 
    for (int i = 0; i < array.Length; i++)
    {

        array[i] = rnd.Next(minValue, maxValue + 1);    // возвращает рандомное число в диапазоне от -10 до 10 +1 добавил для диапазона -10, 11
    }
    return array;
}

int FindElemWithAppropriate(int[] array, int searchnumber)
{
    int lenght = array.Length;

    for (int i = 0; i < lenght; i++)
    {
        if (array[i] == searchnumber)      // сравниваем каждый элемент массива с искомымым числом
        {
            return i;
        }
    }
    return -1;
}
// int index = Array.Indexof(array, searchnumber); можно найти искомый элемент через эту команду
string PrintArray(int[] array)
{
    string outputSrt = String.Empty;
    outputSrt = string.Join(" ", array);
    return outputSrt;
}
Console.Write("Введите число элементов в массиве: ");
int lenght = int.Parse(Console.ReadLine()!);
int[] arr = CreateArray(lenght, -9, 9);
Console.WriteLine(PrintArray(arr));
Console.Write("Введите число, которое мы хотим найти в массиве: ");
int searchnumber = int.Parse(Console.ReadLine()!);
int index = FindElemWithAppropriate(arr, searchnumber);

Console.WriteLine($"Индекс элемента {searchnumber} в массиве: {index}");