﻿// алгоритмсортировки методом выбора, ещё его называют алгоритм сортировки методом минимакса или
//иногда просто называют методом максимального, или выбора максимального или выбора минимального и так далее.
//Есть какая-то последовательность чисел. Наша задача — выбрать самый первый элемент и в оставшейся
//части, с учётом нашей текущей позиции определить минимальный. После того как он найден,
//нужно поменять выделенный (рабочий элемент), это6, с единицей, являющейся для нас минимальной, в общем, выделенном куске.
//Было:      6 8 3 2 1 4 5 7
//Стало:     1 8 3 2 6 4 5 7
//Поменяли. Дальше у нас следующий шаг, который будет выбирать очередной рабочий элемент для нас. 
//Это теперь 8. Мы явно указываем то, что 1 уже отсортированы к ней больше касаться не нужно. 
//Дальше наша задача во всём неотсортированном кусочке выбрать снова минимальный. Поменять его местами с рабочим.
//Было:      1 8 3 2 6 4 5 7
//Стало:     1 2 3 8 6 4 5 7
//Результат: 1 2 3 4 5 6 7 8  и так далее до результата

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;  //На следующем этапе мы определяем позицию, на которую смотрим. Назовём её minPosition
        for (int j = i + 1; j < array.Length; j++) //В этом блоке кода всё, что мы делаем — это ищем минимальный элемент. Чтобы это сделать,
                                                   //мы смотрим текущий, если он меньше того элемента, который мы предполагали на
                                                   //минимальной позиции, то нужно сохранить текущую позицию. Этот блок кода ищет максимальный элемент и здесь производится swap.
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i]; //после того, как мы выполним, какой-то блок кода, пока что его оставлю пустым, нам потребуется поменять значение нашей
                                  //минимальной позиции, с найденной нами позицией
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PtintArray(arr);
SelectionSort(arr);
PtintArray(arr);
