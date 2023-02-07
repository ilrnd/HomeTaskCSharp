// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void FillMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 11);
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

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
  int[,] matrixP = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
  for (int i = 0; i < matrixP.GetLength(0); i++)
  {
    for (int j = 0; j < matrixP.GetLength(1); j++)
    {
      for (int k = 0; k < matrixP.GetLength(1); k++)
      {
        matrixP[i, j] = matrixP[i, j] + matrix1[i, k] * matrix2[k, j];
      }
    }
  }
  return matrixP;
}

Console.Clear();
Console.Write("Ведите размеры матриц: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size[0], size[1]];
int[,] matrix2 = new int[size[0], size[1]];
FillMatrix(matrix1);
Console.WriteLine("1-я матрица:");
ScreenMatrix(matrix1);
FillMatrix(matrix2);
Console.WriteLine("\n2-я матрица:");
ScreenMatrix(matrix2);
if (size[0] != size[1])
  Console.WriteLine($"\nТакие матрицы умножать нельзя, т.к. количество столбцов 1-й матрицы не равно количеству строк 2-й матрицы");
else
{
  Console.WriteLine($"\nПроизведение матриц:");
  ScreenMatrix(ProductMatrix(matrix1, matrix2));
}