// Задача 47: Задайте двумерный массив размером m×n,заполненный случайными вещественными числами.m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] Fill(int a,int b, int min, int max)
{
    double[,] arr1 = new double[a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            arr1[i, j] = Convert.ToDouble(new Random().NextDouble(min, max))/10  // Скажу честно - это подсмотрел,но не понимаю,как это работет.
                                                                                // Что мы конвертируем и почему делим на 10? 
        }
    }
    return arr1;
}

void Print(double[,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            Console.Write($"{arr2[i, j]} ");
        }
        Console.WriteLine();
    }
}
double[,] array = Fill(3, 4, -10, 10);

Print(array);
