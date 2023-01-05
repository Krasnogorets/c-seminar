/*Console.WriteLine ("Ведите первое число");
int numA = int.parse(Console.readLine()!);
Console.writeline ("Ведите второе число");
int numA = int.parse(Console.readLine()!);
Console.write($"{numA} {numB}");*/
/*Console.Clear();
Console.Write ("Ведите первое число:");
int A = int.Parse(Console.ReadLine());

Console.Write ("Ведите второе число:");
int B = int.Parse(Console.ReadLine());

if (A == Convert.ToInt32(Math.Pow(B, 2)))
{
    Console.WriteLine ($"ДА! Число {A} является квадратом числа {B}");
}
else
{
    Console.WriteLine ($"НЕТ! Число {A} не является квадратом числа {B}");
}
*/
/*Console.Clear();
Console.Write ("Ведите число от 1 до 7:");
int A = int.Parse(Console.ReadLine());

if (A == 1)
{
    Console.Write ("Понедельник");
}
else if (A == 2)
{
    Console.Write ("Вторник");
}
else if (A == 3)
{
    Console.Write ("Среда");
}
else if (A == 4)
{
    Console.Write ("Четверг");
}
else if (A == 5)
{
    Console.Write ("Пятница");
}
else if (A == 6)
{
    Console.Write ("Суббота");
}
else if (A == 7)
{
    Console.Write ("Воскресенье");
}
else
{
    Console.Write ("Введите другое число");
}*/
Console.Clear();
Console.Write ("Ведите трехзначное число:");
int A = int.Parse(Console.ReadLine()!);
int C = A % 10;
Console.Write ($"Последння цифра: {C}");