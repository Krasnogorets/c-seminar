/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

456 -> 3

78 -> 2

89126 -> 5*/
/* метод*/
int GetMultiply (int K) // K- внутренняя переменная только внутри метода K получает значение при вызове
{
    int res = 1; // res- внутренняя переменная  только внутри метода
   for (int i = 1; i < K; i++)
   {
    res = res * i;
   }
    return res; // возвращает значение, указывать res не нужно
}

Console.Clear();
Console.WriteLine("Введите число:");
int arg1 = int.Parse(Console.ReadLine()!);

Console.WriteLine ($"Произведение чисел от 1 до {arg1} равно {GetMultiply(arg1)}");

Console.WriteLine("Введите число 2:");
int arg2 = int.Parse(Console.ReadLine()!);
Console.WriteLine ($"Произведение чисел от 1 до {arg2} равно {GetMultiply(arg2)}");
/*
int[] GetArray(int size){
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++){
        myArray[i] = new Random().Next(2);
    }
    return myArray;
}

int[] myArray = GetArray(8);
Console.WriteLine($"[{String.Join(",", myArray)}]");
*/
