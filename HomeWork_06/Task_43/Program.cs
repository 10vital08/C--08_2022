double[] FindCoordinate(double B1, double K1, double B2, double K2)
{
    double[] result = new double[2];
    double x = (B2 - B1) / (K1 - K2);
    result[0] = x;
    result[1] = (K1 * x) + B1;
    return result;
}

Console.WriteLine("Введите переменные для двух прямых:");
Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

double[] arrayResult = FindCoordinate(b1, k1, b2, k2);
Console.Write($"Точка пересечения двух прямых = ({arrayResult[0]} ; {arrayResult[1]})");
