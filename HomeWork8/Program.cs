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
Console.Clear();
int[,] NewArray = GetArray (4,12,1,10);
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

void NewArrayOrder (int[,]inArray)
{
    int temp = 0; // промежуточная для записи переносимых данных при сортировке
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = j+1; k < inArray.GetLength(1); k++)
            {
                if (inArray[i,k] < inArray[i,j])
                {
                    temp = inArray[i,j];
                    inArray[i,j] = inArray[i,k];
                    inArray[i,k] = temp;
                }
            }
        }

    }
}