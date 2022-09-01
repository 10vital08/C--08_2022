//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

int[,,] FillArray3d()
{
    Random random = new Random();
    int[,,] arr = new int[2, 2, 2];
    int temp = 0;

    for(int i = 0; i < arr.GetLength(0); i++)
    {
	for(int j = 0; j < arr.GetLength(1); j++)
	{
	    for(int k = 0; k < arr.GetLength(2); k++)
	    {
		temp = random.Next(10, 100);
		while(CheckNumber(arr, temp) != false)
		{
		    temp = random.Next(10, 100);
		    CheckNumber(arr, temp);
		}
		arr[i, j, k] = temp;
	    }
	}
    }
    return arr;
}

bool CheckNumber(int[,,] arr, int num)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
	for(int j = 0; j < arr.GetLength(1); j++)
	{
	    for(int k = 0; k < arr.GetLength(2); k++)
	    {
	        if(num == arr[i, j, k])
		{
		    return true;
		}
	    }
	}
    }
    return false;
}

void PrintArray3d(int[,,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
	for(int j = 0; j < arr.GetLength(1); j++)
	{
	    for(int k = 0; k < arr.GetLength(2); k++)
	    {
	        Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
	    }
	    Console.WriteLine();
	}
    }
}

int[,,] array = FillArray3d();
PrintArray3d(array);