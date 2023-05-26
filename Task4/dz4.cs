Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int n1 = 2;
if (n > 1)
    while(n1 <= n)
    {
         Console.Write(n1 + " ");
         n1 = n1 + 2;
    }
