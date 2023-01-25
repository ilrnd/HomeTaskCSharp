// Суперсдвиг

Console.Clear();
Console.Write("Введите количество элементов массива N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.Write("Введите число сдвига K: ");
int k = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < n; i++)
{
  array[i] = new Random().Next(1, 51); // 1...50
}
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");

if (k > 0)
{
  for (int i = 1; i < k; i++)
  {
    for (int j = 1; j < n; j++)
    {
      int temp = array[j];
      array[j] = array[j - 1];
      array[j - 1] = temp;
    }
  }
}
if (k < 0)
{
  for (int i = 1; i <= -k; i++)
  {
    for (int j = 0; j < n-1; j++)
    {
      int temp = array [j];
      array[j] = array[j + 1];
      array[j + 1] = temp;
    }
  }

}
Console.WriteLine($"Сдвиг: [{string.Join(", ", array)}]");

