// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

// int n = 12;        //1й вариант решения
// int min = -9;
// int max = 9;

// int[] createArray(int n, int min, int max)
// {
//     int[] array = new int[n];

//     for (int i = 0; i < n; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     возвращаемый массив;
// }

// int[] PutSums(int[] arr)
// {
//     int[] sums = new int[2];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         если (arr[i] < 0) суммы[0] += arr[i];
//         else sums[1] += arr[i];
//     }
//     возврат сумм;
// }

// void PritArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }

// PritArray(PutSums(createArray(n, min, max)));

// // если нужно вывести сам массив, то так:

// int[] array = createArray(n, min, max);
// PritArray(массив);
// PritArray(PutSums(array));




//2й вариант задачи№31 Семинар 5

// Console.Clear();
// Console.WriteLine();

// Console.WriteLine("Задача31");

// Console.Write("Размер массива" + "  ");
// int size = int.Parse(Console.ReadLine());

// int[] nums = new int[size];     //Создаем  массив
// int positive = 0;   //Накопитель для положит чисел  Переменная  Тип int по умолчанию
// int negative = 0;   //Накопитель для отриц чисел                      =0  !

// var newRnd = new Random();
// Console.Write("Массив" + "     ");
// for (int i = 0; i < size; i++)
// {
//     nums[i] = newRnd.Next(-9, 10);

//     Console.Write(nums[i] + " ");
// }
// Console.WriteLine();

// for (int i = 0; i < nums.Length; i++)
// {
//     if (nums[i] > 0) positive += nums[i];  //positive = positive + nums[i]
//     else negative += nums[i];
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма положительных элементов массива = {positive}");

// Console.WriteLine();
// Console.WriteLine($"Сумма отрицательных элементов массива = {negative}");






// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.Write("Введите размер массива :");
// int size = int.Parse(Console.ReadLine());

// int[] num = new int[size];

// var newRnd = new Random();
// for (int i = 0; i < size; i++)
// {
//     num[i] = newRnd.Next(-100, 100);
//     Console.Write(num[i] + " ");
// }
// Console.WriteLine();
// Console.Write("Введите искомое число :");
// int n = int.Parse(Console.ReadLine());

// bool flag = false;

// for (int i = 0; i < size; i++)
// {
//     if (num[i] == n)
//     {
//         flag = true;
//         break;
//     }
// }
// Console.WriteLine(flag ? "Yes" : "No");





// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// Console.Clear();
// Console.WriteLine();

// Console.WriteLine("Задача32");
// Console.Write("Размер массива" + "  ");

// int size = int.Parse(Console.ReadLine());
// int[] array = new int[size];

// var newRnd = new Random();
// Console.WriteLine("Первый массив");

// for (int i = 0; i < size; i++)
// {
//     array[i] = newRnd.Next(-99, 100);
//     Console.Write(array[i] + "  ");

// }
// Console.WriteLine();
// Console.WriteLine("Новый (инверсированный) массив");
// for (int i = 0; i < size; i++)
// {
//     array[i] = array[i] * -1;  //Умножим на -1 каждый эл массива и так его перевернем!
//                                //или (array[i] =- array[i]; - тоже самое)
//     Console.Write(array[i] + "  ");
// }





// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// bool run = true;
// while (run)
// {
//     Console.Clear();
//     Console.WriteLine();

//     Console.WriteLine("Задача35");
//     Console.Write("Размер массива" + "  ");

//     int[] array = new int[123];
//     int count = 0;

//     var newRnd = new Random();

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = newRnd.Next(0, 200);
//         Console.Write(array[i] + "  ");
//     }
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 9 && array[i] < 100)
//             count += 1;
//     }
//     Console.WriteLine("Количество элементов на отрезке от 10 до 99 равно : " + count);
//     Console.WriteLine("Попробуем еще раз? y/n");
//     run = Console.ReadKey().Key == ConsoleKey.Y;
// }




// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine();

    Console.WriteLine("Задача37");
    Console.Write("Размер массива" + "  ");
    int size = int.Parse(Console.ReadLine());

    int[] num = new int[size];


    var newRnd = new Random();
    Console.Write("Массив случайных чисел  : ");

    for (int i = 0; i < size; i++)
    {
        num[i] = newRnd.Next(-10, 10);
        Console.Write(num[i] + "  ");
    }
    Console.WriteLine();

    int[] res = new int[num.Length / 2 + 1];


Console.Write("Произведение пар равно : ");
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = num[i] * num[num.Length - 1 - i];
        Console.Write(res[i] + "  ");
    }

    Console.WriteLine();
    Console.WriteLine("Попробуем еще раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}