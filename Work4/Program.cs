﻿// Семинар№2 Задача№3   Напишите программу, которая будет принимать на вход 2 числа
//и выводить, является ли 1е число кратным 2му. Если  1е число не кратно 2му
//то программа выводит остаток от деления
//Пример  34,5 -> не кратно, остаток 4   или  16, 4 -> кратно

Console.WriteLine("Введите первое число : ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0) Console.WriteLine("-> кратно");
else Console.WriteLine($"-> не кратно, остаток от деления - {num1 % num2}");

Console.ReadKey();