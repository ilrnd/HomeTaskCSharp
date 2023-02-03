// void FillMatrix(int[ , ] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = new Random().Next(1, 11);
//       Console.Write($"{matrix[i, j]} \t");
//     }
//     Console.WriteLine();
//   }
// }

// Console.Clear();
// Console.Write("Ведите размеры массива: ");
// int [] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// int[ , ] matrix = new int[size[0], size[1]];
// FillMatrix(matrix);


// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
// void FillMatrix(int[ , ] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = i + j;
//       Console.Write($"{matrix[i, j]} \t");
//     }
//     Console.WriteLine();
//   }
// }

// Console.Clear();
// Console.Write("Ведите размеры массива: ");
// int [] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// int[ , ] matrix = new int[size[0], size[1]];
// FillMatrix(matrix);

// // Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// void FillMatrix(int[ , ] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = new Random().Next(1, 11);
//     }
//   }
// }

// void ScreenMatrix(int [ , ] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       Console.Write($"{matrix[i, j]} \t");
//     }
//   Console.WriteLine();
//   }
// }

// void ReleaseMatrix(int[ , ] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     if (i % 2 != 0 && j % 2 != 0)
//     matrix [i, j] = matrix [i, j] * matrix [i, j];
//   }
// }


// Console.Clear();
// Console.Write("Ведите размеры массива: ");
// int [] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// int[ , ] matrix = new int[size[0], size[1]];
// FillMatrix(matrix);
// ScreenMatrix(matrix);
// ReleaseMatrix(matrix);
// Console.WriteLine();
// ScreenMatrix(matrix);

// // Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// void FillMatrix(int[ , ] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = i + j;
//       Console.Write($"{matrix[i, j]} \t");
//     }
//     Console.WriteLine();
//   }
// }

// void ReleaseMatrix(int[ , ] matrix)
// {
//   int sum = 0;
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//     if (i == j)
//     sum += matrix[i, j];
//     }
//   }
//   Console.WriteLine($"Сумма элементов по диагонали равна: {sum}");
// }

// Console.Clear();
// Console.Write("Ведите размеры массива: ");
// int [] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// int[ , ] matrix = new int[size[0], size[1]];
// FillMatrix(matrix);
// ReleaseMatrix(matrix);

// ЗАДАЧА №1235	

void FillMatrix(int[ , ] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 11);
    }
  }
}

void ScreenMatrix(int [ , ] matrix)
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


void ReleaseMatrix(int[ , ] matrix)
{
  int temp = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1) / 2; j++)
    {
    temp  = matrix[i, j];
    matrix[i, j] = matrix[i, matrix.GetLength(1) - 1 - j];
    matrix[i, matrix.GetLength(1) - 1 - j] = temp;
    }
  }
}

Console.Clear();
Console.Write("Ведите размеры массива: ");
int [] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[ , ] matrix = new int[size[0], size[1]];
FillMatrix(matrix);
ScreenMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
ScreenMatrix(matrix);

