﻿// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 10000 || n > 99999)
{
    Console.WriteLine("Вы ошиблись! Введите пятизначное число заново!");
    Console.Write("Введите пятизначное число ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n % 10 == n / 10000 && n / 10 % 10 == n / 1000 % 10)
  Console.WriteLine("Введенное число является палиндромом");
else
  Console.WriteLine("Введенное число НЕ является палиндромом");