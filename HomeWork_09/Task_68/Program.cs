//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

int СalculateAckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return СalculateAckermanFunction(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return СalculateAckermanFunction(m - 1, СalculateAckermanFunction(m, n - 1));
    }
    else return n + 1;
}

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0)
{
    Console.Write("Введите положительные числа");
}
else
{
    int numberAkkerman = СalculateAckermanFunction(numberM, numberN);
    Console.WriteLine($"Функция Аккермана от {numberM} и {numberN} = {numberAkkerman}");
}

