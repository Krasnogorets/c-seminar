// примеры на рекурсию
/*Console.Clear();

// вывести все натуральные числа от 1 до N
Console.Write("введите значение N:");
int N = int.Parse(Console.ReadLine()!);
Console.Write(PrintNumbers(1, N));

string PrintNumbers(int start, int end)
{
    if (start == end)
        return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}
*/
// подсчитать сумму цифр числа через рекурсию
/*Console.Write("введите число");
int number = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма цифр = {Sum(number)}");

int Sum(int num) // основное правило рекурсии обозначить условие выхода из нее
{
    if (num == 0) return 0;
    return (number % 10 + Sum(number / 10));
}
*/
// возмедение а в степень б
Console.Write("введите число A : ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("введите число B : ");
int numberB = int.Parse(Console.ReadLine()!);

Console.Write($"{numberA} в степени {numberB} = {Pow(numberA,numberB)}");

int Pow (int num, int st)
{
    if(st == 0) return 1;
    if(st== 1) return num;
    return(num*Pow(num,st-1));

}
