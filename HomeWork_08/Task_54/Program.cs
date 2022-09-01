//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

int[,] FillArray(int row, int col)
{
    Random random = new Random();
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(0, 10);
        }
    }
    return arr;
}

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

int[,] ArrangeTheElements(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            //пройти по элементам строки
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    temp = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = temp;
                }
            }
        }
    }
    return arr;
}

Console.WriteLine("Задайте размер массива");
Console.Write("Количество строк = ");
bool isNumRows = int.TryParse(Console.ReadLine(), out int rows);
Console.Write("Количество столбцов = ");
bool isNumColumns = int.TryParse(Console.ReadLine(), out int columns);

//проверка правильности введенных данных
if (isNumRows == false | isNumColumns == false)
{
    Console.WriteLine("Введены некорректные данные");
    return;
}


int[,] array = FillArray(rows, columns);
PrintArray(array);
int[,] newArray = ArrangeTheElements(array);
Console.WriteLine("Отсортированный массив");
PrintArray(newArray);