// Семинар№2 Задача№5   Напишите программу, которая принимает на вход 2 числа
// и проверяет является ли одно число квадратом другого
//Пример  5,52 -> да    -4,16->да    25,5 ->да   8,9 -> нет

Console.WriteLine("Введите первое число : ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int num2 = int.Parse(Console.ReadLine());

if (num1 / num2 == num2) Console.WriteLine("Число 1 - квадрат числа 2");
else if (num2 / num1 == num1) Console.WriteLine("Число 2 - квадрат числа 1");
else Console.WriteLine("Ниодно число не является квадратом другого");
