﻿// вывести таблицу умножения на экран


for (int i = 2; i <= 10; i++) // У нас есть цикл for, он очень легко строится. Дальше, мы указываем начальное значение.
                              //Таблица умножения начинается с 2. Затем говорим, что пока счётчик i меньше или равен 10,
                              //надо его увеличивать. После возьмём второй цикл, обратите внимание, что в первом
                              //(внешнем) цикле использовался счётчик i, значит, внутренний будет j, который мы также
                              //будем менять. Например, от 2 до меньше или равен 10. А телом второго цикла мы укажем
                              //непосредственное произведение. Сделать это можно различными способами. Я использую
                              //интерполяцию строк.
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");  // в скобках метод интерполяции строк 
                                                    //Интерполяция позволяет сделать код более читабельным, 
                                                    //а также выполнять логические и математические операции с объектами непосредственно во время форматирования. 
                                                    //Чтобы использовать интерполяцию, достаточно указать перед строкой символ доллара — $
    }
    Console.WriteLine(" ");  // разрыв строк между группами цикла. То есть, выполняется вывод умножения на отдельное число, потом искусственный разрыв строк и вывод умножения на новое число. 
                         //Так получается более красиво. Отдельно умножение на 2, 3, 4 и так далее.
}



