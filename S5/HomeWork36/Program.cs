// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на чётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int RandomNumbers(int NumbersArray, int min, int max)
  {
  int[] randomNumber = new int[NumbersArray];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumber.Length; i++ ){
      randomNumber[i] = new Random().Next(min, max);

      Console.Write(randomNumber[i] + " ");

      if (i % 2 == 0)
      {
        sumElements = sumElements + randomNumber[i];
      }
    }
  return sumElements;
  }


Console.WriteLine($"Введи длину массива: ");
int NumbersArray = Convert.ToInt32(Console.ReadLine()); 
int randomNumber =  RandomNumbers(NumbersArray, 1, 10);
Console.WriteLine($"  Сумма элементов, стоящих на чётных позициях: {randomNumber}");
