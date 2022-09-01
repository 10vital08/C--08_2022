//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindMax(int[,] arr)
{
    int[] arrOne = new int[arr.GetLength(0)];
    int sum = 0;
    int minRow = 0;//строка с минимальной суммой элементов
    int minIndex = 1;

    //нахождение суммы элементов строк
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        arrOne[i] = sum;
    }

    //нахождение строки с минимальной суммой элементов
    minRow = arrOne[0];
    for (int i = 1; i < arrOne.Length; i++)
    {
        if (arrOne[i] < minRow)
        {
            minRow = arrOne[i];
            minIndex = i + 1;
        }
    }
    return minIndex;
}

int[,] array = {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {0, 0, 1, 4},
        {5, 2, 6, 7}
};

PrintArray(array);
Console.WriteLine();
//int result = FindMax(array);
Console.WriteLine($"{FindMax(array)} строка с минимальной суммой элементов");
