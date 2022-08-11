string PrintThreeNumber(string num)
{
    string output = "";
    if (num.Length < 3)
    {
        output = "Третьей цифры нет";
    }
    else output = ($"Третья цифра {num[2]}");//вывести третий символ строки
    
    return output;
}

Console.Write("Введите число: ");
string number = Console.ReadLine();
string threeNumber = PrintThreeNumber(number);
Console.WriteLine(threeNumber);