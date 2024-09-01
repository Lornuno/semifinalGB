// Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.


int[] array = { 3, 7, 8, 0, 44, 25 };
PrintArrayReversed(array, array.Length - 1);
static void PrintArrayReversed(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " ");
        PrintArrayReversed(array, index - 1);
    }
}
