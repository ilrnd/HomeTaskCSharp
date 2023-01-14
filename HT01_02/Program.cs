//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
  Console.Write($"Большее число равно {a}, меньшее число {b} ");
else if (a < b)
  Console.Write($"Большее число равно {b}, меньшее число {a} ");
else
  Console.Write($"Вы ввели равные числа");