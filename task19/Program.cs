/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int getNumberFromUser(string message)
{
    int result = 0;
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int userNumber = getNumberFromUser("Введите 5-значное число:");
if(userNumber >= 10000 & userNumber < 100000)
{
    int firstDigit = userNumber / 10000;
    int secondDigit = userNumber / 1000 % 10;
    int fourDigit = userNumber / 10 % 10;
    int fiveDigit = userNumber % 10;
    if(firstDigit == fiveDigit & secondDigit == fourDigit)
        {
            Console.WriteLine($"Число {userNumber} является палиндромом");
        }
    else Console.WriteLine($"Число {userNumber} не является палиндромом");
}
else Console.WriteLine("Число не является 5-значным");
