Console.Write("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2){
    Console.WriteLine("Максимальное число: " + number_1);
}
if (number_2 > number_1){
    Console.WriteLine("Максимальное число: " + number_2);
}
else if (number_1 == number_2){
    Console.WriteLine("Введите разные числа");
}