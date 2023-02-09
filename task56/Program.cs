int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matr = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],4}, ");
            else Console.Write($"{matr[i, j],4} ");

        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}

int[] FindLeastAvrgRow(int[,] mtrx)
{
    int[] rowSum = new int[mtrx.GetLength(0)];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            sumRow += mtrx[i, j];
        }
        rowSum[i] = sumRow;
    }
    return rowSum;
}

int ArrayLeastIndex(int[] arr)
{
    int min = arr[0];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            index = i;
        }
    }
    return index;
}

int[,] matrix = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(matrix);
int[] avarage = FindLeastAvrgRow(matrix);
int leastIndex = ArrayLeastIndex(avarage);
Console.WriteLine($"Строка с наименьшей суммой элементов -> {leastIndex}");