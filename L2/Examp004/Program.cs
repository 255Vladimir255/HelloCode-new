﻿// имеется одномерный масси array из n элементов, требуется найти элемент массива равный find
// 1. установить счетчик index в позицию 0
// 2. если array [index] = find? алгоритм завершил работу
// 3. увеличить index на 1
// 4. если , то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.

int[] array = { 1, 12, 31, 4, 18, 16, 17, 18 }; 

int n = array.Length;  // возвращяет длину или колличества элементов массива
int find = 18;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // прерывает поиск на первом искомом элементе если есть одинаковые значения на разных индексах
    }
    index++; // index = index +1

}