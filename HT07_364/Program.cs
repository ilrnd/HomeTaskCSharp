// Задача №364 Заполнение диагоналями
void ReleaseMatrix(int[,] matrix)
{
  int start = 0;
  for (int k = 0; k <=  matrix.GetLength(0) + matrix.GetLength(1); k++)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        if (i + j == k)
        {
          matrix[i, j] = start;
          start++;
        }
      }
    }
  }
}
void ScreenMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}

Console.Clear();
Console.Write("Ведите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
ReleaseMatrix(matrix);
ScreenMatrix(matrix);