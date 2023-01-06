/*Задача 1:вводится номер четверти на плоскости, указать какие возможные значения принимают x y*/
/*
Console.WriteLine("Введите  номер четверти от 1 до 4");
int num1 = int.Parse(Console.ReadLine()!);
int x = 10;
int y = 10;
switch (num1)
    {
        case 1: {Console.WriteLine($"X= {x} Y= {y}");
                break;
        }
        case 2: {Console.WriteLine($"X= {x*-1} Y= {y}");
                break;
        }
        case 3: {Console.WriteLine($"X= {x*-1} Y= {y*-1}");
                break;
        }
        case 4: {Console.WriteLine($"X= {x} Y= {y*-1}");
                break;
        }        
        default: {Console.WriteLine("Введите корректное число от 1 до 4");
              break; 
        }
    }

    */
/*Задача 2 :вводится четыре координаты а ( x y) и b(x y) расчитать расстояние между ними*/
Console.WriteLine("Введите  х координату точки a");
int ax = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите  y координату точки a");
int ay = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите  х координату точки b");
int bx = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите  y координату точки b");
int by = int.Parse(Console.ReadLine()!);
double dim = Math.Sqrt(Math.Pow((ay-by), 2) + Math.Pow((ax-bx), 2));
Console.WriteLine($"Расстояние между точками {Math.Round(dim, 2)}");