double SearchDistance(int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    double sqrtCoord = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2) + Math.Pow((Bz -Az), 2));
    return sqrtCoord;
}

Console.Write("Задайте x первой координаты: ");
int coordAx = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте у первой координаты: ");
int coordAy = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте z первой координаты: ");
int coordAz = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте x второй координаты: ");
int coordBx = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте у второй координаты: ");
int coordBy = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте z второй координаты: ");
int coordBz = Convert.ToInt32(Console.ReadLine());

double result = SearchDistance(coordAx, coordAy, coordAz, coordBx, coordBy, coordBz);
Console.WriteLine(result);