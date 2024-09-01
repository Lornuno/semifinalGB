//Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию.

Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

PrintNaturalNumbers(m, n);

void PrintNaturalNumbers(int current, int n)
{
    if (current <= n)
    {
        Console.Write(current + " ");
        PrintNaturalNumbers(current + 1, N);
    }
}
