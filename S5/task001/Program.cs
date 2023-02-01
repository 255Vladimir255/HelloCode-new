// Напишите программу замены элементов массива: положительные элементы замените на соответствующие орицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void ReplaceElemWithAppropriate(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        int temp = array[i];
        if (temp != 0)      // проще каждый элемент домножать на -1
        {
            array[i] = -temp;
        }
        else
        {
            continue;
        }
    }
}

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
ReplaceElemWithAppropriate(arr);
Console.WriteLine(PrintArray(arr));
