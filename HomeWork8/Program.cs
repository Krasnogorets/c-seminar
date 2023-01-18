/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
 убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8
*/
/*Console.Clear();
int[,] NewArray = GetArray(4, 12, 1, 10);
PrintArray(NewArray);
Console.WriteLine();
NewArrayOrder(NewArray);
PrintArray(NewArray);
Console.WriteLine();

//method
int[,] GetArray(int rows, int col, int min, int max)
{
    int[,] result = new int[rows, col];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" {inArray[i, j]}");
        }
        Console.WriteLine();
    }
}

void NewArrayOrder(int[,] inArray)
{
    int temp = 0; // промежуточная для записи переносимых данных при сортировке
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = j + 1; k < inArray.GetLength(1); k++)
            {
                if (inArray[i, k] < inArray[i, j])
                {
                    temp = inArray[i, j];
                    inArray[i, j] = inArray[i, k];
                    inArray[i, k] = temp;
                }
            }
        }
    }
}
*/
/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*Console.Clear();
Console.Write("Введите кол-во строк:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов:");
int col = int.Parse(Console.ReadLine()!);
if (row == col)
{
    Console.Write("массив не прямоугольный");
}
else
{
    int[,] NewArray = GetArray(row, col, 1, 10);
    PrintArray(NewArray);
    Console.WriteLine();
    int[,] SumArray = SumRowElements(NewArray);
    Console.Write($"Строка с минимальной суммой элементов => {FindIndexMinRowSum(SumArray)}");
}

//method
int[,] GetArray(int rows, int col, int min, int max)
{
    int[,] result = new int[rows, col];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" {inArray[i, j]}");
        }
        Console.WriteLine();
    }
}
int[,] SumRowElements (int[,]inArray)
{
    int[,] result = new int[2,inArray.GetLength(0)];
    
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j <  inArray.GetLength(1); j++)
        {
           sum+=inArray[i,j];
        }
        result[0,i] =  sum;
        result[1,i] = i;
    }
    return result;
}
int FindIndexMinRowSum (int[,]inArray) // возвращает индекс строки с минимальной суммой
{
    int min = inArray[0,0];
    int temp = 0;
    int indexMin = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        if (inArray[0,i] <min)
        {
            temp = min;
            min = inArray[0,i];
            indexMin = i;
            inArray[0,i] = temp;
        }
    }
    return indexMin +1; // сделал так, чтобы возвращал не реальный индекс,
                        //а как строка визуально выглядит на экране, если сумма строк совпадает выводится первая,
                        //согласно приницпу KISS, не стал усложнять, чтобы сделать доп условие,
                        //т.к. такой задачи не стояло
}
*/
/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/
Console.Clear();
int[,] Matrix = GetArray(6, 6, 1, 10);
PrintArray(Matrix);
int[,] Matrix1 = GetArray(6, 6, 1, 10);
PrintArrayRight(Matrix1, 20);
PrintArrayRight(MatrixMultPl(Matrix,Matrix1), 40);
Console.WriteLine();

//method
int[,] GetArray(int rows, int col, int min, int max)
{
    int[,] result = new int[rows, col];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" {inArray[i, j]}");
        }
        Console.WriteLine();
    }
}

void PrintArrayRight(int[,] inArray, int x) // более удобный метод вывода массива справа
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.SetCursorPosition(x, i);
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" {inArray[i, j]}");
        }
    }
}
int [,] MatrixMultPl (int[,]inArray, int[,]inArray1)
{
    int[,]result = new int[inArray.GetLength(0),inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            result[i,j] = inArray[i,j] * inArray1[i,j];
        }
    }
    return result;
}