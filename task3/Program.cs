// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();
int Akkerman(int start, int end)
{
    if(end == 0) return start+1;
    if(end > 0 && start == 0) return Akkerman(1, end-1);
    return Akkerman(Akkerman(start-1, end),end-1);
}
Console.WriteLine("введите M  ");
int M=Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("введите N ");
int N=Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(Akkerman(M,N));

