Console.Clear();
/*Console.SetCursorPosition(10,10);
Console.WriteLine("+");*/
int xa = 40;
int ya = 2;
int xb = 2;
int yb = 20;
int xc = 80;
int yc = 20;
int x = 0;
int y = 0;
Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");
int count = 0;
while (count < 5000)
{
    int rand = new Random().Next(0, 3);
    if (rand == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2; 
    }
    if (rand == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2; 
    }
    if (rand == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2; 
    }
Console.SetCursorPosition(x,y);
Console.WriteLine("+");
count++;

}