﻿Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n % 2 == 0)
    Console.Write("Чётное");
else
    Console.Write("Не чётное");