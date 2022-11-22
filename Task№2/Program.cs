// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
Console.Write("Введите первое число: ");
int NumA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int NumB = int.Parse(Console.ReadLine());
if (NumA > NumB) Console.WriteLine($"Из двух введеных чисел число {NumA} больше числа {NumB}");
else if (NumA < NumB) Console.WriteLine($"Из двух введеных чисел число {NumB} больше числа {NumA}");
else Console.WriteLine($"Числа {NumA} и {NumB} равны");