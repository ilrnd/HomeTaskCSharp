void FillMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 11);
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}

void ReleaseMatrix(int[,] matrix)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      sum += matrix[i, j];
    }
  double average = sum / matrix.GetLength(0);
  Console.WriteLine($"Среднее число столбца {j}: {sum} / {matrix.GetLength(0)} = {Math.Round(average, 1)}");
  }
}

Console.Clear();
Console.Write("Ведите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
FillMatrix(matrix);
ReleaseMatrix(matrix);