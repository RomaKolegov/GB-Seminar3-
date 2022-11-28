/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
double getDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    result = Math.Round(result, 2);
    return result;
}
int x1 = getNumberFromUser("Введите Х1:");
int y1 = getNumberFromUser("Введите Y1:");
int z1 = getNumberFromUser("Введите Z1:");
int x2 = getNumberFromUser("Введите Х2:");
int y2 = getNumberFromUser("Введите Y2:");
int z2 = getNumberFromUser("Введите Z2:");
double distance = getDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"для точек с координатами ({x1};{y1};{z1}) и ({x2};{y2};{z2}) расстояние между точками равно {distance}");