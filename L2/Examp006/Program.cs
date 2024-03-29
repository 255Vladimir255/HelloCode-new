﻿// Теперь попробуем адаптировать решение предыдущей задачи, в которой находили нужные элементы и позицию нужного элемента в массиве.

void FillArray(int[] collection) // Далее дадим наименование нашему методу FillArray, В качестве аргумента будет приниматься какая-то коллекция, то есть аргумент collection.
{
  int length = collection.Length; // получаем длину нашего массива
  int index = 0; //
  while (index < length)
  {
    collection[index] = new Random().Next(1, 10); //После этого обратимся к аргументу collection на позицию index и положим туда новое случайное число — целое число из диапазона 1–10.
    index++;
  }
}

void PrintArray(int[] col) //Теперь сделаем метод void, который будет печатать массив. Аналогичным образом в качестве аргумента здесь будет приходить массив. Обратите внимание, что здесь мы специально не
                            //даём одинаковые имена, чтобы привыкнуть называть разные аргументы различными именами.
{
    int count = col.Length; // Количество элементов
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) //  возвращает позицию, то есть index. Назовём этот метод IndexOf, а в качестве аргумента будет приходить массив
                                        //  collection и какой-то элемент find.
{
    int count = collection.Length; // определяем количество элементов
    int index = 0;
    int position = 0;          // если поискать элемент, которого точно не существует, например, элемент 444, и запустить этот код, выйдет позиция 0.
                               //Но если не встречается ни одного элемента, то договоримся, что по умолчанию станет возвращаться значение -1. Это
                               //искусственный приём. То есть, если элемента нет, значит, выйдет -1.
    while (index < count)
         {
            if(collection[index] == find)
             {
                position = index; // Чтобы найденную позицию куда-то сохранить, определим новую переменную position
                break;            //Посмотрим, как изменить код, чтобы получать 1 вхождение. Всё очень просто — через добавление оператора break прерывает поиск на первом найденном
             }
        index++;   
         }
     return position;

}

int[] array = new int [10]; // определили массив array конструкцию new int[10], которая дословно означает «создай новый массив, где будет 10 элементов». По
                          //умолчанию. Кстати, он будет наполнен нулями. Чтобы заполнить массив случайными числами,воспользуемся методом, который опишем сами:

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);