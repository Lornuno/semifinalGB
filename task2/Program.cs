//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int AkkermansFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermansFunc(m - 1, 1);
    }
    return AkkermansFunc(m - 1, AkkermansFunc(m, n - 1));
}

Console.WriteLine(AkkermansFunc(1, 2));