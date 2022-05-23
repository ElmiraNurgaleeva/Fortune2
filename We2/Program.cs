// //инверсия массива, то есть переворот его в обратном порядке:

// int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4, 12, 7, 74,75 };

// int n = numbers.Length; // длина массива
// int k = n / 2;          // середина массива
// int temp;               // вспомогательный элемент для обмена значениями
// for (int i = 0; i < k; i++)
// {
//     temp = numbers[i];
//     numbers[i] = numbers[n - i - 1];
//     numbers[n - i - 1] = temp;
// }
// foreach (int i in numbers)
// {
//     Console.Write($"{i} \t");
// }


//Alexander Novikov, [22.05.2022 23:34]
// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int sumDigit = SumNum(number);

// Console.WriteLine(sumDigit);

// int SumNum(int number)
// {
//     int rem = 0;
//     int sumDigit = 0;

//     while (number > 0)
//     {
//         rem = number % 10;
//         sumDigit = sumDigit + rem;
//         number = number / 10;
//     }

//     return sumDigit;
// }


// int[] numbers = { 1, 2, 3, 5};
// numbers [i] = 0
 
// //Console.WriteLine(numbers[numbers.Length - 1]);
// Console.WriteLine( [i]); 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 3, 5, -4, 6, 9, 56, 34, 12, 0, -9, 4, -2, 8, -5, -12, 0, 9 };
            int min = intArray.Min();
            int min_index = Array.FindIndex(intArray, delegate(int i)
            {
                return i == min;
            });
            Console.WriteLine("Minimum value in array is: {0}, index of minimum value is: {1}",
                              min,min_index);
 
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 != 0)
                {
                    Console.WriteLine("Index: {0}, Value: {1}", i, intArray[i]);
                }
            }
            Console.ReadLine();
        }
    }
}