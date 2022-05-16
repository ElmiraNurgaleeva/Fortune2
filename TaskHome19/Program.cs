//Задача 19: Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно
//палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int temp1 = num;

int firstDigit = temp1 / 10000;
temp1 = temp1 % 10000;

int secondDigit = temp1 / 1000;
temp1 = temp1 % 1000;

temp1 = temp1 % 100;

int fourthDigit = temp1 / 10;
temp1 = temp1 % 10;

int fifthDigit = temp1;

if (firstDigit == fifthDigit)
{
    if (secondDigit == fourthDigit)
    {
        Console.Write("Это палиндром!");
    }
    else
    {
        Console.Write("Это не палиндром!");
    }
}
else
{
    Console.Write("Это не палиндром!");
}
