int CalculatedSum(string num)
{
    var array = num.Split("").Select(int.Parse).ToArray();
    int numberSum = 0;//сумма цифр числа
    //int[] numberArray = {array.Length};//массив цифр


    /*for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(num[i]);
    }*/

    for (int i = 0; i < array.Length; i++)
    {
        numberSum += array[i];//суммирование элементов массива, преобразованных в int
    }
    return numberSum;
}

Console.Write("Введите число: ");
string number = Console.ReadLine();
bool isNum = int.TryParse(number, out int result);
int resultSum = 0;//сумма цифр числа

//if (isNum == true)
//{
    resultSum = CalculatedSum(number);
    Console.WriteLine(resultSum);
//}
//else Console.WriteLine("Введите число типа int");

