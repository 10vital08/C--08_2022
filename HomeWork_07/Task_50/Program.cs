// Напишите программу, которая на вход принимает число и ищет в двумерном массиве, 
// и возвращает индексы этого элемента или же указание, что такого элемента нет.

int[,] FillArray(int[,] array)
{
    Random random = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 11);
        } 
    }
    return array;
}

void PrintArray(int[,] array2)
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

string CheckIndex(int[,] array3, int N)
{
    string elementIndex = String.Empty;
    for(int i = 0; i < array3.GetLength(0); i++)
    {
        for(int j = 0; j < array3.GetLength(1); j++)
        {
            if (array3[i, j] == N)
	    {
		elementIndex += Convert.ToString(i) + "," + Convert.ToString(j) + " ";
	    }
        }
    }
    return elementIndex;
}


Console.WriteLine("Введите размер массива");
Console.Write("Количество строк = ");
int countRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов = ");
int countColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[countRows,countColumns];
PrintArray(FillArray(array));

Console.Write("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
string allIndexElement = CheckIndex(array, number);
if (allIndexElement != "")
{
    Console.WriteLine($"Индексы элементов {allIndexElement}");
}
else Console.WriteLine("Такого элемента нет в массиве");