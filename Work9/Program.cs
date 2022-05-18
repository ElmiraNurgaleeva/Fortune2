//Задача 18: Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).

Console.WriteLine("введите номер четверти : ");
int nunber = int.Parse(Console.ReadLine());

if (nunber ==1)
{
    Console.WriteLine("x > 0 и y > 0");
}
else if (nunber ==2)
{
    Console.WriteLine("x < 0 и y > 0");
}
else if (nunber ==3)
{
    Console.WriteLine("x < 0 и y < 0");
}
else if (nunber ==4)
{
    Console.WriteLine("x > 0 и y < 0");
}

