// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = (number / 10000) % 10;
int secondDigit = (number / 1000) % 10;
int fourthDigit = (number / 10) % 10;
int fifthDigit = number % 10;

if (number >= 10000 && number < 100000)
{
    if (firstDigit == fifthDigit && secondDigit == fourthDigit)
    {
        Console.WriteLine("Число полиндром");
    }
    else Console.WriteLine("Число не полиндром");
}
else Console.WriteLine("Не пятизначное число");


