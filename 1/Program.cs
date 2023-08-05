// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumbersLine(int numberFirst, int numberLast)
{
    if (numberFirst > numberLast) return $"{numberFirst}, " + NumbersLine(numberFirst - 1, numberLast);
    return Convert.ToString(numberLast);
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numN = GetInfo("Введите число N: ");
int numM = 1;
Console.WriteLine($"N = {numN} -> {NumbersLine(numN, numM)}");