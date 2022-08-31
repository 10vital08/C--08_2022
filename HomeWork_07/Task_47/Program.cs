//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

double[,] FillArray(int m, int n)
{
    Random random = new Random();
    double[,] array = new double[m, n];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(random.Next(-10, 100)) / 10;
        } 
    }
    return array;
}

void PrintArray(double[,] array2)
{
    for(int i = 0; i < array2.GetLength(0); i++)
    {
        for(int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i, j]} ");
        }
	Console.WriteLine();
    }
}

Console.WriteLine("Введите размер массива");
Console.Write("m = ");
int countM = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int countN = Convert.ToInt32(Console.ReadLine());
double[,] array1 = FillArray(countM, countN);

PrintArray((array1));