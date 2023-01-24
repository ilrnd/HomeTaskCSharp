// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow(ЗАПРЕЩЕНО)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int st = a;
for (int i = 1; i < b; i++)
{
  st = st*a;
}
Console.WriteLine($"Число {a} в степени {b} = {st}");