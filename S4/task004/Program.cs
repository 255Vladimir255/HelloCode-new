// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

//double[] array = {new Random().NextDouble(1,9)};
//Console.WriteLine(array);

int[] CreatArray(int count)
{
    return new int[count];
}

void FillArray(int[] array)
{
    int lenght = array.Length;
    int index = 0;

    while (index < lenght)
    {
        Random rmd = new Random();
        int currentValue = rmd.Next(0, 2);
        array[index] = currentValue;
        index = index +1;

    }
}

string PrintArray(int[] array)
{
    string outputSrt = String.Empty;
    outputSrt = string.Join(" ", array);
    return outputSrt;

/*
int Lenght = array.Lenght;
int index = 0;
while (index < lenght)
{
    int currentValue = array[index];
    outputSrt = outputSrt + $"{currentValue} ";
    index += 1;
}
return outputSrt;
*/
}
Console.Write("Введите число элементов в массиве: ");
int count = int.Parse(Console.ReadLine()!);
int[] arr = CreatArray(count);
FillArray(arr);
Console.Write(PrintArray(arr));