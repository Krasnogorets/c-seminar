// перевернуть одномерный массив [1 2 3 4 5] --> [5 4 3 2 1]
// Console.WriteLine("Введите размер массива:");
// int n = int.Parse(Console.ReadLine()!);
// int [] array1 = GetArray(n,1,9);
// Console.WriteLine($"[{String.Join("|", array1)}]");
// int [] array2 = FlipArray(array1);
// Console.WriteLine($"[{String.Join("|", array2)}]");
// ReverseArray(array2);
// Console.WriteLine($"[{String.Join("|", array2)}]");

// // method
// int[] FlipArray(int[] InArray)// записываем в новом массиве
// {
//     int[] result = new int[InArray.Length];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = InArray[InArray.Length-1-i];
//     }
//     return result;
// }
// int[] GetArray (int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }

// void ReverseArray(int[] InArray) // перезаписываем в текущем
// {
//     int temp = 0;
//     for (int i = 0; i < InArray.Length/2; i++)
//         {
//             temp = InArray[i];
//             InArray[i] = InArray[InArray.Length-1-i];
//             InArray[InArray.Length-1-i] = temp;
//         } 
// }
//получить на вход 3 числа, проверить может ли они быть сторонами треугольника
// Console.Clear();
// Console.WriteLine("Введите через пробел числа сторон треугольника");
// int [] array = GetArrayFromString(Console.ReadLine()!);
// //Console.WriteLine($"[{String.Join("|", array)}]");
// if (Triungle(array) == true)
// {
//     Console.WriteLine("да");
// }
// else
// {
//      Console.WriteLine("нет");
// }

// //метод создадим массив из строк
// int[] GetArrayFromString(String stringArray)
// {
//     string[] numS = stringArray.Split(' ',StringSplitOptions.RemoveEmptyEntries); // указываем разделитель, тот, который будем вводить, также опции удаляют повторлные лишние пробеллы
//     int[] result = new int [numS.Length];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = int.Parse(numS[i]);
//     }
//     return result;
// }
// bool Triungle(int[] InArray)
// {
//     int max = InArray[0];
//     int maxposition = 0;
//     int sum = 0;
//     for (int i = 0; i < InArray.Length; i++)
//     {
//         if (InArray[i] > max)
//         {
//             max = InArray[i];
//             maxposition = i;
//         }
//     }
//     for (int i = 0; i < InArray.Length; i++)
//     {
//         sum+=InArray[i];
//     }
//     sum-=InArray[maxposition];
//     if (sum > max)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// та же зажача только проще
// Console.Clear();
// Console.WriteLine("Введите через пробел числа сторон треугольника");
// string[] nums = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
// if (IsTriangle(int.Parse(nums[0]),int.Parse(nums[1]),int.Parse(nums[2])))
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }
// bool IsTriangle(int a, int b, int c)
// {
//     return (((a+b)>c)&&((b+c)>a)&&((a+c)>b));
// }

// перевод десятичного в двоичное через метод c#, но он знает только двоичную, восмиричную,десятичную, шестнадцатиричную
// Console.Clear();
// Console.WriteLine("Введите число:");
// int m = int.Parse(Console.ReadLine()!);
// string s1 = Convert.ToString(m, 16); // у метода c# есть два параметра 1 - число, 2 какую систему счисления 2 = двоичная
// Console.WriteLine($"{s1}");
// string s2 = DecToNums(m, 3);
// Console.WriteLine($"{s2}");

// // перевод десятичного в двоичное через рекурсию
// string DecToNums(int number, int sys)
// {
//     string result = ""; //создаем пустую строку в которую будем создавать число
//     string chars = "0123456789ABCDEF"; //создадим строку из символов которые нам понадобятся для исчисленя любого
//     while (number >0)
//     {
//         int k = number / sys; // промежуточная переменная
//         int ost = number - k * sys;// вычисляем остаток
//         result = chars[ost].ToString()+result; // переводим результат из строки chars в строку иначе вернет в виде кодировки ANSII
//         number/=sys;
//     }
//     return result;
// }

// вывод фибоначи циклом - гораздо быстрее чем рекурсия
// Console.Clear();
// Console.WriteLine("Введите N");
// int n = int.Parse(Console.ReadLine()!);
// PrintNumbers(0, 1, n);

// void PrintNumbers(double a1, double a2, int a3)
// {
//     Console.Write($"{a1} {a2}");
//     for (int i = 0; i < a3 - 2; i++)
//     {
//         Console.Write($"{a1+a2} ");
//         double k = a1+a2; // буферная переменная
//         a1 = a2;
//         a2 = k;
//     }
// }
// поэлементно скопировать массив из заданного
Console.WriteLine("Введите через пробел чиcла массива");
int [] array = GetArrayFromString(Console.ReadLine()!);
Console.WriteLine($"исходный массив:[{String.Join("|",array)}]");
Console.WriteLine($"копия массива:[{String.Join("|",CopyArray(array))}]");
int[] array2 = array;
Console.WriteLine($"приравненный массив:[{String.Join("|",array2)}]");
array[2] = 100;
int[] array3 = array;
Console.WriteLine($"исходный массив:[{String.Join("|",array)}]");
Console.WriteLine($"приравненный массив:[{String.Join("|",array3)}]");
// method
int[] GetArrayFromString(String stringArray)
{
    string[] numS = stringArray.Split(' ',StringSplitOptions.RemoveEmptyEntries); // указываем разделитель, тот, который будем вводить, также опции удаляют повторлные лишние пробеллы
    int[] result = new int [numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToInt32(numS[i]); // по другому конвертируем строку в число через метод c#
    }
    return result;
}
int [] CopyArray (int[]InArray)
{
    int [] result = new int[InArray.Length];
    for (int i = 0; i < InArray.Length; i++)
    {
        result[i] = InArray[i];
    }
    return result;
}