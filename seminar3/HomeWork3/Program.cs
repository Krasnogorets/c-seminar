/* Задача 1

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Проверка на пятизначность обязательна

14212 -> нет

12821 -> да

23432 -> да */

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string M = Convert.ToString((int.Parse(Console.ReadLine()!)));
if (M.Length == 5)
{
    if ((M[0] == M[4]) && (M[1] == M[3]))
    {
     
        Console.WriteLine($"Число {M} -полиндром! ");
    }
    else
    {
        Console.WriteLine($"Число {M} - НЕ полиндром! ");
    }
        

}
else
{
    Console.WriteLine($"Чиcло {M.Length}-значное, что нарушает условия! ");
}

/*Задача 2

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/


Console.WriteLine("Введите  х координату точки a");
int ax = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите  y координату точки a");
int ay = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите  z координату точки a");
int az = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите  х координату точки b");
int bx = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите  y координату точки b");
int by = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите  z координату точки b");
int bz = int.Parse(Console.ReadLine()!);
double dim = Math.Sqrt(Math.Pow((ay-by), 2) + Math.Pow((ax-bx), 2) + Math.Pow((az-bz), 2));
Console.WriteLine($"Расстояние между точками: {Math.Round(dim, 2)}");

/*Задача 3

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}