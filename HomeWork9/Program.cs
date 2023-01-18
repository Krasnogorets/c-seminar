/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""*/
/*Console.Clear();
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
*/
/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
/*Console.Clear();
Console.Write("введите значение M:");
int M = int.Parse(Console.ReadLine()!);
Console.Write("введите значение N:");
int N = int.Parse(Console.ReadLine()!);
if (M >= N)
{
    Console.Write($"{M} >= {N}  что не соответсвует условию");
}
else
{
    Console.Write($"Сумма чисел от {M} до {N} ->{SumGap(M, N)}");
}

//рекурсивный метод
int SumGap(int start, int finish)
{
    if (start > finish) return 0;// обозначить условие выхода из нее
    return (start + SumGap(start + 1, finish));
}
*/
/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/
Console.Clear();
Console.Write("введите значение M:");
int M = int.Parse(Console.ReadLine()!);
Console.Write("введите значение N:");
int N = int.Parse(Console.ReadLine()!);
if ( (M < 0) || (N < 0) || (M > 4) || (N > 4))
{
    Console.Write($"Введенные значения не соответсвуют условию");
}
else
{
    Console.Write($"Функция Аккермана A({M}, {N}) ->{Akkerman(M, N)}");
}
int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    else
    {
        if (N == 0) return Akkerman(M - 1, 1);
    }
    return Akkerman(M - 1, Akkerman(M, N - 1));
}
