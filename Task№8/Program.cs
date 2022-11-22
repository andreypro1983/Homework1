// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
bool find = false; //переменная для определения, найдено ли хоть одно целое число
int count = 1;
if (n == 0) Console.WriteLine("Введено недопустимое значение ноль");
else
{
    while (count <= n)
    {
        if (count % 2 == 0)
        {
            Console.Write($"{count} ");
            find = true;
        }
        count++;
    }
    if (find == false)
        Console.WriteLine($"Целых четных чисел в интервале от 1 до {n} не найдено");
}