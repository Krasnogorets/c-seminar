// задача на собаку
double FirstFriendSpeed = 4;
double SecondFriendSpeed = 5;
double DogSpeed = 20;
double DistanceLimit = 10;
double DogCounter = 0;
double DogDirection = 1;
double Distance = 10000;
double TimeToMeet = 0;
double Speed = 0;

while (Distance >= DistanceLimit)
{
    if (DogDirection == 1)
    {
        TimeToMeet = Distance / (FirstFriendSpeed + DogSpeed);
        DogDirection = 2;
        
    }
    else
    {
        TimeToMeet = Distance / (SecondFriendSpeed + DogSpeed);
        DogDirection = 1;
    }
    
    Distance = Distance - TimeToMeet * (FirstFriendSpeed + SecondFriendSpeed);
    DogCounter++;
    
    Console.WriteLine($"расстояние {Distance} ");
    
    
}
Console.WriteLine($"Собака пробежит {DogCounter} раз");