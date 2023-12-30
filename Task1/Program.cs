// Знакомство с языками программирования (семинары)
// Урок 7. Рекурсия

// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

/* Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы. */

int[] GetNumbers()
{
    int value1 = 0;
    int value2 = 0;
    do
    {
        System.Console.Write("Введите первое положительное целое число: ");
        value1 = Convert.ToInt32(Console.ReadLine());
    } while (value1 == 0 || value1 < 0);
    System.Console.WriteLine();
    do
    {
        System.Console.Write("Введите второе положительное целое число, которое больше первого: ");
        value2 = Convert.ToInt32(Console.ReadLine());
    } while (value2 == 0 || value2 <= value1);
    System.Console.WriteLine();
    return [value1, value2];
}

void PrintDigits(int begin, int end)
{
    if (begin <= end)
    {
        System.Console.Write($"{begin} ");
        PrintDigits(begin + 1, end);
    }
}

int[] limits = GetNumbers();
System.Console.WriteLine($"Натуральные числа от {limits[0]} до {limits[1]}:");
System.Console.WriteLine();
PrintDigits(limits[0], limits[1]);

