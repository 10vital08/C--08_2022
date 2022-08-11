int PrintFirstNumber(int num)
{
    int result = num / 10;//отсечение третьей цифры
    result = result % 10;//найти остаток от деления на 10
    return result;
}

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
var result = PrintFirstNumber(number);
Console.WriteLine(result);
