/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int getNumber(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int NumbersCubeTable(int numberN)
{
    int numberCube = 0;
    for (int firstNumber = 1; firstNumber <= numberN; firstNumber++)
    {
        numberCube = Convert.ToInt32(Math.Pow(firstNumber, 3));
        Console.Write(numberCube);
        if(firstNumber < numberN)
        {
            Console.Write(", ");
        }
    }
    return numberCube;
}
int numberN = getNumber("Введите число N для подсчета таблицы кубов чисел от 1 до N");
Console.Write($"Для числа {numberN} таблица кубов чисел от 1 до {numberN} составляет ");
NumbersCubeTable(numberN);