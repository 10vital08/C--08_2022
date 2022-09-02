//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void PrintNumbers(int index, int num)
{
    Console.Write($"{index} ");
    if (index < num)
    {
        PrintNumbers(index + 1, num);
    }

}

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNumbers(m, n);