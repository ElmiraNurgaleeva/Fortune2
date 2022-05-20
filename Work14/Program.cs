//Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = (new Random().Next(0, 2));
//     Console.WriteLine(array[i] + " ");

// }
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 != 0)
//     {
//         array[i] = 0;
//         Console.WriteLine(array[i] + " ");
//     }
// }

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

System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int GetComNumbers(int num)
{
    int com = 1;

    for (int i = 1; i <= number; i++)
    {
        com = com * i;
    }
    return com;
}
System.Console.WriteLine(GetComNumbers(number));
        
