void PrintFirstNumber(int num)
{
    int result = num / 10;//отсечение третьей цифры
    result = result % 10;//найти остаток от деления на 10
    Console.WriteLine(result);
}

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintFirstNumber(number);