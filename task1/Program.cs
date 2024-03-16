// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы. 

//---------------ОБЪЯВЛЕНИЕ ФУНКЦИЙ----------------
using System.Globalization;

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int BiggerOne(int M, int N)
{
    if (M > N)
    {
        return M;
    }
    else
        return N;
}

int SmallerOne(int M, int N)
{
    if (M < N)
    {
        return M;
    }
    else
        return N;
}

void PrintNumbers(int M, int N)
{
    if (SmallerOne(M, N) >= BiggerOne(M, N))
    {
        System.Console.Write(SmallerOne(M, N) + " ");
        return;
    }
    PrintNumbers((BiggerOne(M, N) - 1), SmallerOne(M, N));
    System.Console.Write(BiggerOne(M, N) + " ");
}

//---------------ОСНОВНОЙ КОД----------------------
int N = ReadInt("введите первое число: ");
int M = ReadInt("введите второе число: ");
System.Console.WriteLine();
PrintNumbers(M, N);
