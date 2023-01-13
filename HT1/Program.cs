// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.Clear();
// Console.Write("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
//   Console.Write($"Большее число равно {a}, меньшее число {b} ");
// else if (a < b)
//   Console.Write($"Большее число равно {b}, меньшее число {a} ");
// else
//   Console.Write($"Вы ввели равные числа");


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.Clear();
// Console.Write("Введите 1-е число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-e число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 3-e число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (a == b || b == c)
//   Console.Write($"Вы ввели равные числа");
// else
// {
// if (b > max)
//   max = b;
// if (c > max)
//   max = c;
// Console.Write($"Максимальное число равно {max}");
// }


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.Clear();
// Console.Write("Введите целое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a%2 == 0)
//   Console.Write("Вы ввели четное число");
// else
//   Console.Write("Вы ввели нечетное число");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (n > 1)
{
  while (count <= n)
  {
    Console.Write($"{count} ");
    count = count + 2;
  }
}
else
Console.Write($"Положительные четные числа в ряде от 1 до введенного числа отсуствуют");