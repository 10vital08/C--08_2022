int[] GenerateNumber(int N)
{
    int[] array = new int[N];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
    return array;
}

void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
}

Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = GenerateNumber(n);
PrintArray(arr);