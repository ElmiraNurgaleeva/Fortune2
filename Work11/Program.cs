//Задача 22: Напишите программу, которая
//принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.WriteLine("Введите число N ");
int number = int.Parse(Console.ReadLine());
int count = 1;

Console.WriteLine("Таблица квадратов следующая : ");

//while (count <= number)
//{
//Console.Write(count * count + "  ");
//count = count + 1;
//}

while (count <= number)
{
    Console.WriteLine($"{count, 5} | {count * count, 5}");
    count = count + 1;
}


