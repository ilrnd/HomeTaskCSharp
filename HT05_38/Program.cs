// Задача 38: Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.57, 7.96, 22.47, 2.12, 78.73] -> 76.61
void FillArray(double[] array)
{
  Random x = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Convert.ToDouble(x.Next(1, 10000) / 100.00);
  }
}
void ReleaseArray(double[] array)
{
  double dif = 0;
  double max = array[0];
  double min = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] > max)
      max = array[i];
    if (array[i] < min)
      min = array [i];
  }
  dif = max - min;
  Console.WriteLine($"Разница максимального элемента {max} и минимального элемента {min} = {Math.Round(dif,2)}");
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
FillArray(array);
Console.WriteLine($"Начальный массив: [{string.Join("; ", array)}]");
ReleaseArray(array);