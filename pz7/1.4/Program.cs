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

void Poisk(double[,] arr,double elem)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    bool vhozhdenie = false;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (elem == arr[i,j]) 
            {Console.WriteLine($"[{i},{j}]");
            vhozhdenie = true;
            break;
            }
        }
        break;
    }
    if (vhozhdenie is false) Console.WriteLine("нет элемента");

}

double[,] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));       
Console.WriteLine("дайте номер");   
int nomer = int.Parse(Console.ReadLine());          
Print(arr_1);
Poisk(arr_1,nomer);