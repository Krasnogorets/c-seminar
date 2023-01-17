// обработка введенного текста, вычленение нужных данных - не работает
using System.Linq; 
string text  ="(1,2) (2,3) (4,5) (6,7)"
    .Replace("(","")
    .Replace(")","");
Console.WriteLine(text);
var data = text.Split(" ")
                .Select(item => item.Split(","))
                .Select(e=> x: item.Parse(e[0]),  y: item.Parse(e[1]))
                .ToArray();
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i].x*10);
}


