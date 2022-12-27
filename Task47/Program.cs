// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.


double[,] Fill(int a,int b,int min,int max)
{
    double[,] arr1 = new double[a,b];
    Random rand = new Random(); // Это мне подсказали, не понятно как это работет, буду разбираться на каникулах
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            arr1[i, j] = rand.NextDouble()*10;// здесь тоже не ясно, зачем умножать на 10. Тоже буду разбираться 
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
