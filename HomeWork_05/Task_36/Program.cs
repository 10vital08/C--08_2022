Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];

PrintArray(FillArray(array, length));//вывести массив, заполненный случайными числами
int sumNotEven = CountEven(array);//посчитать количество элементов с нечётными индексами
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива с нечётными индексами: {sumNotEven}");

int[] FillArray(int[] arr, int n)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-100, 100);
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
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum += arr[i];
    }
    return sum;
}