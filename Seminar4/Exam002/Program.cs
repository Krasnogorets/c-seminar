Console.Clear();
/*int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int [] massive = {1,2,3345,456,5,68,7,8,9,10};
massive[1] = 253;

int max = Max ( Max(massive[0],massive[1],massive[2]),Max(massive[3],massive[4],massive[5]),Max(massive[6],massive[7],massive[8]));
Console.WriteLine (max);*/
/*int [] massive = {1,2,5,456,5,68,7,8,9,10};
int n = massive.Length;
int find = 5;
for (int index = 0; index < n; index++)
{
    if (massive[index] == find) 
    {
        Console.Write($"{index} ");
        break;
    }
    
}*/


void FillArray(int[] collection) /*FillArray - название метода*/
{
    int len = collection.Length;
    for (int i = 0; i < len; i++)
    {
        collection[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int [] collection1)
{
    int count = collection1.Length;
    for (int i2 = 0; i2 < count; i2++)
    {
        Console.Write($"{collection1[i2] } ");
    }
}
int IndexOf(int[] collection2, int find)
{
    int count = collection2.Length;
    int position = -1;
    for (int i3 = 0; i3< count; i3++)
    {
        if (collection2[i3] == find)
        {
            position = i3;
            break;
        }
    }
    return position;
}
int [] massive = new int[10];
FillArray(massive);
massive[3] = 4;
massive[6] = 4;
PrintArray(massive);
Console.WriteLine();
int pos = IndexOf(massive, 444);
Console.WriteLine(pos);