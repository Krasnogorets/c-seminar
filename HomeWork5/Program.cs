
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

/*
Console.Clear();
int[] array = FillArray1(10,101,999);
Console.WriteLine($"[{String.Join(",",array)}]");
Console.WriteLine($"Количество четных элементов = {CountEvenElements(array)}");
//метод
int[] FillArray1(int size, int min, int max)
{
    int [] massive2 = new int [size];
    for (int i = 0; i < size; i++)
    {
        massive2[i] = new Random().Next(min,max+1);
    }
    return massive2;
}*/
/*int CountEvenElements(int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0 ) count++;
    }
    return count;
}
*/
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
/*int[] array = FillArray1(10,1,40);
Console.WriteLine($"[{String.Join(",",array)}]");
Console.WriteLine($"Количество четных элементов = {FindSumElementsOddPossition(array)}");
//метод
int FindSumElementsOddPossition(int[]array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}
*/
/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
Console.Clear();
double[] array = FillArray2(10,1,9);
Console.WriteLine($"[{String.Join("|",array)}]");

Console.WriteLine($"Разница макс и мин = {Math.Round(GetDifMinMax(array),3)}");


//метод
double[] FillArray2(int size, double min, double max)
{
    double[] massive2 = new double [size];
    for (int i = 0; i < size; i++)
    {
        massive2[i] =  Math.Round(GetRandomNumber(min, max),2);
    }
    return massive2;
}

double GetRandomNumber(double min, double max)
{ 
    Random random = new Random();
    return random.NextDouble() * (max - min) + min;
}

double GetDifMinMax(double[] NewArray)
{
    double min = 0;
    double max = 0;
    double diff = 0;
    if ( NewArray[0] > NewArray[1])
        {   max = NewArray[0];
            min = NewArray[1];
        } 
    else
    {
        max = NewArray[1];
        min = NewArray[0];
    }
    for (int i = 2; i < NewArray.Length; i++)
    {
        if (NewArray[i] > max)
        {
            max = NewArray[i];
        }
        if (NewArray[i] < min)
        {
            min = NewArray[i];
        }
    }
    diff = max - min;
    Console.WriteLine($"макс ={max}");
    Console.WriteLine($"мин = {min}");
    return diff;
}