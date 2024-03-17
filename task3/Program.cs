// Задайте произвольный массив. Выведите его элементы, начиная с конца. Использовать рекурсию. 

using System.Globalization;

int[] numbers = { 3, 2, 7, 6, 5, 8 }; 

void PrintElementsReverse(int[] array, int index)
{
    if (index >= 0)
    {
        System.Console.WriteLine(array[index]);
        PrintElementsReverse(array, index - 1);
    }
}

PrintElementsReverse(numbers, numbers.Length - 1);