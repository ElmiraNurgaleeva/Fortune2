// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Задача36");
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        Console.WriteLine("Массив " + collection[index]);
        index++;
    }
}

void PrintArray(int[] col)   //Метод Войд который будет печатать массив
{
    int count = col.Length;
    int position = 0;
    int sum = 0;

    while (position < count)
    {
        if (col[position] % 2 != 0)
            Console.WriteLine("Нечетные элементы массива " + col[position]);
        if (col[position] % 2 != 0) sum += col[position];
        position++;
    }
    Console.WriteLine("Сумма нечетных элементов массива равна : " + sum);
}

int[] array = new int[10]; //в массиве будет 10 элементов 
                           //new int [10] дословно создай новый массив в котором будет 10 элементов

FillArray(array);
PrintArray(array);