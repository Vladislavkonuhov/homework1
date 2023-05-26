Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int n1 = int.Parse(Console.ReadLine()!);
if (n < n1)
    Console.WriteLine(n1);
else
    Console.Write(n);