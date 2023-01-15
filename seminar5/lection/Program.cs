//вид 1
/*void Method1()
{
    Console.WriteLine("Автор Филипп");
}
Method1();*/
//вид 2
/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения, которое сразу пойдет как переменная msg в метод");*/
/*void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}*/
//Method21("Текст сообщения 2",4); // можно неявно указывать
//Method21(count:4, msg:"Текст сообщения 3"); // можно явно указывать какие переменные, если именнованные, то можно не по порядку
//вид 3
/*int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);
Console.WriteLine(Method3()); // можно и так*/
//вид 4
/*string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // пустая строка
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}*/
/*string Method4(int count, string text)
{
   
    string result = String.Empty; // пустая строка
    for (int i = 0; i < count; i++)
    {
       result = result + text;
    }
    return result;
}
string res = Method4(count:10,"56 ");
Console.WriteLine(res);*/
//цикл в цикле
/*for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");

    }
    Console.WriteLine();
}
*/
// работа с текстом
// дан маленький текст, заменить все пробелы черточками, к на К, С на с
/*string text = "-Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винцегероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s="qwerty"
//           012345 - встроенная нумерация символов в строке
// s[3] - r - также как в массиве обращение по индексу
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else result = result + $"{text[i]}";
    }


    return result;
}
string newText = Replace(text, ' ', '|');
string newText1 = Replace(newText, 'к', 'К');
Console.WriteLine(newText1);*/
int[] arr = {7,6,5,4,3,2,1,1,1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
// сделать задачу чтобы упорядочивание было обратное от макс до мин
void SelectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
Console.WriteLine();
SelectionSortMax(arr);
PrintArray(arr);
// в методах лучше не указывать больше 5 аргументов - если больше, лучше перепроектировать метод
