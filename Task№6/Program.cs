// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Clear();
Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num == 0) Console.WriteLine($"Пожалуйста введите число отличное от нуля");
else if (Num % 2 == 0) Console.WriteLine($"Введенное число {Num} - четное");
else Console.WriteLine($"Введенное число {Num} - нечетное");

