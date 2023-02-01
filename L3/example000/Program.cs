// Вид 1 функций
void Method1() // нет аргументов
{
    Console.WriteLine("Автор ....."); // просто выводит
}
// Method1(); // вызов метода

// Вид 2 функций
void Method2(string msg) // с аргументами
{
    Console.WriteLine(msg); // просто выводит
}
//Method2(msg: "Текст сообщения"); // вызов метода вызов именнованого аргумента msg  со значением ЖЖ Текст сообщения

void Method21(string msg, int count) // с аргументами
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg); // просто выводит 
        i++; // увеличение на 1 счетчика называется инкрементирование, уменьшение деинкрементирование  
    }
}
//Method21("Текст", 4); // вызов метода вывод "Текст" 4 раза
//Method21(count: 4, msg: "Текст"); // вызов метода явно указываем какому аргументу какое значение, можно в скобках писать не по порядку аргументы

//Вид 3 функций
int Method3()  // необходимо указать тип данных значение которого мы ожидаем аргументы не принимает
{
    return DateTime.Now.Year; // возвращение текущего года
}
//int year = Method3(); // идентификатор переменной и заложить ей нужное значение из функции
//Console.WriteLine(year);

//Вид 4 функций 
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // String.Empty обозначение пустой строки или " "

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);