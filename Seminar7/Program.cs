//программа принимает на вход А, выдает сумму чисел от 1 до А
Console.Clear();
/*Console.Write("Введите любое число:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {num}  = {SumNum(num)}");
// метод
int SumNum(int B)
{
    int sum = 0;
    for (int i = 1; i <= B; i++)
    {
        sum = sum + i;
    }
    return sum;
}
// принимает число, подсчитать кол-во цифр в нем
Console.Write("Введите любое число:");
//int num = int.Parse(Console.ReadLine());// можно ее не создавать, но тогда ее нельзя 2 раза исполльзовать
//Console.WriteLine($"количество цифр в числе{num} = {NumCount(num))}");
Console.WriteLine($"количество цифр  = {NumCount(int.Parse(Console.ReadLine()))}");
// метод
int NumCount(int B)
{
    int count = 0;
    while (B > 0)
    {
        count++;
        B/=10;
    }
    
    return count;
}*/
//создать бинарный массиа
int [] massive = new int[10];
FillArray(massive);
Console.WriteLine($"[{String.Join(",", massive)}]");


//метод
int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]  = new Random().Next(2);
    }
    return array;
}