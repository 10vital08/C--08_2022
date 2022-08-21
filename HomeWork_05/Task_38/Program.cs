double[] array = { 1, 3, 4.1, -5.3, 6.8 };

PrintArray(array);//вывести массив
double difference = FindDifference(array);//посчитать разницу между минимальным и максимальным элементом массива
Console.WriteLine();
Console.WriteLine($"Разница между минимальным и максимальным элементом равна: {difference}");

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} | ");
    }
}

double FindDifference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max - min;
}