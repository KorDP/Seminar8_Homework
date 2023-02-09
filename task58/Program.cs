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

int[,] MultMatrices(int[,] mA, int[,] mB)
{
    int rowA = mA.GetLength(0);
    int colA = mA.GetLength(1);
    int rowB = mB.GetLength(0);
    int colB = mB.GetLength(1);
    int[,] res = new int[rowA, colB];
    //int i,j,k;
    if (colA == rowB)
    {
        for (int i = 0; i < colB; i++)
        {
            for (int j = 0; j < rowA; j++)
            {
                for (int k = 0; k < colA; k++)
                {
                    res[j,i] += mA[j, k] * mB[k, i];
                }
            }
        }
    }
    else
    {
        Console.WriteLine($"{colA} is not equal to {rowB}");
    }
    return res;
}

int[,] matrixA = CreateMatrixRndInt(2, 2, 1, 9);
int[,] matrixB = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(matrixA);
PrintMatrix(matrixB);
int[,] result = MultMatrices(matrixA, matrixB);
PrintMatrix(result);