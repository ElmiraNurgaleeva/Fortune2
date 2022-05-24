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


// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите размер массива :");
int size = int.Parse(Console.ReadLine());

int[] num = new int [size];
 

var  newRnd = new Random();
for(int i = 0; i < size; i++)
{
    num[i] = newRnd.Next(-100, 100);
    Console.Write(num[i] + " ");
}
Console.WriteLine();
Console.Write("Введите искомое число :");
int n = int.Parse(Console.ReadLine());

bool flag = false;

for (int i = 0; i < size; i++)
{
    if (num[i] == n) 
    {
        flag = true;
        break;
    }
}
Console.WriteLine(flag ?  "Yes": "No");

