int CalculatedSum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;//получаем остаток от деления на 10
        num = num / 10;//отсекаем последнюю посчитанную цифру
    }
    return sum;
}

Console.Write("Введите число: ");
string number = Console.ReadLine();
bool isNum = int.TryParse(number, out int result);//определение, является ли числом

int resultSum = 0;//сумма цифр числа

if (isNum == true)
{
    resultSum = CalculatedSum(Convert.ToInt32(number));
    Console.WriteLine(resultSum);
}
else Console.WriteLine("Введите число типа int");

