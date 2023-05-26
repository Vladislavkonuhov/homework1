Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int n1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int n2 = int.Parse(Console.ReadLine()!);
int max = n;
if (n<n1)
    max = n1;
if (n1<n2)
    max = n2;
Console.WriteLine(max);