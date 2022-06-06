//Урок 2: примитивные типы данных, строки.

// Console.WriteLine("Как тебя зовут ?");
// string name = Console.ReadLine();
// Console.WriteLine($"Привет,  {name}!");
// int age = 20;
// string q = $"Вам {age} лет";
// Console.WriteLine($"Вам  {q}!");

// Урок 3: bool логика, сравнения, поток выполнения, if Для начинающих
//bool истина или ложь

// bool no = false;
// bool yes = true;
// Console.WriteLine(2*3==6);


// bool no = false;
// bool yes = true;
// Console.WriteLine($"7 > 5 : {7 > 5}");
// Console.WriteLine($"7 > 9 : {7 > 9}");
// Console.WriteLine($"7 < 8 : {7 < 8}");
// Console.WriteLine($"7 == 8 : {7 == 8}");
// Console.WriteLine($"10 >= 8 : {10 >= 8}");
// Console.WriteLine($"11 <= 8 : {11 <= 8}");

// int i = 0;
// if (i > 0)
// {
//     Console.WriteLine("Считаем");
// }
// else
// {
//     Console.WriteLine("Решение не возможно");
// }


// int i = 5;
// if (i<= 0)
// {
//     Console.WriteLine("<= 0");
// }
// else if (i>= 0)
// {
//     Console.WriteLine(">= 0");
// }
// else 
// {
//     Console.WriteLine("== 0");
// }

// int i = 2;

// switch (i)
// {
//     case 0:
//     Console.WriteLine("Ноль");
//     break;
//     case 1:
//     Console.WriteLine("Единица");
//     break;
//     case 2:
//     Console.WriteLine("Двойка");
//     break;
//     default:
//     Console.WriteLine("Другое число");
//     break;
// }


// Console.WriteLine("Введите ваше имя : ");
// string name = Console.ReadLine();

// switch (name)
// {
//     case "Роза":
//         name = "Розалинда";
//         break;

//     case "Александр":
//         name = "Саша";
//         break;

//     default:
//         break;
// }
// Console.WriteLine($"Привет  {name} ");




// int money = 100;
// int minPrice = 20;

/*0---5---10---20-----100------бесконечность
*/

// Console.WriteLine("Введите цену товара : ");
// int price = int.Parse(Console.ReadLine());

// Console.WriteLine();
// Console.WriteLine("Вариант № 1 Логическая И $$");

// //покупаем товары от 20 до 100р
// if (minPrice <= price && price <= money)
// {
//     Console.WriteLine("Покупаем");
// }
// else
// {
//     Console.WriteLine("Не покупаем");
// }

// Console.WriteLine();
// Console.WriteLine("Вариант № 2 Логическое ИЛИ  ||");

// //Товары меньше 20 или товары больше 100р нам не подходят
// if (price < minPrice || price > money)
// {
//     Console.WriteLine("Не покупаем");
// }
// else
// {
//     Console.WriteLine("Покупаем");
// }

// Console.WriteLine();
// Console.WriteLine("Вариант № 3 ! НЕ  Логическое ИЛИ  ||");
// //Покупаем все кроме товаров меньше 20 или товаров больше 100 Покупаем

// if (!(price < minPrice || price > money))
// {
//     Console.WriteLine("Покупаем");
// }
// else
// {
//     Console.WriteLine("Не покупаем");
// }




// Урок 4 - массивы и циклы. На примере решения мини задачи.
//Таблица умножения 


// int[] array = new int[10];
// for (int i = 10; i > 0; i--)
// {
//     Console.WriteLine(i);
// }

// int k = 13;
// while (k>0)
// {
//     Console.WriteLine(k);
//     k--;
// }

// int k = 13;
// do
// {
//    Console.WriteLine(k); 
// } while (k<10);


// int k = 13;
// do
// {
//    Console.WriteLine(k); 
//    k++;
// } while (k<17);

//Массив строк

// string[] days = new string[7] {"Понед", "Вт", "Ср", "Чет", "Пят", "Субб", "Воскр"}; 
// foreach (string day in days)
// {
//     Console.WriteLine(day); 
// }




//Новая задача Массив табл умножения 5*5  1й вариант ЦИКЛ for:

// int[,] n = new int [5,5];

// for (int i = 0; i<5;i++)
// {
//     n[0,i] = 1*(i+1);
// }
// for (int i = 0; i<5;i++)
// {
//     n[1,i]=2*(i+1);
// }
// for (int i =0; i<5;i++)
// {
//     n[2,i]=3*(i+1);
// }
// for (int i =0; i<5;i++)
// {
//     n[3,i]=4*(i+1);
// }
// for (int i =0; i<5;i++)
// {
//     n[4,i]=5*(i+1);
// }
// for (int i =0; i<5;i++)
// {
//     Console.WriteLine($"\t{i+1}"); 
// }
// for (int i =0; i<5;i++)
// {
//     Console.WriteLine($"{i+1},\t{n[i,0]}\t{n[i,1]}\t{n[i,2]}\t{n[i,3]}\t{n[i,4]}"); 
// }


//Новая задача Массив табл умножения 5*5 2й вариант Вложенные циклы:

int[,] n = new int [5,5];

for (int i = 0; i< 5; i++)
{
    for (int j = 0; j< 5; i++)
    {
        n[i, j] = (i + 1) * (j + 1);
    }
}
for (int i =0; i<5;i++)
{
    Console.Write($"\t{i+1}"); 
}
Console.WriteLine(); 

for (int i=0; i<5; i++)
{
    Console.Write($"{i+1}"); 
    for (int j = 0; j< 5; j++)
    {
        Console.Write($"\t{n[j,i]}"); 
    }

    Console.WriteLine(); 
}
