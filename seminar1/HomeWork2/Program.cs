﻿/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков

456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();
Console.WriteLine("Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков");

Console.WriteLine("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine()!);
if ((num > 999)||(num < 100))
{
    Console.WriteLine($"{num} не трехзначное число");
}
else
{
    int result = (num - (num / 100)*100) / 10;
    Console.WriteLine($"{num} -> {result} ");
} 

/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000");

/*int ran = new Random().Next(1,100001); - под заданным можно и случайное задавать, но проверять сложнее, поэтому оставил два варианта*/
Console.WriteLine("Введите  число от 100 до 100 000");
int ran = int.Parse(Console.ReadLine()!);
if ((ran < 100)||(ran > 100000))
{
    Console.WriteLine($"{ran} -> третьей цифры нет или число больше 100000");
}
else
{
   if ((ran >= 100)&&(ran < 1000))
   {
    Console.WriteLine($"{ran} -> {ran%10}");
   } 

    else
    {
         if ((ran >= 1000)&&(ran < 10000))
          {
                Console.WriteLine($"{ran} -> {(ran%100)/10}");
            } 
            else
            {
            if ((ran >= 10000)&&(ran < 100000))
            {
                Console.WriteLine($"{ran} -> {(ran%1000)/100}");
            } 
                    else
                {
                if (ran >= 100000)
                {
                    Console.WriteLine($"{ran} -> {(ran%10000)/1000}");
                } 

                }
            }   
    }
}

/*Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7

6 -> да
7 -> да
1 -> нет*/
Console.WriteLine("Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7");
Console.WriteLine("Введите  число от 1 до 7");
int num1 = int.Parse(Console.ReadLine()!);
if ((num1 < 1)||(num1 > 7))
{
    Console.WriteLine($"Число{num1} не входит в диапазон от 1 до 7");
} 
else
{
    if ((num1 >= 1)&&(num1 <= 5))
    {
        Console.WriteLine($"Число {num1} нет, не выходной");
    }
    else
    {
        Console.WriteLine($"Число {num1} да, выходной");
    }
}