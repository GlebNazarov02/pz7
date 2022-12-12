void Print(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{arr[i, j],6} ");
        }
        Console.WriteLine();
    }

}

double[,] MassNums(int s1, int s2, int from, int to)
{
    double[,] arr = new double[s1, s2];

    for (int i = 0; i < s1; i++)
    {
        for (int j = 0; j < s2; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

void Diag(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    if (row != column)
    {
        Console.WriteLine("Не квадрат ");
    }
    else
    {
        double summa = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if (i == j)
                {
                    summa = summa + arr[i, j];
                }
            }
        }
        Console.WriteLine(summa);
    }

}


double[,] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine();
Diag(arr_1);