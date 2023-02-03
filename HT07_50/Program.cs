// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет
void FillMatrix(int[ , ] matrix)
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

Console.Clear();
Console.Write("Ведите размеры массива: ");
int [] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[ , ] matrix = new int[size[0], size[1]];
FillMatrix(matrix);
Console.WriteLine();
Console.Write("Ведите искомый элемент через пробел: ");
int [] find = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
if (find[0] >= 0 && find[0] < matrix.GetLength(0) && find[1] >=0 && find[1] < matrix.GetLength(0))
  Console.WriteLine($"Искомый элемент массива  [{find[0]}, {find[1]}] равен: {matrix[find[0], find[1]]}");
else
  Console.WriteLine($"Элемента с параметрами [{find[0]}, {find[1]}] не существует");


