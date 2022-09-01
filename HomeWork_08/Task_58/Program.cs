//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

void PrintMatrix(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
	for(int j = 0; j < arr.GetLength(1); j++)
	{
	    Console.Write($"{arr[i, j]} ");
	}
	Console.WriteLine();
    }
}

int[,] FindProductMatrices(int[,] arr1, int[,] arr2)
{
    int[,] newMatrix = new int[arr1.GetLength(0), arr2.GetLength(0)];
    for(int i = 0; i < arr1.GetLength(0); i++)
    {
	for(int j = 0; j < arr2.GetLength(0); j++)
	{
	    for(int k = 0; k < arr2.GetLength(1); k++)
	    {
	        newMatrix[i, k] += arr1[i, j] * arr2[j, k];
	    }
	}
    }
    return newMatrix;
}

int[,] matrix1 = {
		{2, 4},
		{3, 2}
};

int[,] matrix2 = {
		{3, 4},
		{3, 3}
};

Console.WriteLine("Первая матрица");
PrintMatrix(matrix1);
Console.WriteLine("Вторая матрица");
PrintMatrix(matrix2);
Console.WriteLine("Произведение матриц");
PrintMatrix(FindProductMatrices(matrix1, matrix2));