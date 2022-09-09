// теперь задачу по нахождению максимума запишем в представлении массива
int Max(int arg1, int arg2, int arg3) //определяем функцию
 {
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
   return result;
 }
  //             0   1   2   3   4   5   6   7   8    нумерация элементов массива (индексы)
int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 }; // определили массив из 9 элементов
array [0] = 12; // присвоили 0 элементу массива вместо 11 число 12
Console.WriteLine(array[4]); // вывести 4 элемент на экран
int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8])); 
Console.WriteLine(max);