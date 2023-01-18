//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
  Console.Write("Введите день недели от 1 до 7: ");
  n = Convert.ToInt32(Console.ReadLine());
}
if (n==6 || n==7)
{
  Console.Write("Ура, выходной!");
}
else
{
  Console.Write("Будний день");
}
