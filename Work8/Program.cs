//Задача 17  Напишите программу, которая принимает на вход
//координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
//номер четверти плоскости, в которой находится эта
//точка

Console.WriteLine("введите координату X : ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("введите координату X : ");
int y = int.Parse(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("4");
}
else if (x > 0 && y > 0)
