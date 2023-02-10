// // необходимо возвести число а в степень b
// string f(int n)
// {
//   if (n == 1)
//     return "1";
// return f(n - 1) + $", {n}";
// }

// Console.Clear();
// Console.Write("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// string f(int n, int m)
// {
//   if (n == m)
//     return Convert.ToString(m);
// return f(n - 1, m) + $", {n}";
// }

// Console.Clear();
// Console.Write("Введите число M:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n, m));

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// int f(int n)
// {
//   if (n == 0) return 0;
//   return n % 10 + f(n / 10);
// }


// Console.Clear();
// Console.Write("Введите число N:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));

// ЗАДАЧА №147	
// Последовательностью Фибоначчи называется последовательность чисел a0, a1, ..., an, ..., где
// a0 = 0, a1 = 1, ak = ak-1 + ak-2 (k > 1).
// Требуется найти N-е число Фибоначчи

int f(int n)
{
  if (n == 0) return 0;
  if (n == 1) return 1;
  return f(n - 1) + f(n-2);
}


Console.Clear();
Console.Write("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));