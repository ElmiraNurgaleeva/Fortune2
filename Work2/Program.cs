//Задача 1  Напишите программу, которая выводит случайное число 
//из отрезка [10, 99] и показывает наибольшую цифру числа. 
//Пример  78 -> 8    12-> 2    85 -> 8

int number = new Random().Next(10, 100); //Случайное число из отрезка 10 - 99
Console.WriteLine($"Number = {number} ");  //Проверим выведем в консоль Название и число
int maxNum = FindMaxNumber(number);
Console.WriteLine($"Max = {maxNum}");

int FindMaxNumber(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}