/*Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write ("Введите первое число:");
int A = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число:");
int B = int.Parse(Console.ReadLine());
if (A > B)
{
    Console.Write ($"Первое число больше второго max= {A}");
}
else
{
    Console.Write ($"Второе число больше первого max= {B}");
}*/

/*Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.Clear();
Console.Write ("Введите первое число:");
int numA = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число:");
int numB = int.Parse(Console.ReadLine());
Console.Write ("Введите третье число:");
int numC = int.Parse(Console.ReadLine());
int max = numA;
if (numB > max)
{max = numB;
    
}
if (numC > max)
{max = numC;
    
}
Console.Write ($"Максимальное число:{max}");*/


/*Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Console.Clear();
Console.Write ("Введите число:");
int numA = int.Parse(Console.ReadLine());
if (numA % 2 == 0)
{
    Console.Write ($"Да, Число: {numA} четное");
}
else
{
    Console.Write ($"Нет, Число: {numA} нечетное");
}
*/

/*Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе
 показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/
Console.Clear();
Console.Write ("Введите число:");
int numB = int.Parse(Console.ReadLine());
int count = 2;
while (count <= numB)
{
    
    Console.Write ($"{count} ");
     count = count + 2;
} 
   
    
