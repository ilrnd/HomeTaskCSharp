﻿//Задана последовательность натуральных чисел, завершающаяся числом 0. Требуется определить значение второго по величине 
// элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.
Console.Clear();
Console.WriteLine("Введите последовательность чисел: ");
int n = -1; // любое число меньше нуля
int max1 = n;
int max2 = n;
while (n != 0)
{
  Console.Write($"");
  n = Convert.ToInt32(Console.ReadLine());
  if (n > max1)
  {
    max2 = max1;
    max1 = n;
  }
  else if (n > max2)
    max2 = n;
}
  Console.WriteLine($"Второе максимальное число = {max2}");