//Гипотеза Гольдбаха
Console.Clear();
Console.Write("Введите число от 4 до 998: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 4 || n > 998)
{
  Console.Write("Введено некорректное число. Введите число от 4 до 998: ");
  n = Convert.ToInt32(Console.ReadLine());
}

bool prime(int number)
{
  bool numb = true;
  for (int j = 2; j <= number; j++) // механизм проверки на простое число
  if (number % j == 0 && number != j)
  {
    numb = false;
    break;
  }
  return numb;
}

for (int i = 2; i < n; i++)
{
  bool flag1 = prime(i);
  bool flag2 = prime(n - i);
  if (flag1 && flag2 )
  {
  Console.Write($"{i} + {n-i} ");
  break;
  }
}
