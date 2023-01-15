
using System;
// создать массив 12 элементов, случ числа -9,9, найти сумму отрицательных и сумму положительных
/*int [] massive1 = new int [12];
FillArray(massive1);
Console.WriteLine($"[{String.Join(",",massive1)}]");
int SumNegative = 0;
int SumPositive = 0;
foreach (int item in massive1) // новый оператор
{
    Console.WriteLine($"{item}");
    if (item >0 )
    {
        SumPositive+= item;
    }
    else
    {
        SumNegative+= item;
    }
}
Console.WriteLine($"Сумма отрицательных = {SumNegative}");
Console.WriteLine($"Сумма положительных = {SumPositive}");
*/
//метод
/*int[] FillArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
    return array;
}
// инфертировать масисив
int [] massive1 = new int [12];
FillArray(massive1);

Console.WriteLine($"[{String.Join(",",massive1)}]");
Inverse(massive1);


Console.WriteLine($"[{String.Join(",",massive1)}]");

// method
void Inverse(int[] newarray)
{
for (int i = 0; i < newarray.Length; i++)
{
    newarray[i]*=-1;
}
}
*/
//      определить массив, найти есть ли там заданное число
/*int [] array = FillArray1(10,2,50);
Console.WriteLine($"[{String.Join(",", array)}]");

Console.Write("Введите любое число:");
int num2 = int.Parse(Console.ReadLine()!);
FindNumArray(array, num2);
//Console.WriteLine($"{S}");
/*if ( S = true)
{
    Console.WriteLine($"Число {num2} есть в массиве");
}
else
{
    Console.WriteLine($"Числа {num2} нет в массиве");
}
*/
        

//метод
int[] FillArray1(int size, int min, int max)
{
    int [] massive2 = new int [size];
    for (int i = 0; i < size; i++)
    {
        massive2[i] = new Random().Next(min,max+1);
    }
    return massive2;
}


// задавать массив через строку
/*Console.Clear();
Console.WriteLine("Введите через пробел чила массива");
int [] array = GetArrayFromString(Console.ReadLine()!);
Console.WriteLine("Введите любое число:");
int element = int.Parse(Console.ReadLine()!);
if (FindNumArray(array, element))
{
    Console.WriteLine($"Число {element} есть в массиве");
}
else
{
    Console.WriteLine($"Числа {element} нет в массиве");
}


// method
int[] GetArrayFromString(String stringArray)
{
    string[] numS = stringArray.Split(' ',StringSplitOptions.RemoveEmptyEntries); // указываем разделитель, тот, который будем вводить, также опции удаляют повторлные лишние пробеллы
    int[] result = new int [numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}


bool FindNumArray(int[] array1, int num)
{
    foreach (int item in array1)
    {
        if (item == num)
        {
            return true;
        }
    }
    return false;
    
}*/
/*int[] array = FillArray1(10,1,1000);
Console.WriteLine($"{String.Join(",",array)}");
Console.WriteLine($" Число элементов в диапазоне от 10 до 99 = {CountInRange(array,10,99)}");

//method
int CountInRange(int[] array,int min, int max)
{
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<= max && array[i]>= min)
        {
            count++;
            
        }
       
    }
    return count;
}
*/
// найти произведение пары чисел в массиве , пара первая и последняяя и так по порядку до середины, результат вывести в массив
int[] array = FillArray1(10,2,10);
Console.WriteLine($"{String.Join(",",array)}");
int[] NewArray = MultiplyArrayElements(array);
Console.WriteLine($"{String.Join(",",NewArray)}");

//method
int[] MultiplyArrayElements(int[]InArray)
{
    int Multiply = 0;
    int countback = InArray.Length-1;
    int count = InArray.Length/2;
    if (InArray.Length % 2 > 0)
    {
        count++;
    }
    int[] newarray = new int[count];
    for (int i = 0; i < InArray.Length/2; i++)
    {
        Multiply = InArray[i]*InArray[countback];
        newarray[i] = Multiply;
        countback--;
        
    }
    if (InArray.Length % 2 > 0) newarray[count-1]=InArray[InArray.Length/2];
    
    return newarray;
}