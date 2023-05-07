// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] CreateArray(int m, int n, double start, double finish)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random random = new Random();
            array[i, j] = start + random.NextDouble() * (finish - start);
        }
    }
    return array;
}


void PrintArray(double[,] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i != array.GetLength(0) - 1) || (j != array.GetLength(1) - 1))
                Console.Write($"{array[i, j].ToString("F2")}; ");
            else
                Console.WriteLine($"{array[i, j].ToString("F2")}]");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива n=");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапозона start=");
double start = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите окончание диапазона finish=");
double finish = Convert.ToDouble(Console.ReadLine());
if (finish<start) {
    double temp = finish;
    finish = start;
    start = temp;
}


double[,] arr = CreateArray(m, n, start, finish);
PrintArray(arr);

