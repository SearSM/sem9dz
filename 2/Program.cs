// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NumbersLine(int numberFirst, int numberLast)
{
    if (numberFirst < numberLast) return NumbersLine(numberFirst + 1, numberLast) + numberFirst;
    else return numberLast;
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numM = GetInfo("Введите число M: ");
int numN = GetInfo("Введите число N: ");
Console.WriteLine($"M = {numM}, N = {numN} -> {NumbersLine(numM, numN)}");