//Найдем максмум из 9 чисел  Функции / Метод и Массивы 

// int a1 = 10;
// int b1 = 12;
// int c1 = 17;
// int a2 = 7;
// int b2 = 9;
// int c2 = 5;
// int a3 = 21;
// int b3 = 1881;
// int c3 = 29;

// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;
// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;
// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

// Console.WriteLine(max);

// Вариант с функцией

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;  //внутренний резалт(переменная) где будет хранится значение макс
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 10;
// int b1 = 12;
// int c1 = 17;
// int a2 = 7;
// int b2 = 9;
// int c2 = 5;
// int a3 = 21;
// int b3 = 1881;
// int c3 = 29998;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max3, max3);

// Console.WriteLine(max);

//еще вариант

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;  //внутренний резалт(переменная) где будет хранится значение макс
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 10;
// int b1 = 12;
// int c1 = 17;
// int a2 = 778951;
// int b2 = 9;
// int c2 = 5;
// int a3 = 21;
// int b3 = 1881;
// int c3 = 29998;

// int max = Max(
//     Max(a1, b1, c1), 
//     Max(a2, b2, c2), 
//     Max(a3, b3, c3));

// Console.WriteLine(max);


//НОВАЯ задача Массив
//Тип данных[] Имя = {Значение1, Значение2, ...}
//int[] array = {9,8,28,32,1990}

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;  //внутренний резалт(переменная) где будет хранится значение макс
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
//     //   Индекс  0   1   2   3  4   5   6   7  8
// int[] array = { 11, 21, 31, 41, 5, 61, 17, 18, 19 };

// Console.WriteLine(array[5]);
// Console.WriteLine(array[0]);

//Найдем максимум

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;  //внутренний резалт(переменная) где будет хранится значение макс
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// //   Индекс  0   1   2   3  4   5   6   7  8
// int[] array = { 11, 21, 31, 41, 5, 61, 17, 18, 19 };

// Console.WriteLine("Число под данным индексом " + array[0]);

// int max = Max(        //Внимание Функция пишется с большой буквы Max, 
//                       //переменная пишется с маленькой max   !!!
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );
// Console.WriteLine("Максимальное число в массиве " + max);

// НОВАЯ задача (Метод Массив)  Поиск позиции нужного элемента массива :

//Индекс    0   1   2   3   4   5   6    7   8   9   10
// int[] array = { 11, 21, 31, 41, 57, 61, 17, 188, 19, 21, 21 };

// int n = array.Length; //n кол-во элементов массива -array.Length Длина массива
// int find = 21;  //Пользователь хочет найти число под индексом 4

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine("Индекс данного числа равен : " + index);
//         break;   //Прерви  - выведется первый индекс найденного числа и все!!!
//     }
//     index = index + 1; // или index++;
// }

//Новая задача: Метод который будет выводить все элементы по порядку :

void FillArray(int[] collection)    //Метод который сами опишем 
                                    //+ Дадим наименование Методу
                                    //Void метод ничего не возвращает 
                                    //Return не используем в коде 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
                           //положить новое случайное число из диапазона от 1 до 10
        index++;
    }
}

void PrintArray(int[] col)   //Метод Войд который будет печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10]; //в массиве будет 10 элементов 
                           //new int [10] дословно создай новый массив в котором будет 10 элементов
                           //по умолчанию массив будет заполнен "0"
FillArray(array);
PrintArray(array);