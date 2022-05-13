//Семинар2 Задача4 Напишите программу, которая принимает на вход число и проверяет
// кратно ли оно одновременно 7 и 23
//Пример 14-> нет    46->нет    161->да

//Console.WriteLine("Введите число : ");          //МОЕ  Верно!
//int num = int.Parse(Console.ReadLine());
//int num1 = num % 7;
//int num2 = num % 23;

//if (num1 == 0 && num2 == 0) Console.WriteLine($"{num} -> да");
//else Console.WriteLine($"{num} -> нет");

//ИЛИ  чеерз bool
Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine());
int num1 = num % 7;
int num2 = num % 23;

bool res = num1 ==0 && num2==0;
Console.WriteLine(res ? "ДА" : "НЕТ");
