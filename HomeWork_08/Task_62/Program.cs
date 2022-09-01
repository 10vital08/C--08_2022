//Напишите программу, которая заполнит спирально массив 4 на 4

int[,] FillArray(int row, int col)
{
    int[,] arr = new int[row, col];
    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;//точки конца сторон прямоугольника
    int k = 1;//начать заполнение с 1
    int i = 0, j = 0;//счётчики
    while (k <= row * col)
    {
        arr[i, j] = k;
        if (i == Ibeg && j < row - Jfin - 1)
            j++;
        else if (j == row - Jfin - 1 && i < col - Ifin - 1)
            i++;
        else if (i == col - Ifin - 1 && j > Jbeg)
            j--;
        else
            i--;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != row - Jfin - 1))
        {
            Ibeg++;
            Ifin++;
            Jbeg++;
            Jfin++;
        }
        k++;
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j] < 10)
            {
                Console.Write($"0{arr[i, j]} ");
            } 
            else Console.Write($"{arr[i, j]} ");
            
        }
        Console.WriteLine();
    }
}

Console.Write("Задайте размерность матрицы = ");
bool isNurow = int.TryParse(Console.ReadLine(), out int rows);

//проверка правильности введенных данных
if (isNurow == false)
{
    Console.WriteLine("Введены некорректные данные");
    return;
}

int[,] array = FillArray(rows, rows);
PrintArray(array);