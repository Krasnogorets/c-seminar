/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""*/
Console.Clear();
Console.Write("введите значение M:");
int M = int.Parse(Console.ReadLine()!);
Console.Write("введите значение N:");
int N = int.Parse(Console.ReadLine()!);
if (M>N)
{
    Console.Write($"{M} > {N}  что не соответсвует условию");
}
else
{
    Console.Write($"M = {M}; N = {N}. ->{PrintNumbers(M,N)}");
}
//рекурсивный метод
string PrintNumbers(int start, int finish)
{
    if (start == finish)
        return start.ToString();
    return (start + " " + PrintNumbers(start + 1, finish));
}