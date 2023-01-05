/*int numberA = 3;
int numberB = 5;
Console.WriteLine(numberA + numberB);*/
/*double numberA = 12;
double numberB = 0.3;
Console.WriteLine (numberA);
Console.WriteLine (numberB);
Console.WriteLine (numberA / numberB);*/

int numberA = new Random().Next(1, 100);
int numberB = new Random().Next(1, 100);
double result = numberA / numberB;
Console.WriteLine (numberA);
Console.WriteLine (numberB);
Console.WriteLine ($"Результат деления: {result}");