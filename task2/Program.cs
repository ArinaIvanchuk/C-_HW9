// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
//промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("введите М");
int start = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите N");
int end = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Numbers(start, end));

int SumNumbers(int start, int end)
{
    if (start == end) return end;
    else return end + SumNumbers (start,end - 1);

}

