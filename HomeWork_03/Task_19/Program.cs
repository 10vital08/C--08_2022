bool CheckPolyndrom(string num)
{
    char[] reverseNum = num.ToCharArray();//перевести строку в массив символов
    Array.Reverse(reverseNum);//развернуть массив
    string polyndromNum = new string(reverseNum);//заполнить строку массивом символов
    if (num == polyndromNum)
    {
        return true;
    }
    else return false;
}

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
if (number.Length == 5)
{
    Console.WriteLine(CheckPolyndrom(number));
}
else Console.WriteLine("Вы ввели не пятизначное число");