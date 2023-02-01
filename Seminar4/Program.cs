//String (char)
// Console.Clear();
// string? stroka = Console.ReadLine();
// Console.WriteLine(Convert.ToInt32(stroka[0].ToString())*10);

// Console.Clear();
// Console.Write("Введите количество элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[n];
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(-10, 11); // -10...11
// }
// Console.WriteLine($"Результат: [{string.Join(", ", array)}]");

// Function (void)

// void f(int[] n)
// {
//   n[0] = n[0] + 5;
// }

// int [] n = {1, 2, 3, 4, 5};
// f(n);
// Console.WriteLine(String.Join(" ", n));



// Напишите программу, которая принимает 2 числа и выводит наибольшее
// Console.Clear();
// int f(int a, int b)
// {
//   if (a > b)
//     return(a);
//   return(b);
// }
// int a = 10, b = 7;
// int result = f(a, b);
// Console.WriteLine(result);

// Задача 24 Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.Clear();
// Console.Write("Введите число: ");
// double n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат: {(1 + n) / 2 * n}");

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (n / 10 > 0)
// {
//   count++;
//   n = n / 10;
// }
// Console.WriteLine(count);

// //Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int f = 1;
// for(int i = 1; i <= n; i++)
// {
//  f = f*i;
// }
// Console.WriteLine(f);

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// Console.Clear();
// int [] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(0, 2);
// }
// Console.WriteLine($"Результат: [{string.Join(", ", array)}]");

Console.Clear();
int [] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Результат: [{string.Join(", ", array)}]");
