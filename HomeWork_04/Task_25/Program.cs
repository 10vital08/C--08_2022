int RaisePower(int A, int B)
{
    int result = Convert.ToInt32(Math.Pow(A, B));
    return result;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int resultNumber = -1;

if (numberB > 0)
{
    resultNumber = RaisePower(numberA, numberB);
    Console.WriteLine($"A в степени B = {resultNumber}");
}
else Console.WriteLine("Введите натуральные числа");