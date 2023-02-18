/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Задача №41");
Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь: ");
Console.WriteLine ("Введите целые числа через пробел: "); 
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int CountPositiveElement(int[]array)
{
    int count = 0;
    foreach (var i in array)
    {
        if (i > 0)
            count++;
    }
        return count;
}
Console.WriteLine($"Количество чисел >0:{CountPositiveElement(arr)}");

/*Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine ("Задача №43: ");
Console.WriteLine("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2-b1) / (k1-k2);
double y = k2 * x + b2;
if ((y!=k1 * x + b1) || (k1 - k2 ==0))
Console.WriteLine(" нет решения ");
else
{
    Console.WriteLine($"координаты пересечения двух прямых: ({x}; {y})");
}

