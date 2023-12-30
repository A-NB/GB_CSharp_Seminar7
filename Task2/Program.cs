// Знакомство с языками программирования (семинары)
// Урок 7. Рекурсия

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int[] GetNumbers()
{
    int value1 = 0;
    int value2 = 0;
    do
    {
        System.Console.Write("Введите первое неотрицательное целое число: ");
        value1 = Convert.ToInt32(Console.ReadLine());
    } while (value1 < 0);
    System.Console.WriteLine();
    do
    {
        System.Console.Write("Введите второе неотрицательное целое число: ");
        value2 = Convert.ToInt32(Console.ReadLine());
    } while (value2 < 0);
    System.Console.WriteLine();
    return [value1, value2];
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int[] parameters = GetNumbers();
System.Console.Write($@"Значение функции Аккермана для m = {parameters[0]} и n = {parameters[1]} равно {Akkerman(parameters[0], parameters[1])}");
