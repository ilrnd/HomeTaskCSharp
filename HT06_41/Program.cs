﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
void CalcNum(int m)
{
  int n = 0;
  int count = 0;
  for (int i = 1; i <= m; i++)
  {
    Console.Write($"Введите число {i}: ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n == 0)
    count++;
  }
  Console.Write($"\nКоличество чисел равных 0: {count} ");
}
Console.Write($"Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
CalcNum(n);
