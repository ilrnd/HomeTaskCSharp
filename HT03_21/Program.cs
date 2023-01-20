//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координату точки А X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки А Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки А Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки B X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки B Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки B Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double l = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2)), 2);
Console.Write($"Расстояние между точками равно = {l}");
