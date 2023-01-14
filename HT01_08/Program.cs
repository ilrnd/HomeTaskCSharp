// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (n >= 2)
{
  while (count <= n)
  {
    Console.Write($"{count} ");
    count = count + 2;
  }
}
else
Console.Write($"Положительные четные числа в ряде от 1 до введенного числа отсуствуют");