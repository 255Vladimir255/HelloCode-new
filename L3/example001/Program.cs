// Работа с циклом for

//string Method4(int count, string text)
//{
//   int i = 0;
//   string result = String.Empty; // String.Empty обозначение пустой строки или " "
//
//  while (i < count)
//  {
//     result = result + text;
//     i++;
// }
//  return result;
//}

//string res = Method4(10, "asdf");
//Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty; // String.Empty обозначение пустой строки или " "
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);