// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Задача34");
void FillArray(int[] collection)    //Метод который сами опишем 
                                    //+ Дадим наименование Методу
                                    //Void метод ничего не возвращает 
                                    //Return не используем в коде 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        Console.WriteLine("Массив " + collection[index]);
        index++;
    }
}

void PrintArray(int[] col)   //Метод Войд который будет печатать массив
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        if (col[position] % 2 == 0)
            Console.WriteLine("Четные числа массива " + col[position]);
        position++;
    }
}

int[] array = new int[10]; //в массиве будет 10 элементов 
                           //new int [10] дословно создай новый массив в котором будет 10 элементов

FillArray(array);
PrintArray(array);