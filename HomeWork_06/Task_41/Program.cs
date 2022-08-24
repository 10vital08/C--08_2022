int CountNum(int[] num)
{
    int result = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if(num[i] > 0)
        {
            result++;
        }
    }
    return result;
}

Console.WriteLine("Задайте целые числа через пробел или запятую");
string numbers = Console.ReadLine();
int[] numb = Array.ConvertAll(numbers.Split(new char[]{' ', ','}, 
            StringSplitOptions.RemoveEmptyEntries), x=> Int32.Parse(x));

Console.WriteLine($"Количество чисел больше нуля равно {CountNum(numb)}");

/*
Split разобъет строку на массив из строк, используя пробел и, как разделители 
(если надо - пробел уберите), удаляя пустые вхождения.

Array.ConvertAll тут преобразует массив строк в массив целых чисел. 
Вылетит исключение, если будет то, что посчитается не числом.
*/