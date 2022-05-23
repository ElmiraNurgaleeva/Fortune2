//Методы Вид2

//void Method21(string msg, int count)
//{
//int i = 0;
//while (i < count)
//{
// Console.WriteLine(msg);
// i++;
//}
//}
//Method21(msg: "Текст", count: 4);  ИЛИ
//Method21(msg: "НовыйТекст", count: 4);

//Вид 3

//int Method3()
//{
//return DateTime.Now.Year;
//}

//int year = Method3();
//Console.WriteLine (year);

//Вид4 Методы Что то прнимают и что то возвращают

//string Method4(int count, string text)
//{
// int i = 0;
//string result = String.Empty;

//while (i < count)
//{
// result = result + text;
// i++;
//}
//return result;
//}

//string res = Method4(10, "zzzz");
//Console.WriteLine(res);

//ЦИКЛ  For цикл собирает все в кучу Цикл со счетчиком :

//string Method4(int count, string text)
//{

//string result = String.Empty;
//for(int i = 0; i < count; i++) 
//{
// result = result + text;
//}
//return result;
//}

//string res = Method4(10, "zz");
//Console.WriteLine(res);



//Новая задача :  Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”.

string text = " Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого"
+ "Винценгероде, вы бы взяли приступом согласие"
+ "прусского короля. Вы так красноречивы. Вы"
+ "дадите мне чаю? ";

//Внимание :  string s = "Слово"
//                        01234
//s[3]  это символ "в"

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;  //это инициаизация пустой строки

//     int length = text.Length;
//     for (int i = 0; i < length; i++) // с помощью цикла for  пробегаемся от
//                                     // нулевого символа до конца длинны всей строки
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}"; 
//                                 //резалт присвоить обязательно! резалт + новая строка
//         else result = result + $"{text[i]}";   //если совпадений не обнаружено то в резалт  
//                                     //положить текущий символ, который и был
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');  //Пробелы в тексте заменим на | 
// Console.WriteLine(newText);

// Console.WriteLine();  //это разделитель текста, некий разрыв для наглядности

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

// Console.WriteLine();  //разрыв

// newText = Replace(newText, 'у', 'У');
// Console.WriteLine(newText);

//Новая задача : Упорядочить данные в массиве -  Здесь ЦИКЛ внутри ЦЫКЛА!!!!
//Метод  Выбор максимального или минимального
//Функции в программировании

// 1. Найти позицию минимального элемента
// в неотсортированной части массива
// 2. Произвести обмен этого значения со
// значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные
// элементы

//Напишем массив

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

//Отдельный метод вывести массив

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

//Пишем Метод который будет упорядочивать данный массив:

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length - 1; j++)  //ищем миним элемент
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];    //замена элементов то есть СВАП
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);


//Цикл for и выведем таблицу умножения Цикл в Цикле :

//for (int i = 2; i < 10; i++)
//{
    //for (int j = 2; j < 10; j++)
    //{
        //Console.WriteLine($"{i} * {j} = {i * j}");
    //}
    //Console.WriteLine();  //Переход на новую строку Чтобы таблица 
                          //умножения смотрелась удобнее 
                          //Это искуственный разрыв
//}