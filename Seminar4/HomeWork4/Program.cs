/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)

3, 5 -> 243 (3⁵)

2, 4 -> 16*/
Console.Clear();
/*
Console.WriteLine("Введите число A:");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B:");
int B = int.Parse(Console.ReadLine()!);

Console.Write($"{A} в степени {B} = {GetExponent(A,B)}");


// method
int GetExponent( int Ax, int Bx)
{
    int X = Ax;
    for (int i = 1; i < Bx; i++)
    {
        X = X * Ax; 

    }
    return X;
}
*/


/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/
/*
Console.WriteLine("Введите число :");
string M = Convert.ToString(Console.ReadLine()!);
if (M =="")
{
    Console.WriteLine($"Вы ввели пустую строку");

} else{


int A = int.Parse(M);

Console.WriteLine($"Сумма цифр числа {A} = {Sum(A)}, рассчитано циклом");

Console.WriteLine($"Сумма цифр числа {A} = {Sum1(A,M)}, рассчитано через string");
}
// method
int Sum (int k)
{
    if (k<10)
    {
       return k;
    }

    int sum = 0;
    while ( k >= 10)
    {
        sum +=k % 10;
        k = k / 10;
        
    }
    sum +=k;
    
    return sum;
    
}

int Sum1 (int k, string M)
{
    if (k<10)
    {
       return k;
    }
   
    int sum = 0;
    for (int i = 0; i <= M.Length; i++)
    {
        sum +=k % 10;
        k = k / 10;
    }
    
    return sum;
    
}
*/
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int [] massive = new int[8];
FillArray(massive);
Console.Write($"[{String.Join(",", massive)}]");

//method
void FillArray(int[] collection)
{
    int len = collection.Length;
    for (int i = 0; i < len; i++)
    {
        collection[i] = new Random().Next(-1000, 1000);
    }
}
