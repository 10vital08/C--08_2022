void PrintThreeNumber(string num)
{
    if (num.Length < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else Console.WriteLine($"Третья цифра {num[2]}");//вывести третий символ строки
}

Console.Write("Введите число: ");
string number = Console.ReadLine();
PrintThreeNumber(number);