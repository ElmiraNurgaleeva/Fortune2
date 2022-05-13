//Задача 2 Семинар2 Напишите программу, которая выводит случайное трехзначное чсисло 
//и удаляет 2ю цифру этого числа
//Пример 456 -> 46 782 -> 72 918 -> 98 

//int number = new Random().Next(100, 1000);   //МОЕ РЕШЕНИЕ   Ререно верно!
               //Console.WriteLine($"Number = {number} ");

//int firstDigit = number / 100;
//int secondDigit = number / 10;
//int thirdDigit = number % 10;

//Console.WriteLine($"Случайное число = {number} ");
//Console.WriteLine($"Результат = {firstDigit}{thirdDigit} ");

//или вариант :

int number = new Random().Next(100, 1000);

int last = number % 10;
int first = number / 100;
int res = first * 10 + last;

Console.WriteLine($"Случайное число = {number} ");
Console.WriteLine($"Результат = {res} ");

