int ShowCubes(int n)
{
    int cube = Convert.ToInt32(Math.Pow(n, 3));
    return cube;
}


Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.Write($"{ShowCubes(i)} ");
}