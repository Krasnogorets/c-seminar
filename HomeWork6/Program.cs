// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.WriteLine("Введите чиcла через пробел");
Console.WriteLine($"количество положительных = {GetCount(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries))}");

//method
int GetCount (string[] l)
{
    int count = 0;
    for (int i = 0; i < l.Length; i++)
    {
        if (Convert.ToInt32(l[i])>0)
        {
            count++;
        }
    }
    return count;
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.WriteLine("Введите чиcла b1, k1, b2 и k2 через пробел:");
string[] numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($" точка пересечения прямых = ( {String.Join(", ", GetPoint(numbers))} )");

//метод
double [] GetPoint (string[] nums)
{
    double[] temp = new double [nums.Length];
    double[] result = new double [2];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = Convert.ToInt32(nums[i]); 
    }
    // х = (b2-b1)/(k1-k2)
    // y = k1 * x + b1
    result[0] = (temp[0]-temp[2])/(temp[3]-temp[1]);
    result[1] = temp[1] * result[0] + temp[0];
    return result;
}
