﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a%2 == 0)
  Console.Write("Вы ввели четное число");
else
  Console.Write("Вы ввели нечетное число");