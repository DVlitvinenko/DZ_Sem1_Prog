﻿//Задача 6: Напишите программу, которая на вход принимает 
//число и выдаёт, является ли число чётным (делится ли 
//оно на два без остатка).


Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 2;
if (b == 1)
{
  Console.Write("число не является четным");
}
else
{
  Console.Write("число является четным");
}