// массив 3,4 заполнить случ числами
/*Console.Clear();
Console.Write("Введите размер массива через пробел m*n:");
string[] param = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
PrintArray(CreateArray(int.Parse(param[0]), int.Parse(param[1]), -10, 100));
//метод
int[,] CreateArray(int rows, int col, int min, int max)
{
    int[,] result = new int[rows, col];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
void PrintArray(int[,] InArray)
{
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLength(1); j++)
        {
            Console.Write($"{InArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/
// заполнить массив где Amn = m+n
/*Console.Clear();
Console.Write("Введите размер массива через пробел m*n:");
string[] param = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
PrintArray(CreateArray(int.Parse(param[0]), int.Parse(param[1])));
//метод
int[,] CreateArray(int rows, int col)
{
    int[,] result = new int[rows, col];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}
void PrintArray(int[,] InArray)
{
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLength(1); j++)
        {
            Console.Write($"{InArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/
// найти четные индексы, заменить содержимое на квадрат
Console.Clear();
Console.Write("Введите размер массива через пробел m*n:");
string[] param = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = CreateArray(int.Parse(param[0]), int.Parse(param[1]));
PrintArray(array);
Console.WriteLine();
Console.Write($"сумма по главной диагонали:{SumArray(array)}");
Console.WriteLine();
Console.Write($"сумма по главной диагонали:{GetSum(array)}");
//ChangeArray(array);

//PrintArray(array);
//метод
int[,] CreateArray(int rows, int col)
{
    int[,] result = new int[rows, col];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}
void PrintArray(int[,] InArray)
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
void ChangeArray(int[,] InArray)
{
    for (int i = 2; i < InArray.GetLength(0); i += 2)
    {
        for (int j = 2; j < InArray.GetLength(1); j += 2)
        {
            InArray[i, j] *= InArray[i, j];
        }
    }
}
int SumArray(int[,] InArray)
{
    int sum = 0;
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLength(1); j++)
        {

            if (i == j)sum += InArray[i, j];
        }
    }
    return sum;
}
int GetSum (int[,]inArray)
{
    int sum = 0;
    int length = inArray.GetLength(0);
    if (length>inArray.GetLength(0))length = inArray.GetLength(1);
    for (int i = 0; i < length; i++)
    {
        sum += inArray[i, i];
    }
     return sum;
}