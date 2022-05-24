// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine();

Console.WriteLine("Задача38");

double[] array = { 2, 3, 4, 5, 6.13, 7, 8, 9, 10, 20.12 };
Console.WriteLine();
Console.Write("Массив вещественных чисел : " + "2, 3, 4, 5, 6.13, 7, 8, 9, 10, 20.12");
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

Console.WriteLine();
Console.Write("Max равен : " + max);
Console.WriteLine();
Console.Write("Min равен : " + min);
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементом равна : ");
Console.Write(max - min);