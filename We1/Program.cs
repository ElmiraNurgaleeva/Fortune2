// Если мы перечислим все натуральные числа ниже 10, 
// кратные 3 или 5, мы получим 3, 5, 6 и 9. Сумма этих кратных равна 23.
//Найдите сумму всех чисел, кратных 3 или 5, меньших 1000.

Console.Write("Введите число:\t");
int elemntsCount = int.Parse(Console.ReadLine());
int[] nums = new int[elemntsCount];

Console.WriteLine("Вывод массива:");

for (int i = 0; i < nums.Length; i++)
{
Console.WriteLine(nums[i]);
}

    // arr[i] = int.Parse(Console.ReadLine());

    // void PrintArray(int[] array)
    // {
    //     int count = array.Length;
    //     for (int i = 0; i <= count; i++)
    //     {
    //         Console.WriteLine($"{array[i]}");
    //     }
    //     Console.WriteLine();
    // }
    // int GetSumNumber(int num)
    // {
    //     int sum = 0;
    //     for (int i = 0; i <= num; i++)
    //     {
    //         sum = sum + i;
    //     }
    //     return sum;
    // }

    //int sumResult = GetSumNumber(number);
    //Console.WriteLine($"Сумма чисел равна {nums.Length}");
//PrintArray(arr);
