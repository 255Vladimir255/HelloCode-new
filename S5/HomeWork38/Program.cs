// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void FillArrayRandomNumbers(double[] array, double min, double max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next((int)min, (int)max));
    }
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int size = ReadInt("Введите размерность массива: ");
double min = ReadInt("Введите минимальное число массива: ");
double max = ReadInt("Введите максимальное число массива: ");
double[] numbers = new double[size];

FillArrayRandomNumbers(numbers, min, max);
PrintArray(numbers);

double minnum = Int32.MaxValue;
double maxnum = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxnum)
    {
        maxnum = numbers[i];
    }
    if (numbers[i] < minnum)
    {
        minnum = numbers[i];
    }
}

Console.WriteLine($"Всего в массиве {numbers.Length} чисел. Максимальное = {maxnum}, Минимальное = {minnum}");
Console.WriteLine($"Разность между максимальным и минимальным = {maxnum - minnum}");
