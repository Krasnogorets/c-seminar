/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/
/*Console.Clear();
Console.Write("Введите размер массива через пробел m*n:");
string[] param = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[,] array = CreateArray(int.Parse(param[0]), int.Parse(param[1]));
PrintArray(array);
Console.WriteLine();

//method
double[,] CreateArray(int rows, int col)
{
    double[,] result = new double[rows, col];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = Math.Round(GetRandomNumber(-5, 5), 2);
        }
    }
    return result;
}

double GetRandomNumber(int min, int max)
{
    Random random = new Random();
    return random.NextDouble() * (max - min) + min;
}
void PrintArray(double[,] InArray)
{
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLength(1); j++)
        {
            Console.Write($" {InArray[i, j]}");
        }
        Console.WriteLine();
    }
}*/
/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/

Console.Clear();
int[,] array1 = CreateArray1(9,9);
PrintArray1(array1);
Console.Write("Введите строку и ряд массива через пробел:");// по условию не понятно, как выбирается,
//будем считать что как видит на экране, а не реальный индекс
string[] param = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
if ((int.Parse(param[0])<= array1.GetLength(0))&&(int.Parse(param[1])<= array1.GetLength(1))
    &&(int.Parse(param[0])>0)&&(int.Parse(param[1])>0))
{
    Console.Write($"по данному индексу число:{array1[int.Parse(param[0])-1,int.Parse(param[1])-1]}");
}
else
{
    Console.Write($"такого числа в массиве нет");
}
//method
int[,] CreateArray1(int rows, int col)
{
    int[,] result = new int[rows, col];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1,10);
        }
    }
    return result;
}
void PrintArray1(int[,] InArray)
{
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLength(1); j++)
        {
            Console.Write($" {InArray[i, j]}");
        }
        Console.WriteLine();
    }
}

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

/*
int[,] array1 = CreateArray1(4, 6);
PrintArray1(array1);
double[] array2 = GetMidSum(array1);
Console.WriteLine($"Среднее арифметическое каждого столбца:{String.Join(", ",array2)}");
//method
int[,] CreateArray1(int rows, int col)
{
    int[,] result = new int[rows, col];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void PrintArray1(int[,] InArray)
{
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLength(1); j++)
        {
            Console.Write($" {InArray[i, j]}");
        }
        Console.WriteLine();
    }
}
double[] GetMidSum(int[,] inArray)
{
    double sum = 0;
    double[] result = new double[inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            sum += inArray[j, i];
        }
        result[i] = Math.Round(sum / inArray.GetLength(0), 2);
        sum =0;
    }
    return result;
}
*/