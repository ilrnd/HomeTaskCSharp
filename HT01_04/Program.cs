//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-e число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-e число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a == b || b == c)
  Console.Write($"Вы ввели равные числа");
else
{
if (b > max)
  max = b;
if (c > max)
  max = c;
Console.Write($"Максимальное число равно {max}");
}
