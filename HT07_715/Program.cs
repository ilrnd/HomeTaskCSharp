// ЗАДАЧА №715	Миша и негатив
void FillMatrix(char[,] matrix)
{
  Random rand = new Random();
  char[] letters = { 'B', 'W' };
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = letters[rand.Next(0, letters.Count())];
    }
  }
}

void ScreenMatrix(char[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]}");
    }
    Console.WriteLine();
  }
}

int CheckProgramm(char[,] matrix1, char[,] matrix2)
{
  int count = 0;
  for (int i = 0; i < matrix1.GetLength(0); i++)
  {
    for (int j = 0; j < matrix1.GetLongLength(1); j++)
    {
      if (matrix1[i, j] == matrix2[i, j])
      {
        count++;
      }
    }
  }
  return count;
}

Console.Clear();
Console.Write("Ведите размеры изображения: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
char[,] matrix1 = new char[size[0], size[1]];
FillMatrix(matrix1);
ScreenMatrix(matrix1);
Console.WriteLine();
char[,] matrix2 = new char[size[0], size[1]];
FillMatrix(matrix2);
ScreenMatrix(matrix2);
Console.WriteLine($"\nКоличество ошибок в программе равно: {CheckProgramm(matrix1, matrix2)}");