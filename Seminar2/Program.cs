Console.Clear();
int n = new Random().Next(10,100); // [10, 99]
Console.WriteLine($"Случайное число: {n}");
int n1 = n / 10;
int n2 = n % 10;
if (n1 > n2)
  Console.WriteLine(n1);
else
  Console.WriteLine (n2);
// Console.Clear();
// int n = new Random().Next(100, 1000); // [100, 999]
// Console.WriteLine($"Случайное число: {n}");
// int n1 = n / 100;
// int n3 = n % 10;
// Console.WriteLine(n1 * 10 + n3);

// Console.Clear();
// Console.Write("Введите 1-е число ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-е число ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n%m == 0)
//   Console.Write("Второе число кратно первому");
// else 
//   Console.Write($"Остаток от деления {n%m}");


// Console.Clear();
// Console.Write("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n%7 == 0 && n%23 == 0 )
//   Console.Write("Введеное число кратно 7 и 23");
// else 
//   Console.Write($"Число не кратно 7 и 23");

// Console.Clear();
// Console.Write("Введите 1-е число ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-е число ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n*n == m || m*m == n)
//   Console.Write($"Да");
// else
//   Console.Write($"Нет");
