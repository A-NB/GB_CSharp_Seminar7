// Знакомство с языками программирования (семинары)
// Урок 7. Рекурсия

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


char[] GetRandomArrayOfChar()
{
    string st = "0123456789abcdefjhijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯЁ~@#$%^&!№;%:?*()_+/-.,\"<>";
    Random rnd = new Random();
    char[] array = new char[rnd.Next(5, 10)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = st[rnd.Next(0, st.Length)];
    }
    return array;
}

void PrintArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

void PrintReverseArray(char[] array, int index)
{
    System.Console.Write(array[index] + " ");
    if (index > 0)
    {
        PrintReverseArray(array, index - 1);
    }
}

char[] array = GetRandomArrayOfChar();
PrintArray(array);
PrintReverseArray(array, array.Length - 1);
