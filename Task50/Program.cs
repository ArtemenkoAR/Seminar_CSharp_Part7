// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillArray(int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void Print(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Array(int[,] array2, int M)
{
    int[,] array = new int[array2.GetLength(0), array2.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if (M == array2[i, j])
                sum++;
        }
    }
    if (sum > 0)
        Console.WriteLine($"{M}--> такое число в массиве есть");
    else
        Console.WriteLine($"{M}--> такого числа в массиве нет");
}

Console.Write("Введите число для проверки наличия его в массиве: ");
int N = int.Parse(Console.ReadLine()!);
int[,] array = FillArray(3, 4, -10, 10);
Print(array);
Console.WriteLine();
Array(array, N);
