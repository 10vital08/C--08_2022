//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void PrintArray(double[] array4)
{
    Console.WriteLine("Среднее арифметическое столбцов:");
    for(int i = 0; i < array4.Length; i++)
    {
	Console.Write($"{array4[i]} ");
    }
}

void PrintArray2d(int[,] array2)
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

double[] AvgElement(int[,] array3)
{
    double[] avg = new double[array3.GetLength(1)];
    double sum = 0;
    for(int j = 0; j < array3.GetLength(1); j++)
    {
        for(int i = 0; i < array3.GetLength(0); i++)
        {
            sum += array3[i, j];
        }
	avg[j] = sum / array3.GetLength(0);
	sum = 0;
    }
    return avg;
}

int[,] array = {
		{1, 4, 7, 2},
		{5, 9, 2, 3},
		{8, 4, 2, 4}
};

PrintArray2d(array);
Console.Write("Среднее арифметическое столбцов: ");
double[] avg = AvgElement(array);
PrintArray(avg);