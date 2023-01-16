
// лекция урок 9
//string[,] table = new string [2, 5];
// table[0,0]   table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]   table[1,1]  table[1,2]  table[1,3]  table[1,4]
// table [1, 2] = "cлово"; // обращаемся как с обычной переменной
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// int[,] matrix = new int[3, 4];
// for (int rows = 0; rows < matrix.GetLength(0); rows++) //GetLength(0) - получить дллину массива
// {
//     for (int columns = 0; columns < matrix.GetLength(1); columns++)//GetLength(1) - получить высоту массива
//     {
//        Console.Write($"{matrix[rows, columns]} ");
//     }
//     Console.WriteLine();//переход на новую строку
// }

// int[,] matrix = new int[3, 4];
// PrinArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrinArray(matrix);

//метод
// void PrinArray(int[,] image)// принимает двумерную таблицу чисел - массив
// {

//     for (int rows = 0; rows < image.GetLength(0); rows++) //GetLength(0) - получить дллину массива
//     {
//         for (int columns = 0; columns < image.GetLength(1); columns++)//GetLength(1) - получить высоту массива
//         {
//             Console.Write($"{image[rows, columns]} ");
//         }
//     Console.WriteLine();//переход на новую строку
//     }
// }

// void FillArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             image[i, j] = new Random().Next(1,10);//
//         }
//     }
// }



// int[,] pic = new int[,]// козда вручную прописаны данны, можно размерность не писать
// {
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
//  {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };
// PrinImage(pic);
// FillImage(13,13);
// PrinImage(pic);

// //method
// void PrinImage(int[,] image)// принимает двумерную таблицу чисел - массив
// {

//     for (int rows = 0; rows < image.GetLength(0); rows++) //GetLength(0) - получить дллину массива
//     {
//         for (int columns = 0; columns < image.GetLength(1); columns++)//GetLength(1) - получить высоту массива
//         {
//             //Console.Write($"{image[rows, columns]} ");
//             if(image[rows,columns] == 0) Console.Write($" ");
//             else Console.Write($"*");
//         }
//     Console.WriteLine();//переход на новую строку
//     }
// }
// void FillImage(int rows, int col)
// {
//     if (pic[rows, col] == 0)
//     {
//         pic[rows, col] = 1;
//         FillImage(rows -1 , col); // вызываем метод в методе
//         FillImage(rows, col -1);
//         FillImage(rows +1, col);
//         FillImage(rows, col + 1);
//     }
// }

//расчет факториала через рекурсию
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"Факториал {i} = {Factorial(i)}");
// }

// //method
// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if(n == 1) return 1;
//     else return n * Factorial (n - 1);
// }

// Числа фибоначи являются рекурсией
// 1 1 23581321
// F(n)=f(n-1)+f(n-2)
for (int i = 1; i < 40; i++)//после 34 уже тормозит
{
    Console.WriteLine($"фибоначи {i} = {Fibonachi(i)}");
}

double Fibonachi(int n)
{
    if (n == 1 || n == 2 ) return 1;
    else return Fibonachi(n-1)+Fibonachi(n-2);
}