string FindADay(int day)
{
    string output = "";
    if (day > 0 && day <8)
    {
        if (day <= 5)
        {
            output = "Это будний день";
        }
        else output = "Этот день выходной";
    }
    else output = "Введите корректную цифру";
    
    return output;
}

var result = "";
Console.Write("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

result = FindADay(number);
Console.WriteLine(result);