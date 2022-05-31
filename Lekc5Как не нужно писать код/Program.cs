//Лекция 5  Как не нужно писать код

//Как определить тип данных  ?   Каким образом узгнать тип переменной?

// int a = 12;
// Console.WriteLine(a.GetType());
//Ответ : System.Int32

// int a = 12;
// Console.WriteLine(a.GetType().Name);
//Ответ : Int32

//Это демонстрация что не нужно исп VAR там где не нужно исп!                 

using System.Linq;    //Подключим системные библиотеки
var a = 12;
Console.WriteLine(a.GetType());

var data = new int[] { 1, 2, 3, 4 }
            .Where(e => e > 0)
            .Select(e => new { q = e, w = e + 1 });
Console.WriteLine(data.GetType().Name);