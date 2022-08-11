void FindADay(int day)
{
    if (day > 0 && day <8)
    {
        if (day <= 5)
        {
            Console.WriteLine("Это будний день");
        }
        else Console.WriteLine("Этот день выходной");
    }
    else Console.WriteLine("Введите корректную цифру");
    
}

Console.Write("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
FindADay(number);