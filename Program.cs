// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//https://github.com/profimars/C_SharpTask52

void CreateArray(int[,] A)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            A[i, j] = rnd.Next(1, 10);
        }
}

void PrintArray(int[,] A)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write($"{A[i, j],3}   ");
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] A)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    Console.WriteLine();
    double sum = 0;
    double ss = 0;
    double[] B = new double[n];
    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
        {
            sum = sum + A[i, j];
        }
        ss = sum / n;
        sum = 0;
        B[j] = ss;
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int k = 0; k < n; k++)
    {
        Console.Write($"{B[k]}; ");
    }
}

Console.WriteLine("Введите количество строк матрицы m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] A = new int[m, n];
CreateArray(A);
PrintArray(A);
ArithmeticMean(A);
