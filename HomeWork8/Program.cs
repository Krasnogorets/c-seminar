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
/*Console.Clear();
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
*/
/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)*/
/*Console.Clear();
Console.Write("Введите кол-во строк:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов:");
int col = int.Parse(Console.ReadLine()!);
Console.Write("Введите глубину масиива:");
int width = int.Parse(Console.ReadLine()!);
if (row * col * width >90)// только двузначные => от 10 до 99
{
    Console.Write("такой массив невозможно создать, чтобы соответствовать условиям");
}
else
{
    int[] randomArray = GetUniqRandom(row,col,width, 10,100);
    int[,,] NewDArray = FillArray3D(row,col,width, randomArray);
    Print3dArray(NewDArray);
}

//method

int[] GetUniqRandom (int rows, int col, int width, int min, int max)
{
    int[] result = new int[rows*col*width]; // массив для создания уникальных элементов
    result[0] = new Random().Next(min, max); // 0 элемент создаем без проверки на уникальность
    for (int i = 1; i < result.GetLength(0); i++)
    {
        result[i] = new Random().Next(min, max);
        for (int j = 0; j < i; j++) // создаем цикл проверки на уникальность сравнивая с предыдущими
        {
            if (result[j] == result[i])
            {
                i--;
                continue;        
            }
        }
    }
    return result;
}

void NewArrayOrder1(int[] inArray) // метод сортировки для промежуточного тестирования программы
                                    // проверки уникальности элементов
{
    int temp = 0; // промежуточная для записи переносимых данных при сортировке
    
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            for (int k = j + 1; k < inArray.GetLength(0); k++)
            {
                if (inArray[k] < inArray[j])
                {
                    temp = inArray[j];
                    inArray[j] = inArray[k];
                    inArray[k] = temp;
                }
            }
        }
    
}

int[,,] FillArray3D(int rows, int col, int width, int[]inArray)
{
    int[,,] result = new int[rows, col, width];
    int count = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < width; k++)
            {
                result[i, j, k] = inArray[count];
                count++;
            }
        }
    }
    return result;
}
void Print3dArray (int[,,]NewDArray) // вывод послойно
{
    for (int i = 0; i < NewDArray.GetLength(2); i++)
    {
        Console.WriteLine($" Слой {i}-ый ");
        for (int j = 0; j < NewDArray.GetLength(0); j++)
        {
            for (int k = 0; k < NewDArray.GetLength(1); k++)
            {
                Console.Write($" {NewDArray[j, k ,i]} ( {j},{k},{i} )"); 
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
*/
/*Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7*/
Console.Clear();
int[,] array = new int[4,4];//
FillArraySnakeType(array);
PrintArray(array);

//method
void FillArraySnakeType(int[,] inArray )
{
    
    int[,] arrayPath = new int[,] // массив с маской индексов столбцов и строк для заполнения змейкой, 
    {
        {0,0,0,0,1,2,3,3,3,3,2,1,1,1,2,2},
        {0,1,2,3,3,3,3,2,1,0,0,0,1,2,2,1},
        };
    for (int i = 0; i < inArray.GetLength(0)*inArray.GetLength(0); i++)
    {
        inArray[arrayPath[0,i],arrayPath[1,i]]= i;
    }
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