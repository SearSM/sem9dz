// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkerFunction(int numberN, int numberM)
{
    if (numberN == 0) return numberM + 1;
    else if (numberM == 0) return AkkerFunction(numberN - 1, 1);
    return AkkerFunction(numberN - 1, AkkerFunction(numberN, numberM - 1));
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numM = GetInfo("Введите число M: ");
int numN = GetInfo("Введите число N: ");
Console.WriteLine($"m = {numM}, n = {numN} -> A({numM},{numN}) = {AkkerFunction(numM, numN)}");