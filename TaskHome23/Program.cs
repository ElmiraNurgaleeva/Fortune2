//Задача 23: Напишите программу, которая принимает на
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9.
//5 -> 1, 8, 27, 64, 125
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter a number : ");
int num = int.Parse(Console.ReadLine());
int i = 1;

while (i <= num)
{
    {
        Console.WriteLine($"number{i,5} -> cube {(int)(i * i * i),5}");
    }
    i++;
}