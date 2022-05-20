// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// Console.WriteLine("Введите натуральное число A ");
// int num = int.Parse(Console.ReadLine());
// int sum = 0;

// for (int i = 1; i <= num; i++)  //i=1 так задано в условии от 1
// {
//     sum = sum + i;

// }

// Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");


//Новая задача Метод Возвращать

// Console.WriteLine("Введите натуральное число A ");
// int num = int.Parse(Console.ReadLine());

// int GetSumNumbers(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= number; i++)  //i=1 так задано в условии от 1
//     {
//         sum = sum + i;
//     }
//     return sum;
// }
//     int sumResult = GetSumNumbers(num);
//     Console.WriteLine($"Сумма чисел от 1 до {num} = {GetSumNumbers(num)}");


// //Задача Решение в группах задач:
// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите натуральное число  ");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine(Math.Floor(Math.Log10(num) + 1));

//Еще способ решения этой же задачи:
// Решение в группах задач:
// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Введите число  ");
// int num = int.Parse(Console.ReadLine());
// int count = 0;
// while (num != 0)
// {
//     num = num / 10;
//     count++;
// }
// Console.WriteLine(count);

// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// System.Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());

// int GetComNumbers(int num)
// {
//     int com = 1;

//     for (int i = 1; i <= number; i++)
//     {
//         com = com * i;
//     }
//     return com;
// }
// System.Console.WriteLine(GetComNumbers(number));


