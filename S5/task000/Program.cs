// задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
//отрицательных и положительных элементов массива.
// например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных чисел равна -20.

int[] CreateArray(int Length, int minValue = 0, int maxValue = 100)// функция создания массива// значение по умолчанию int minValue = 0 и int maxValue = 100 соответственно по умолчанию, 
                                                                   //но через вызов функции назначая эти функции можно задать любое значение
                                                                   // больше трех элементов по умолчанию в функцию передать нельзя !!!!!!!
/*{
    int[] array = new int[Length];
    var rnd = new Random();  // создаем переменную rnd 
    for (int i = 0; i < array.Length; i++)
    {
       
        array[i] = rnd.Next(-10, 11);    // возвращает рандомное число в диапазоне от -10 до 10
    }
}
*/ //этот метод плох тем что стронний разработчик вынужден заходить в функцию и искать этот диапазон rnd.Next(-10, 11)
{
    int[] array = new int[Length];
    var rnd = new Random();  // создаем переменную rnd 
    for (int i = 0; i < array.Length; i++)
    {

        array[i] = rnd.Next(minValue, maxValue + 1);    // возвращает рандомное число в диапазоне от -10 до 10 +1 добавил для диапазона -10, 11
    }
    return array;
}
void PrintArray(int[] array) //функция печати массива
{
    Console.WriteLine("[" + string.Join(", ", array) + "]"); // эта функция аналогична for (int i = 0; i < array.Lenght; i++)
                                                             // {
                                                             //  Console.Write(array[i] + " ");
                                                             // }
                                                             // Console.WriteLine(array[i] + " ")

}
/*
// функция подсчета положительных чисел
int SumPositivNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
//функция подсчета отрицательных чисел
int SumNegativNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
//int[] array1 = CreateArray(12);
int[] array = CreateArray(12, -9, 9);
//PrintArray(array1);
*/
// можно упростить функции подсчета сумм выше
int SumSignedNumbers(int[] array, bool possitive = true) //  если мы вызываем функцию и не передаем аргумент bool possitive = true
                                                         // то функция считает положительную сумму если передадим bool possitive = false
                                                         // то будет считать сумму отрицательных чисел
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] > 0 && possitive) || (array[i] < 0 && !possitive)) // можно обьеденить ищем положительное и суммируем или (||) ищем отрицательное и суммируем
        {
            sum += array[i];
        }
        // else if (array[i] < 0 && !possitive) // !possitive  не позитив
        // {
        //     sum += array[i];
        // }
    }
    return sum;

// в таком пробеге очень длинное решение
/*   if (possitive) 
   {
       for (int i = 0; i < array.Length; i++)
       {
           if (array[i] > 0)
           {
               sum += array[i];
           }
       }
   }
   {
       else
       {
           for (int i = 0; i < array.Length; i++)
           {
               if (array[i] < 0)
               {
                   sum += array[i];
               }
           }
       }
   }

   return sum;
}*/
}
int[] array = CreateArray(12, -9, 9);
PrintArray(array);
//Console.WriteLine("Сумма положительных чисел в массиве " + SumSignedNumbers(array));
//Console.WriteLine("Сумма положительных чисел в массиве " + SumSignedNumbers(array));
SumSignedNumbers(array);
SumSignedNumbers(array, false);
Console.WriteLine("Сумма положительных чисел в массиве " + SumSignedNumbers(array));
Console.WriteLine("Сумма положительных чисел в массиве " + SumSignedNumbers(array, false));