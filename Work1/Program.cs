//Задача 1  Напишите программу, которая выводит случайное число 
//из отрезка [10, 99] и показывает наибольшую цифру числа. 
//Пример  78 -> 8    12-> 2    85 -> 8

int number = new Random().Next(10, 100); //Случайное число из отрезка 10 - 99
Console.WriteLine($"Number = {number} ");  //Проверим выведем в консоль Название и число

int firstDigit = number / 10;   //Сначала нужно найтие 1е число 98/10 =9,8 int уберет все до точки, останется 9
int secondDigit = number % 10;  //Находим 2е число, остаток отделения 98/10 =9,8 остаток от деления 8
                                //2 отдельных числа наши 9 и 8 теперь сравним
Console.WriteLine($"Number 1 = {firstDigit} ");
Console.WriteLine($"Number 2 = {secondDigit} ");  //знак $ нужен чтобы писать текст вместе с переменной
                                                  //Сравним полученные 2 числа, показать наибольшее число
                                                  //Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit); //Если 1е число больше 2го тогда выводим 1е, иначе 2е
                                                  // это и делает знак ? это символ тернарного оператора 
                                                  // "?" ":" то есть сравнение правда или ложь
                                                  //"?" тогда, иначе ":" выводим другое число
                                                  //или
Console.WriteLine(firstDigit > secondDigit ? $"Max = {firstDigit}" : $"Max = {secondDigit}");
//или без тернарного оператора "?"
//if (firstDigit == secondDigit) 
//     Console.WriteLine($"Max = {firstDigit}");
//else 
//     Console.WriteLine($"Max = {secondDigit}");