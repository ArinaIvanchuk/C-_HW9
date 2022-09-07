
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке 
//от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

System.Console.WriteLine("введите М");
int start = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите N");
int end = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Numbers(start, end));
string Numbers (int start, int end)
{
    if (start == end) return start.ToString();
    else return (start + " " + Numbers(start + 1, end));
}
