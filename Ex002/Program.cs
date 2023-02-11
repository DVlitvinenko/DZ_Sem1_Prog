Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int number = 0;
if (a > b)
{
  number = a;
}
else
{
  if (b > c)
  {
  number = b;
  }
  else
  {
    number = c;
  }
}
Console.Write("Наибольшее число: ");
Console.Write(number);