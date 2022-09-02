//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int FindNaturalSum(int index, int num, int sum)
{
    if (index < 1)
    {
        index = 1;
    }
    if (index - num != 0)
    {
        sum += index;
        return FindNaturalSum(index + 1, num, sum);
    }
    else return sum + index;
}

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < m)
{
    Console.Write("Задайте второе число больше первого");
}
else
{
    int sum = FindNaturalSum(m, n, 0);
    Console.WriteLine($"Сумма натуральных элементов от {m} до {n} = {sum}");
}

