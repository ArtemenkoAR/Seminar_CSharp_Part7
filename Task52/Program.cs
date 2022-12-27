// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

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

double[] Average(int[,] array) // Сделал по вашему примеру, буду еще раз пересматривать семинар и разбираться
{
    double[] res = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum+= array[i,j];
        }
        res[j] = Math.Round(sum/array.GetLength(0),2);
    }
    return res;
}

int[,] array = FillArray(3, 4, 0, 10);
Print(array);
Console.WriteLine();
double[] array1 = Average(array);
Console.WriteLine($"Среднее арифметическое = {String.Join(" ", array1)}");

