void TriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
{
  double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
  double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
  double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
  double p = (a + b + c) / 2;
  double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
  Console.Write($"Площадь треугольника равна = {Math.Round(area,2)}");
}
Console.Clear();
Console.Write("Введите координату X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());
TriangleArea(x1, y1, x2, y2, x3, y3);