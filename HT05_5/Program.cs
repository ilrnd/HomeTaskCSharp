// Задача 5. Статистика

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 32); // [1, 31]
}

void ReleaseArray(int[] array)
{
  int count1 = 0;
  int count2 = 0;
  Console.WriteLine($"\nНечетные дни с оценкой 3:");
  foreach (int element in array)
  {
    if (element % 2 != 0)
    {
      count1++;
      Console.Write($"{element} ");
    }
  }
  Console.WriteLine($"\nЧетные дни с оценкой 4:");
  foreach (int element in array)
  {
    if (element % 2 == 0)
    {
      count2++;
      Console.Write($"{element} ");
    }
  }
  if (count2 > count1)
      Console.WriteLine($"\n\nYES, Вася ты на пути к 4");
  else if (count1 > count2) 
      Console.WriteLine($"\n\nNO, Вася ты на пути к 3");
  else
      Console.WriteLine($"\n\nУ тебя спорная оценка, Вася");
}

Console.Clear();
Console.Write("Введите количество дней: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillArray(array);
Console.WriteLine($"Календарь: [{string.Join(", ", array)}]");
ReleaseArray(array);