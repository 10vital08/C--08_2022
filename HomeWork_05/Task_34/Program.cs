Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];

PrintArray(FillArray(array, length));//вывести массив, заполненный случайными трёхзначными числами
int countEv = CountEven(array);//посчитать количество чётных чисел
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел: {countEv}");

int[] FillArray(int[] arr, int n)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int CountEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}