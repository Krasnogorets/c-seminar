/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков

456 -> 5
782 -> 8
918 -> 1


Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine()!);
if (num > 999)
{
    Console.WriteLine("Это не трехзначное число:");

}
if (num < 100)
{
    Console.WriteLine("Это не трехзначное число");
    
}
int result = (num - (num / 100)*100) / 10;
Console.Write($"{num} -> {result} ");
*/
/* найти случ число от 10 до 99 вкл, и показать наибольшую цифру 97 -> 9; 23 -> 3

Console.Clear();
int ran = new Random().Next(10,100);
int a = ran / 10;
int c = ran % 10;
if ( a > c)
{
    Console.Write($"{ran} -> наибольшая цифра {a} ");
}
else
{
    Console.Write($"{ran} -> наибольшая цифра {c} ");
}
*/
/* ввести 2 числа, найти является ли перове кратное второму , если не кратно вывести остаток от деления*/ 

/*Console.Clear();
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine()!);
if ( a % b == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
    Console.WriteLine($"Первое число НЕ кратно второму, остаток: {a%b}");
}*/
/* Приянть число, проверить кратно ли оно одновременно 7 и 23
Console.Clear();
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
if ((num%7==0)&&(num%23==0))
{
    Console.WriteLine($"Число {num} кратно и 7 и 23");
}
else
{
    Console.WriteLine($"Число {num} НЕ кратно и 7 и 23");
}*/
/* принять 2 числа, проверить чвл ли они квадратами друг друга*/
Console.Clear();
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine()!);
if ((a*a==b)||(b*b==a))
{
    Console.WriteLine("одно число является квадратом другого");
}
else
{
    Console.WriteLine("НИ одно число НЕ является квадратом другого");
}