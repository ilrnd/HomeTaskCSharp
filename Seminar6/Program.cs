// // Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// // [1 2 3 4 5] -> [5 4 3 2 1]
// // [6 7 3 6] -> [6 3 7 6]

// void FillArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 101); // [0, 100]
// }

// void ReleaseArray(int[] array)
// {
//   int temp = 0;
//   for (int i = 0; i < array.Length / 2; i++)
//   {
//     temp = array[array.Length - i - 1];
//     array[array.Length - i - 1] = array[i];
//     array[i] = temp;
//   }
//   Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
// }

// Console.Clear();
// Console.Write("Введите количество элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// FillArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);

// // Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// // Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
//  string Triangle (int a, int  b, int c)
// {
//   bool flag = false;
//   if (a < b + c && b < a + c && c < a + b)
//   flag = true;
//   if (flag)
//   return "YES";
//   else
//   return "NO";
// }
// Console.Clear();
// Console.Write("Введите 1-ю сторону треугольника: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ю сторону треугольника: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ю сторону треугольника: ");
// int c = Convert.ToInt32(Console.ReadLine());
// string proverka = Triangle(a, b, c);
// Console.WriteLine(proverka);

// // Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// void System2 (int n)
// {
//   string result = string.Empty;
//   while (n  > 0)
//   {
//     result = Convert.ToString(n % 2)+ result;
//     n = n / 2;
//   }
//   Console.WriteLine(result);
// }
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System2(n);

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a0 = 0, a1 = 1, x;
// for (int i = 0; i < n; i++)
// {
//   Console.Write($"{a0} ");
//   x = a0 + a1;
//   a0 = a1;
//   a1 = x;
// }

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] a = {1, 2, 3, 4, 5};
int[] b = new int[a.Length];

for (int i = 0; i < a.Length; i++)
  b[i] = a[i];

b[0] = 100;
Console.WriteLine(string.Join(" ", a));
Console.WriteLine(string.Join(" ", b));