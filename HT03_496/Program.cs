//Сбор черники
Console.Clear();
Console.Write("Введите количество кустов N: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 3 || n > 1000)
{
  Console.Write("Введенное количество от [3 до 1000] Введите количество кустов N: ");
  n = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[n]; // создаем массив из введенного количества кустов с N количеством элементов
for (int i = 0; i < n; i++)
  {
    array[i] = new Random().Next(1, 10); // здесь генератором псевдослучайных чисел задаем сколько ягод может быть на кусте - для простоты счета укажем 10 (по заданию до 1000)
    Console.Write($"{array[i]} "); // для наглядности выводим сколько ягод на каждом кусте растет
  }
int max = array[0]+array[1]+array[2];
for (int i = 1; i < n-1; i++)
if (array[i-1]+array[i]+array[i+1] > max)
max = array[i-1]+array[i]+array[i+1];

Console.WriteLine($"\nМаксимальное количество ягод с 3х соседних кустов: {max} ");

