Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
  Console.WriteLine("Больше число: ");
  Console.Write(a);
  Console.WriteLine("Меньшее число: ");
  Console.Write(b);
}
else
{
  Console.Write("Больше число: ");
  Console.Write(b);
  Console.WriteLine("Меньшее число: ");
  Console.Write(a);
}