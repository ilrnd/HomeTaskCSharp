// // Задача 17
// Console.Clear();
// Console.Write("Введите координату X: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// double y = Convert.ToDouble(Console.ReadLine());
// while (x == 0 || y == 0)
// {
//     Console.WriteLine("Вы ошиблись! Введите координаты заново!");
//     Console.Write("Введите координату X: ");
//     x = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите координату Y: ");
//     y = Convert.ToDouble(Console.ReadLine());
// }
// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x < 0 && y > 0)
//     Console.WriteLine("II");
// else if (x < 0 && y < 0)
//     Console.WriteLine("III");
// else
//     Console.WriteLine("IV");

//Задача 18
// Console.Clear();
// Console.Write("Введите номер четверти 1-4: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n == 1)
//     Console.WriteLine("X > 0 and y > 0");
// else if (n == 2)
//     Console.WriteLine("x < 0 and y > 0");
// else if (n == 3)
//     Console.WriteLine("x < 0 and y < 0");
// else if (n == 4)
//     Console.WriteLine("x > 0 and y < 0");

//Задача 21
// Console.Clear();
// Console.Write("Введите координату X1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату X2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// double l = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)), 2);
// //double n = sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
// Console.Write($"Расстояние между точками равно = {l}");

// //Задача 22
// Console.Clear();
// Console.Write("Введите число N: ");
// double n = Convert.ToDouble(Console.ReadLine());
// int i = 1;
// while (i <= n)
// {
//     Console.Write($"{Math.Pow(i, 2)} ");
//     i++;
// }
// //Задача 22
// Console.Clear();
// Console.Write("Введите число N: ");
// double n = Convert.ToDouble(Console.ReadLine());
// for (int i = 1; i <=n; i++ )
// {
//     Console.Write($"{Math.Pow(i, 2)} ");
// }
