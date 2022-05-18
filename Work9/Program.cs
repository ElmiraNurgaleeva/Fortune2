//Задача 18: Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).

Console.WriteLine("введите номер четверти : ");
int nunber = int.Parse(Console.ReadLine());
// можно использовать var вместо int  Это универсальная переменная! Здесь результат тотже
//так как здесь ReadLine то это тип данных Строковой а у нас число, нельзя сравнить строку с числом, 
//соотвественно кавычки оставляем! "1" "2" Например 
//Console.WriteLine("введите номер четверти : ");
//int nunber = Console.ReadLine();   без конвертации строки в int  ! тогда все цифры указать в ковычках
//Если есть конвертация строки в int  : int nunber = int.Parse(Console.ReadLine())   - то ковычки у числе не нужны !

if (nunber == 1)
{
    Console.WriteLine("x > 0 и y > 0");
}
else if (nunber == 2) 
{
    Console.WriteLine("x < 0 и y > 0");
}
else if (nunber == 3)
{
    Console.WriteLine("x < 0 и y < 0");
}
else if (nunber == 4)
{
    Console.WriteLine("x > 0 и y < 0");
}

