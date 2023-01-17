// обработка введенного текста, вычленение нужных данных - не работает
// using System.Linq;
// string text  ="(1,2) (2,3) (4,5) (6,7)"
//     .Replace("(","")
//     .Replace(")","");
// Console.WriteLine(text);
// var data = text.Split(" ")
//                 .Select(item => item.Split(","))
//                 .Select(e=> x: item.Parse(e[0]),  y: item.Parse(e[1]))
//                 .ToArray();
// for (int i = 0; i < data.Length; i++)
// {
//     Console.WriteLine(data[i].x*10);
// }
/*
Console.Clear();
int[,] array1 = CreateArray1(4, 9);
PrintArray1(array1);
Console.WriteLine();
SwapArrayRows(array1);
PrintArray1(array1);
int[] rowA = CountArray(array1);
SortArray(rowA);
Console.WriteLine(String.Join("| ", rowA));
Console.WriteLine();
PrintData(rowA);

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

void SwapArrayRows(int[,] inArray)
{
    int FirstRow = 0;
    int LastRow = inArray.GetLength(0) - 1;
    int temp = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        temp = inArray[FirstRow, i];
        inArray[FirstRow, i] = inArray[LastRow, i];
        inArray[LastRow, i] = temp;
    }
}

int[] CountArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    int ResCount = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[ResCount] = inArray[i, j];
            ResCount++;
        }
    }
    return result;
}
void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}
void PrintData(int[] inArray)
{
    int element = inArray[0];
    int elementCount = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] != element)
        {
            Console.WriteLine($"{element} встречается {elementCount} раз");
            element = inArray[i];
            elementCount = 1;
        }
        else
        {
            elementCount++;
        }
    }
    Console.WriteLine($"{element} встречается {elementCount} раз");
}
*/
// найти первое нахождение минимального элемента массива и удалить строку и столбец на его перечесении
/*Console.Clear();
Console.Write("Введите количество строк:");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов:");
int col = int.Parse(Console.ReadLine()!);
int[,] NewArray = GetArray(rows, col, 1, 10);
PrintArray(NewArray);
Console.WriteLine();
Console.WriteLine($"{String.Join(" ;", GetMinPosition(NewArray))}");
PrintArray(GetResultArray(NewArray, GetMinPosition(NewArray)));

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

// метод нахождения индекса мин числа
int[] GetMinPosition(int[,] inArray)
{
    int[] result = { 0, 0 }; // сразу иницилизируем массив
    int min = inArray[0, 0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < min)
            {
                min = inArray[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

// метод исключения строки и столбца с мин элементом
int[,] GetResultArray(int[,] inArray, int[] index)
{
    int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    int row = 0;
    int col = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i == index[0])
        {
            continue; // оператор перехода на след шаг цикла
        }
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j == index[1])
            {
                continue; // оператор перехода на след шаг цикла
            }
            result[row, col] = inArray[i, j];
            col++;
        }
        row++;
        col = 0;
    }
    return result;
}
*/
// сделать трейгольник паскаля, разместиь его в равнобедренном треугольнике

Console.Clear();
Console.Write("Введите количество строк:");
int rows = int.Parse(Console.ReadLine()!);
PrintPascalTriangle(rows);
// метод вывода треугольгтка паскаля
void PrintPascalTriangle (int m) // m - количество строк в треугольнике
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j <=(m-i); j++)
        {
            Console.Write("  ");
        }
        for (int k = 0; k <=i; k++)
        {
            Console.Write("   ");
            Console.Write(Factorial(i)/(Factorial(k)*Factorial(i-k)));
        }
        Console.WriteLine();
    }
}
int Factorial(int n)
{
    int f = 1;
    for (int i = 1; i < n; i++)
    {
        f *= i;
    }
    return f;
}
